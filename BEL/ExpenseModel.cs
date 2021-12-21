using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ExpenseModel
    {
        public int ExpID { get; set; }
        public int SalaryExp { get; set; }
        public int UtilityExp { get; set; }
        public int ElectricityExp { get; set; }
        public int RentExp { get; set; }
    }
}
