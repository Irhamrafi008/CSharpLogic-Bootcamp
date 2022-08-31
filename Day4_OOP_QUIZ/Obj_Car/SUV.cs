using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_OOP_QUIZ.Obj_Car
{
    internal class SUV : Cars
    {
        private decimal sewa;
        private decimal sopir;

        public SUV(string noPolisi, int tahun, decimal sewa, decimal sopir) : base(noPolisi, tahun)
        {
            this.sewa = sewa;
            this.sopir = sopir;
            Type = "SUV";
            TotalRavenue = sewa + sopir;
        }

        public decimal Sewa { get => sewa; set => sewa = value; }
        public decimal Sopir { get => sopir; set => sopir = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Sewa = {this.sewa.ToString("C", new CultureInfo("id-ID"))} | Sopir = {this.sopir.ToString("C", new CultureInfo("id-ID"))} | " +
                $" Total Ravenue = {TotalRavenue.ToString("C", new CultureInfo("id-ID"))}\n";
        }
    }
}
