using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosimulator
{
    internal class Auto
    {
        public string Marke { get; private set; }
        public int PS { get; private set; }
        public int AktuelleGeschwindigkeit { get; private set; }
        public int AktuellerGang { get; private set; }
        public bool IstMototGestartet { get; private set; }
        
        public Auto(string marke, int ps)
        {
            this.Marke = marke;
            this.PS = ps;
        }
        public void StarteMotor()
        {
            IstMototGestartet = true;
        }
        public void SchalteMototAus()
        {
            IstMototGestartet = false;
        }
        public void GibGas()
        {   
            int MaxSpeed = PS;
            if (IstMototGestartet && AktuelleGeschwindigkeit <= MaxSpeed)
            {
                AktuelleGeschwindigkeit += PS/10;
                Getriebe();
            }
        }
        public void Bremse()
        {
            AktuelleGeschwindigkeit -= 10;
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
