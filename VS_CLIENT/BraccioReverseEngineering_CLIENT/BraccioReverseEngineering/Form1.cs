using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace BraccioReverseEngineering {
    public partial class Form1 : Form {
        private static SerialPort _serialPort;
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            // Inizializzazione seriale 
            var porte = SerialPort.GetPortNames();
            _serialPort = new SerialPort(porte[porte.Length - 1], 115200, Parity.None, 8, StopBits.One) { NewLine = "\n" };
            _serialPort.Handshake = Handshake.None;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            _serialPort.Open();
        }

        private void EventStop(object sender, MouseEventArgs e) {
            stop();
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            _serialPort.ReadExisting();
        }

        private void start(string motor,string direz) {
            string a = "START " + motor.ToUpper() + " " + direz.ToUpper() + " " + txtVelocità.Text;
            _serialPort.WriteLine(a);
            rTxtConsole.AppendText(a + "\r\n");
        }
        private void stop() {
            _serialPort.WriteLine("STOP");
            rTxtConsole.AppendText("STOP\r\n");
        }

        private void btn4Up_MouseDown(object sender, MouseEventArgs e) {
            start("D", "up");
        }

        private void btn4Up_MouseUp(object sender, MouseEventArgs e) {
            stop();
        }

        private void btn4Down_MouseDown(object sender, MouseEventArgs e) {
            start("D", "down");
        }

        private void btn4Down_MouseUp(object sender, MouseEventArgs e) {
            stop();
        }

        private void btn1Open_MouseUp(object sender, MouseEventArgs e) {
            stop();
        }

        private void btn1Open_MouseDown(object sender, MouseEventArgs e) {
            start("A", "open");
        }

        private void btn1Close_MouseUp(object sender, MouseEventArgs e) {
            stop();
        }

        private void btn1Close_MouseDown(object sender, MouseEventArgs e) {
            start("A", "close");
        }

        private void btn2Up_MouseUp(object sender, MouseEventArgs e) {
            stop();
        }

        private void btn2Up_MouseDown(object sender, MouseEventArgs e) {
            start("B", "up");
        }

        private void btn3Up_MouseDown(object sender, MouseEventArgs e) {
            start("C", "up");
        }

        private void btn3Up_MouseUp(object sender, MouseEventArgs e) {
            stop();
        }

        private void btn2Down_MouseDown(object sender, MouseEventArgs e) {
            start("B", "down");
        }

        private void btn5Left_MouseDown(object sender, MouseEventArgs e) {
            start("E", "left");
        }

        private void btn5Right_MouseDown(object sender, MouseEventArgs e) {
            start("E", "right");
        }

        private void btn3Down_MouseDown(object sender, MouseEventArgs e) {
            start("C", "down");
        }

        private void button1_Click(object sender, EventArgs e) {
            stop();
        }
    }
}
