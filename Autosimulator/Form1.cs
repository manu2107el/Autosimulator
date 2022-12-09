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
            decimal ps = 100 / Convert.ToDecimal( auto.PS);
            decimal speed = auto.AktuelleGeschwindigkeit;

            decimal spedometer= ps * speed;
            SpeedBar.Value = Convert.ToInt32(spedometer);
           
        }
        private void comboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            auto = comboBoxAutos.SelectedItem as Auto;
        }

        private void EngineStartBar_Click(object sender, EventArgs e)
        {
            if (auto.IstMototGestartet != true) { 
            for(int i = 0; i <= 100; i++)
            {
                EngineStartBar.Value = i;
                Startlabel.Text = "Starting...";
                
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
                Thread.Sleep(200);
                Dashboard();
                Application.DoEvents();
            }
        }
        private void button1_leave(object sender, EventArgs e)
        {
            IstGasGedrueckt = false;
        }
    }
}
