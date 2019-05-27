using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BraccioReverseEngineering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Inizializzazione seriale 

        }

        // Evento scatenato alla pressione di un tasto
        private void btn1Close_KeyDown(object sender, KeyEventArgs e)
        {
            // Invio lo start all'arduino
        }

        // Evento scatenato al rilacio di un tasto
        private void btn1Close_KeyUp(object sender, KeyEventArgs e)
        {
            // Invio lo stop all'arduino
        }
    }
}
