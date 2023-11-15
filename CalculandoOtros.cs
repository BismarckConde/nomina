using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLogin
{
    public class CalculandoOtros : ICalculandoOtros
    {
        public double salBas { get ; set ; }
        public double InssPatronal { get ; set ; }
        public double Inatec { get ; set; }
        public double Vacacciones { get; set ; }
        public CalculandoOtros(double sal) 
        {
            salBas = sal;
        }

        public double CalculandoInatec()
        {
            Inatec = salBas*0.02;
            return Math.Round(Inatec, 4);
        }

        public double CalculandoInssPatronal()
        {
            InssPatronal=salBas*0.225;
            return Math.Round(InssPatronal, 4);
        }

        public double CalculandoVacacciones()
        {
            Vacacciones = salBas / 30;
            Vacacciones = Vacacciones * 2.5;
            return Math.Round(Vacacciones, 4);
        }
    }
}
