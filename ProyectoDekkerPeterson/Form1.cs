using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDekkerPeterson
{
    public partial class Form1 : Form
    {
        delegate void delegado(int valor);

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy/MM/dd HH:mm:ss.ffff");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread H1 = new Thread(new ThreadStart(Atender));
            Thread H2 = new Thread(new ThreadStart(Atender));
            H1.Start();
            H2.Start();
        }

        public void Atender()
        {
            for (int n = 1; n <= Convert.ToInt32(textBox1.Text); n++)
            {
                delegado MD = new delegado(ActualizarFactorial);
                this.Invoke(MD, new object[] { n });
                Thread.Sleep(20);
            }
        }

        public void ActualizarFactorial(int valor)
        {
            textBox2.Text = textBox2.Text + GetTimestamp(DateTime.Now) + " - " + "Atendiendo Uso De Hilos Factorial 1:   " + valor + "\r\n";
        }
    }
}
