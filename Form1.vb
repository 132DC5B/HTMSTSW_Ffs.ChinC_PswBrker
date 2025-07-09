Imports System.Management
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.Win32
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Firefox
Imports OpenQA.Selenium.Support.UI

Public Class Form1

    Private driver As IWebDriver
    Private forceStopRequested As Boolean = False

    Private Const MySecretKey As String = "4F213B267D6F7EB6CBED83516DCB1"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsLicensed() Then
            ActivateLicense()
        End If
    End Sub

    Private Sub ActivateLicense()
        Dim machineId As String = GetMachineId()
        Dim prompt As String = $"Enter License Key Here:" & vbCrLf & $"{machineId}"

        Do
            Dim licenseKey As String = Interaction.InputBox(prompt, "License")

            If String.IsNullOrWhiteSpace(licenseKey) Then
                Me.Close()
                Return
            End If

            If ValidateLicense(licenseKey) Then
                SaveLicense(licenseKey)
                Exit Do
            Else
                MessageBox.Show("Invaild License Key", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Loop
    End Sub

    Private Function IsLicensed() As Boolean
        Try
            Using regKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\passwordBreaker")
                If regKey IsNot Nothing Then
                    Dim storedKey = regKey.GetValue("LicenseKey")?.ToString()
                    If storedKey IsNot Nothing AndAlso ValidateLicense(storedKey) Then
                        Return True
                    End If
                End If
            End Using
            Return False
        Catch
            Return False
        End Try
    End Function

    Private Function ValidateLicense(licenseKey As String) As Boolean
        Dim machineId As String = GetMachineId()
        Dim expectedKey As String = GenerateLicenseKey(machineId)
        Return licenseKey.Trim().ToUpper() = expectedKey
    End Function

    Private Sub SaveLicense(licenseKey As String)
        Using regKey As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\passwordBreaker")
            regKey.SetValue("LicenseKey", licenseKey)
        End Using
    End Sub

    Private Function GetMachineId() As String
        Try
            Dim mbs As New ManagementObjectSearcher("Select ProcessorId From Win32_Processor")
            Dim mbsList As ManagementObjectCollection = mbs.Get()
            Dim id As String = ""
            For Each mo As ManagementObject In mbsList
                id = mo("ProcessorId").ToString()
                Exit For
            Next
            Return id
        Catch
            Return Environment.MachineName
        End Try
    End Function

    Private Function GenerateLicenseKey(machineId As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim plainText As String = $"{machineId}-{MySecretKey}"
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainText))
            Return BitConverter.ToString(bytes).Replace("-", "").Substring(0, 24).ToUpper()
        End Using
    End Function
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RichTextBox1.Text IsNot "" Then
            ProgressBar1.Value = 0
            RichTextBox1.Enabled = False
            Button1.Enabled = False
            forceStopMenuItem1.Enabled = True
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            RichTextBox5.Visible = False
            RichTextBox4.Text = Nothing
            RichTextBox5.Text = Nothing
            forceStopRequested = False
            Await Task.Run(Sub() StartSeleniumDemo())
        Else
            Return
        End If
    End Sub

    Sub StartSeleniumDemo()
        Try
            Dim service As FirefoxDriverService = FirefoxDriverService.CreateDefaultService()
            service.HideCommandPromptWindow = True
            Dim options As New FirefoxOptions()
            options.AddArgument("--start-maximized")
            options.AddArgument("--headless")
            driver = New FirefoxDriver(service, options)
            AppendDebugInfo("Created Firefox driver" & vbCrLf & "Navigate go to url")

            driver.Navigate().GoToUrl("https://fireflies.chiculture.org.hk/")
            AppendDebugInfo("Url Loaded")
            Dim loginBtn As IWebElement = driver.FindElement(By.CssSelector("button.btn-tertiary"))
            Dim emailBox As IWebElement = driver.FindElement(By.Name("email"))
            AppendDebugInfo("Element Defined")
            AppendDebugInfo("Start")
            emailBox.SendKeys(RichTextBox1.Text & RichTextBox2.Text & RichTextBox3.Text)
            AppendDebugInfo("Sent Account Address")
            Dim passwordBox As IWebElement = driver.FindElement(By.Name("password"))
            Dim startDate As Date = DateTimePicker1.Value
            Dim endDate As Date = DateTimePicker2.Value
            Dim currentDate As Date = startDate
            AppendDebugInfo("From " & DateTimePicker1.Value)
            AppendDebugInfo("To " & DateTimePicker2.Value)
            AppendDebugInfo("Start")
            Do While currentDate <= endDate
                If forceStopRequested Then Exit Do
                passwordBox.SendKeys("Ht" & Format(currentDate, "yyyyMMdd"))
                currentDate = currentDate.AddDays(1)
                loginBtn.Click()
                If emailBox.Displayed Then
                    passwordBox.Clear()
                    Me.Invoke(Sub()
                                  ProgressBar1.Value = Math.Min(ProgressBar1.Value + 1, ProgressBar1.Maximum)
                                  RichTextBox5.Text = "Ht" & Format(currentDate, "yyyyMMdd")
                              End Sub)
                Else
                    Return
                End If
            Loop
        Catch ex As Exception
            Try
                Dim heading As IWebElement = driver.FindElement(By.CssSelector("h4.mb-2"))
                Me.Invoke(Sub()
                              RichTextBox4.Text = heading.Text
                              RichTextBox5.Visible = True
                              Button1.Enabled = True
                              forceStopMenuItem1.Enabled = False
                              RichTextBox1.Enabled = True
                              DateTimePicker1.Enabled = True
                              DateTimePicker2.Enabled = True
                              Do While ProgressBar1.Value < ProgressBar1.Maximum
                                  ProgressBar1.Value += 1
                              Loop
                              AppendDebugInfo(RichTextBox4.Text)
                              AppendDebugInfo(RichTextBox5.Text)
                          End Sub)
            Catch
                Me.Invoke(Sub()
                              RichTextBox4.Text = "ERROR:" & ex.Message
                              RichTextBox5.Visible = True
                              Button1.Enabled = True
                              forceStopMenuItem1.Enabled = False
                              RichTextBox1.Enabled = True
                              DateTimePicker1.Enabled = True
                              DateTimePicker2.Enabled = True
                              AppendDebugInfo(RichTextBox4.Text)
                              AppendDebugInfo(RichTextBox5.Text)
                          End Sub)
            End Try
        Finally
            forceStopRequested = False
            If driver IsNot Nothing Then
                driver.Quit()
            End If
            Me.Invoke(Sub()
                          Button1.Enabled = True
                          forceStopMenuItem1.Enabled = False
                          RichTextBox1.Enabled = True
                          DateTimePicker1.Enabled = True
                          DateTimePicker2.Enabled = True
                      End Sub)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If driver IsNot Nothing Then
            driver.Quit()
        End If
    End Sub
    Private Sub AppendDebugInfo(msg As String)
        If RichTextBox6.InvokeRequired Then
            RichTextBox6.Invoke(Sub() RichTextBox6.AppendText(DateTime.Now.ToString("HH:mm:ss ") & msg & vbCrLf))
        Else
            RichTextBox6.AppendText(DateTime.Now.ToString("HH:mm:ss ") & msg & vbCrLf)
        End If
    End Sub
    Private Sub forceStopMenuItem1_Click(sender As Object, e As EventArgs) Handles forceStopMenuItem1.Click
        forceStopRequested = True
        If driver IsNot Nothing Then
            driver.Quit()
        End If
    End Sub

    Private Sub applicationMenuItem_Click(sender As Object, e As EventArgs) Handles applicationMenuItem.Click
        Me.Close()
    End Sub
End Class