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
        private static string totalNoPolisi;
        private decimal totalRavenue;

        public Cars()
        {

        }



        public Cars(string noPolisi, int tahun)
        {
            this.noPolisi = noPolisi;
            this.tahun = tahun;
            totalRavenue = 0;
        }


        public override string? ToString()
        {
            return $"NoPolisi = {this.noPolisi} | {this.tahun} | {this.Type1}";
        }

        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public string Type { get => Type1; set => Type1 = value; }
        public static string TotalNoPolisi { get => totalNoPolisi; set => totalNoPolisi = value; }
        public decimal TotalRavenue { get => totalRavenue; set => totalRavenue = value; }
        public decimal TotalRavenue1 { get => totalRavenue; set => totalRavenue = value; }
        public string Type1 { get => type; set => type = value; }
    }
}
