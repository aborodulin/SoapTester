using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SoapTester
{
    public partial class SoapTesterForm : Form
    {
        public SoapTesterForm()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            versionStatusLabel.Text = "Version: " + Application.ProductVersion;

            headersTextBox.Text = @"SoapAction:http://harlandfs.com/pl/TransactionExchange/TESignon";
            urlTextBox.Text = "http://localhost:1142/MultiLogService.ashx";
            requestTextBox.Text = @"<?xml version=""1.0"" encoding=""utf-8""?>
<soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <soap:Header>
    <TEAuthRq xmlns=""http://harlandfs.com/pl/TransactionExchange"">
      <IfxSignonRq>
        <SignonRq xmlns="""">
          <SignonPswd>
            <SignonRole>Customer</SignonRole>
            <CustId>
              <SPName>ACCESS</SPName>
              <CustLoginId>100920</CustLoginId>
            </CustId>
            <CustPswd>
              <CryptType>None</CryptType>
              <Pswd>X</Pswd>
            </CustPswd>
            <GenSessKey>0</GenSessKey>
          </SignonPswd>
          <ClientDt>2017-09-24T02:41:23.551238-00:00</ClientDt>
          <CustLangPref>EN</CustLangPref>
        </SignonRq>
      </IfxSignonRq>
      <IfxVersion>1.3</IfxVersion>
    </TEAuthRq>
  </soap:Header>
  <soap:Body />
</soap:Envelope>";

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                responseTextBox.BackColor = DefaultBackColor;
                startButton.Enabled = false;
                stopButton.Enabled = true;
                SoapRequest request = new SoapRequest(urlTextBox.Text, requestTextBox.Text, methodTextBox.Text, acceptTextBox.Text, headersTextBox.Text, contentTypeTextBox.Text);
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync(request);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
                stopButton.Enabled = false;
            }
        }

        // This event handler is where the time-consuming work is done.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            //responseTextBox.Text = "1";// String.Empty;
            soapTesterStatus.Text = "Executing...";

            e.Result = SoapTesterService.Execute(e.Argument as SoapRequest);

            //TODO support cancel/stop request.
            //    if (worker.CancellationPending == true)
            //    {
            //        e.Cancel = true;
            //        break;
            //    }            
        }

        // This event handler updates the progress.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            statusStrip1.Text = (e.ProgressPercentage.ToString() + "%");
        }

        // This event handler deals with the results of the background operation.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;

            SoapResponse response = e.Result as SoapResponse;

            if (e.Cancelled == true)
            {
                soapTesterStatus.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                soapTesterStatus.Text = "Error: " + e.Error.Message;
            }
            else
            {
                soapTesterStatus.Text = "Done!";
            }

            if (response.IsError)
            {
                responseTextBox.BackColor = Color.LightPink;
                responseTextBox.Text = "Response:" + response.Response + Environment.NewLine + Environment.NewLine + "Error:" + response.Error;
            }
            else
            {
                responseTextBox.BackColor = Color.PaleGreen;
                responseTextBox.Text = response.Response;
            }
        }
    }
}
