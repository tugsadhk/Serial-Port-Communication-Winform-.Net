using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_SerialPortCom1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			findConnectedPorts();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				serialPort1.PortName = COMPort_cmbBox.Text;
				serialPort1.BaudRate = Convert.ToInt32(baudRate_cmbBox.Text);
				//Console.WriteLine(Convert.ToInt32(baudRate_cmbBox.Text));
				serialPort1.DataBits = Convert.ToInt32(DataBits_cmbBox.Text);
				serialPort1.Parity = System.IO.Ports.Parity.None;
				serialPort1.StopBits = System.IO.Ports.StopBits.One;
				serialPort1.DtrEnable = true;
				serialPort1.Open();
				progressBar1.Value = 100;
			}
			catch (Exception exe)
			{
				MessageBox.Show(exe.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//throw;
			}
		}

		public void findConnectedPorts()
		{
			string[] ports = SerialPort.GetPortNames();
			foreach (string port in ports)
			{
				COMPort_cmbBox.Items.Add(port);
			}
		}

		private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			string incomingText = serialPort1.ReadExisting();
			writeIncomingData(incomingText);
		}

		private void writeIncomingData(string text)
		{
			//ReceiverTextBox.Text = text;
			BeginInvoke(new EventHandler(delegate
			{
				ReceiverTextBox.ResetText();
				ReceiverTextBox.AppendText(text);
				ReceiverTextBox.ScrollToCaret();
			}));
		}

		private void SendBtn_Click(object sender, EventArgs e)
		{
			serialPort1.WriteLine(transmitTxtBox.Text);
			transmitTxtBox.Text = null;
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			serialPort1.Close();
			progressBar1.Value = 0;
		}
	}
}
