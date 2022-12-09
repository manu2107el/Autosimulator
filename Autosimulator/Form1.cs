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

namespace Autosimulator
{
    public partial class Form1 : Form
    {
        private Auto auto;
        private bool IstGasGedrueckt;
        private bool IstBremseGedrueckt;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Dashboard()
        {

            
            if (auto.IstMototGestartet == true)
            {
                Startlabel.Text = "Stop";
            }
            else
            {
                Startlabel.Text = "Start";
            }
            if (auto.lastknownspeed < auto.AktuelleGeschwindigkeit)
            {
                for (int i = auto.lastknownspeed; i < auto.AktuelleGeschwindigkeit; i++)
                {
                    kmhlabel.Text = Convert.ToString(i);
                    Thread.Sleep(5);
                    panel2.Height = auto.Speedometer();
                    Application.DoEvents();
                }
            }
            if (auto.lastknownspeed > auto.AktuelleGeschwindigkeit)
            {
                for (int i = auto.lastknownspeed; i > auto.AktuelleGeschwindigkeit; i--)
                {
                    kmhlabel.Text = Convert.ToString(i);
                    Thread.Sleep(5);
                    panel2.Height = auto.Speedometer();
                    Application.DoEvents();
                }
            }

        }
        private void comboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            auto = comboBoxAutos.SelectedItem as Auto;
            Dashboard();
        }

        private void EngineStartBar_Click(object sender, EventArgs e)
        {
            if (auto == null)
                MessageBox.Show("Auto Ausfählen");
            if (auto == null)
                return;

            if (auto.IstMototGestartet != true) { 
            for(int i = 0; i <= 100; i++)
            {
                EngineStartBar.Value = i;
                Startlabel.Text = "Starting...";
                     Application.DoEvents();
                    Thread.Sleep(10);
                   

                }
                auto.StarteMotor();
                Startlabel.Text = "Stop";
            }
            else
            {
                for (int i = 0; i <= 100; i++)
                {
                    EngineStartBar.Value = i;
                    Startlabel.Text = "Stoping...";
                    Thread.Sleep(10);
                    Application.DoEvents();
                }
                auto.SchalteMototAus();
                Startlabel.Text = "Start";
            }
        }
        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBoxAutos.Items.Add(new Auto("Porsche", 250));
            comboBoxAutos.Items.Add(new Auto("Opel", 90));
            comboBoxAutos.Items.Add(new Auto("Ferrari", 370));
            
        }

        private void button1_hover(object sender, EventArgs e)
        {
            if (auto == null)
                return;
            

            IstGasGedrueckt = true;

            while (IstGasGedrueckt)
            {
                auto.GibGas();
                Thread.Sleep(10);
                Dashboard();
                Application.DoEvents();
            }
        }
        private void button1_leave(object sender, EventArgs e)
        {
            IstGasGedrueckt = false;
            if (auto == null)
                return;
          
        }
        private void button2_hover(object sender, EventArgs e)
        {
            if (auto == null)
                return;

            IstBremseGedrueckt = true;

            while (IstBremseGedrueckt)
            {
                auto.Bremse();
                Thread.Sleep(10);
                Dashboard();
                Application.DoEvents();
            }
        }
        private void button2_leave(object sender, EventArgs e)
        {
            IstBremseGedrueckt = false;
            if (auto == null)
                return;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (auto == null)
                return;
            auto.Hupe();
        }
    }
}
