namespace Arduino_SerialPortCom1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.transmitTxtBox = new System.Windows.Forms.TextBox();
			this.ReceiverTextBox = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.DataBits_cmbBox = new System.Windows.Forms.ComboBox();
			this.baudRate_cmbBox = new System.Windows.Forms.ComboBox();
			this.COMPort_cmbBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// transmitTxtBox
			// 
			this.transmitTxtBox.Location = new System.Drawing.Point(394, 150);
			this.transmitTxtBox.Multiline = true;
			this.transmitTxtBox.Name = "transmitTxtBox";
			this.transmitTxtBox.Size = new System.Drawing.Size(215, 193);
			this.transmitTxtBox.TabIndex = 0;
			// 
			// ReceiverTextBox
			// 
			this.ReceiverTextBox.Location = new System.Drawing.Point(657, 150);
			this.ReceiverTextBox.Multiline = true;
			this.ReceiverTextBox.Name = "ReceiverTextBox";
			this.ReceiverTextBox.Size = new System.Drawing.Size(215, 193);
			this.ReceiverTextBox.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox3.Location = new System.Drawing.Point(394, 109);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "Send Data";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox4.Location = new System.Drawing.Point(657, 109);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "Read Data";
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.progressBar1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.comboBox4);
			this.groupBox1.Controls.Add(this.DataBits_cmbBox);
			this.groupBox1.Controls.Add(this.baudRate_cmbBox);
			this.groupBox1.Controls.Add(this.COMPort_cmbBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(25, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(324, 415);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(71, 305);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(185, 46);
			this.progressBar1.TabIndex = 13;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(168, 246);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 40);
			this.button2.TabIndex = 12;
			this.button2.Text = "Disconnect";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button1
			// 
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.button1.Location = new System.Drawing.Point(19, 246);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 40);
			this.button1.TabIndex = 11;
			this.button1.Text = "Connect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
			this.comboBox4.Location = new System.Drawing.Point(149, 173);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(121, 24);
			this.comboBox4.TabIndex = 9;
			this.comboBox4.Text = "None";
			// 
			// DataBits_cmbBox
			// 
			this.DataBits_cmbBox.FormattingEnabled = true;
			this.DataBits_cmbBox.Location = new System.Drawing.Point(149, 133);
			this.DataBits_cmbBox.Name = "DataBits_cmbBox";
			this.DataBits_cmbBox.Size = new System.Drawing.Size(121, 24);
			this.DataBits_cmbBox.TabIndex = 8;
			this.DataBits_cmbBox.Text = "8";
			// 
			// baudRate_cmbBox
			// 
			this.baudRate_cmbBox.FormattingEnabled = true;
			this.baudRate_cmbBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
			this.baudRate_cmbBox.Location = new System.Drawing.Point(149, 93);
			this.baudRate_cmbBox.Name = "baudRate_cmbBox";
			this.baudRate_cmbBox.Size = new System.Drawing.Size(121, 24);
			this.baudRate_cmbBox.TabIndex = 7;
			this.baudRate_cmbBox.Text = "9600";
			// 
			// COMPort_cmbBox
			// 
			this.COMPort_cmbBox.FormattingEnabled = true;
			this.COMPort_cmbBox.Location = new System.Drawing.Point(149, 50);
			this.COMPort_cmbBox.Name = "COMPort_cmbBox";
			this.COMPort_cmbBox.Size = new System.Drawing.Size(121, 24);
			this.COMPort_cmbBox.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Parity";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Data Bits";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Baud Rate";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "COM Port";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.Location = new System.Drawing.Point(440, 376);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(114, 51);
			this.button3.TabIndex = 5;
			this.button3.Text = "Send";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.SendBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 500);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.ReceiverTextBox);
			this.Controls.Add(this.transmitTxtBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.TextBox transmitTxtBox;
		private System.Windows.Forms.TextBox ReceiverTextBox;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox DataBits_cmbBox;
		private System.Windows.Forms.ComboBox baudRate_cmbBox;
		private System.Windows.Forms.ComboBox COMPort_cmbBox;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button button3;
	}
}

