using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_OOP_QUIZ.Obj_Car
{
    internal class Cars
    {
        //instant variabel
        private string noPolisi;
        private int tahun;
        private string type;

        //static variable
        public static string totalNoPolisi;
        public static decimal toalRavenue = 0M;

        public Cars()
        {
        }

        public Cars(string noPolisi, int tahun, string type)
        {
            this.noPolisi = noPolisi;
            this.tahun = tahun;
            this.type = type;
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public string Type { get => type; set => type = value; }

    
    }
}
