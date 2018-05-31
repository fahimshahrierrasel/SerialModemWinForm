using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace SerialModemWinForm
{
    public partial class MainWindow : Form
    {
        static SerialPort serialPort;

        public MainWindow()
        {
            InitializeComponent();
            PopulatePortCombobox();
        }

        private List<string> GetAllModemPorts()
        {
            List<string> portsList = new List<string>();

            ManagementObjectSearcher modemSearcher =
                new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_POTSModem");

            try
            {
                foreach (ManagementBaseObject mbo in modemSearcher.Get())
                {
                    if (mbo["Status"].Equals("OK"))
                    {
                        portsList.Add(mbo["AttachedTo"].ToString());
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return portsList;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            PopulatePortCombobox();
        }

        private void PopulatePortCombobox()
        {
            List<string> ports = SerialPort.GetPortNames().ToList();
            comboBoxPorts.DataSource = ports;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Disconnect")
            {
                serialPort.Close();
                serialPort.Dispose();
                buttonConnect.Text = "Connect";
                ModemStatus.Text = "Not Connected";
            }
            else
            {
                string selectedPort = comboBoxPorts.SelectedItem.ToString();
                if (String.IsNullOrEmpty(selectedPort))
                {
                    MessageBox.Show("Please Pressed Find First");
                }
                else
                {
                    serialPort = new SerialPort
                    {
                        PortName = selectedPort,
                        BaudRate = 115200,
                        StopBits = StopBits.One,
                        DataBits = 8,
                        Parity = Parity.None,
                        Handshake = Handshake.RequestToSend
                    };
                    serialPort.DataReceived += PortOnReceivedData;

                    serialPort.Open();
                    if (serialPort.IsOpen)
                    {
                        ModemStatus.Text = $"{selectedPort} is Connected";
                        buttonConnect.Text = "Disconnect";
                    }
                }
            }
        }

        private void PortOnReceivedData(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort) sender;
            if (resultTestBox.InvokeRequired)
            {
                resultTestBox.Invoke(new SerialDataReceivedEventHandler(PortOnReceivedData), sender, e);
            }
            else
            {
                while (sp.BytesToRead > 0)
                {
                    string message = sp.ReadExisting();
                    resultTestBox.AppendText(message);
                }
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                serialPort.Dispose();
            }
        }

        private void submitUssd_Click(object sender, EventArgs e)
        {
            string ussdCode = textBoxUSSD.Text;
            if (String.IsNullOrEmpty(ussdCode)) return;
            serialPort.Write($"AT+CUSD=1,\"{ussdCode}\",15\r");
        }

        private void submitAT_Click(object sender, EventArgs e)
        {
            string command = textBoxATcmd.Text;
            if (String.IsNullOrEmpty(command)) return;
            serialPort.Write($"AT+{command}\r");
        }
    }
}