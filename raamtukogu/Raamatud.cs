using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raamtukogu
{
    internal class Raamatud
    {
        string pealkiri;
        string autor;
        double hind;
        public Raamatud(string _pealkiri, string _autor, string _hind)
        {
            pealkiri = _pealkiri;
            autor = _autor;
            hind = 0.0;
            Console.WriteLine("Sisesta raamatunimi:");
            Console.WriteLine("Sisesta raamatu autor:");
            Console.WriteLine("Sisesta raamatu hind:");
        }
        public string Raamatupealkiri
        {
            get { return pealkiri; }
        }
        public string Raamatuautor
        {
            get { return autor; }
        }
        public double Raamatuhind
        {
            get { return hind; }
        }

    }
    

}
