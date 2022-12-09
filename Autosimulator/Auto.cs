using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeedLib;

namespace Autosimulator
{
    internal class Auto : IAuto
    {
        public string Marke { get; private set; }
        public int PS { get; private set; }
        public int AktuelleGeschwindigkeit { get; private set; }
        public int AktuellerGang { get; private set; }
        public bool IstMototGestartet { get; private set; }
        public int lastknownspeed { get; private set; }

        SpeedoMeter speedo;

        
        public Auto(string marke, int ps)
        {
            this.Marke = marke;
            this.PS = ps;

            speedo = new SpeedoMeter(this);
        }
        public void StarteMotor()
        {
            IstMototGestartet = true;
        }
        public void SchalteMototAus()
        {
            IstMototGestartet = false;
        }

        public int Speedometer()
        {
            return speedo.Speedometer300();
        }

        //public int Speedometer()
        //{
        //    decimal ps = 100 / Convert.ToDecimal(PS);
        //    decimal speed = AktuelleGeschwindigkeit;

        //    decimal spedometer = ps * speed;
        //    if (spedometer >= 100)
        //    {
        //        spedometer = 100;
        //    }
        //    if (spedometer <= 0)
        //    {
        //        spedometer = 0;
        //    }
        //    return Convert.ToInt32(spedometer);
        //} 
        public void GibGas()
        {   lastknownspeed = AktuelleGeschwindigkeit;
            decimal MaxSpeed = PS;
            if (IstMototGestartet && AktuelleGeschwindigkeit <= MaxSpeed)
            {
                AktuelleGeschwindigkeit += Convert.ToInt32(MaxSpeed/100);
                
                Getriebe();
            }
        }
        public void Bremse()
        {
            lastknownspeed = AktuelleGeschwindigkeit;
            if (AktuelleGeschwindigkeit > 0) { 
                AktuelleGeschwindigkeit -= 1;
            }
        }
        public void Hupe()
        {
            
         
            
        }
        private void Getriebe()
        {
            if(AktuelleGeschwindigkeit <= 10)
            {
                AktuellerGang = 1;
            }
            if(AktuelleGeschwindigkeit > 11 && AktuelleGeschwindigkeit < 21)
            {
                AktuellerGang = 2;
            }
            if(AktuelleGeschwindigkeit >= 21 && AktuelleGeschwindigkeit < 41)
            {
                AktuellerGang = 3;
            }
            if(AktuelleGeschwindigkeit >= 41 &&  AktuelleGeschwindigkeit < 71)
            {
                AktuellerGang = 4;
            }
            if(AktuelleGeschwindigkeit >= 71 && AktuelleGeschwindigkeit < 101)
            {
                AktuellerGang = 5;
            }
            if(AktuelleGeschwindigkeit >= 101)
            {
                AktuellerGang = 6;
            }
        }
        public override string ToString()
        {
            return this.Marke;
        }
    }
}
