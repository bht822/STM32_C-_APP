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


namespace STM32_ADC_Viewer
{
    public partial class Form1 : Form
    {
        // Placeholder for the selected port
        public String SelectedPort;
        // Placeholder to keep the read ports
        string[] ArrayComPortNames = null;
        int index = -1;
        string ComPortName = null;
        SerialPort STM32Port = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            ArrayComPortNames = SerialPort.GetPortNames();
            ComPortList.DataSource = ArrayComPortNames;
            baudRate.Items.Add(300);
            baudRate.Items.Add(600);
            baudRate.Items.Add(1200);
            baudRate.Items.Add(2400);
            baudRate.Items.Add(9600);
            baudRate.Items.Add(19200);
            baudRate.Items.Add(115200);



        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            STM32Port.BaudRate = 115200;
            STM32Port.Parity = Parity.None;
            STM32Port.StopBits = StopBits.One;
            STM32Port.PortName = ComPortList.Text.ToString();
            STM32Port.DataBits = 8;
            STM32Port.Open();
            while (STM32Port.IsOpen) {

                richTextBox1.Text = STM32Port.ReadLine ();
            
            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ComPortList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void baudRate_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }

}
