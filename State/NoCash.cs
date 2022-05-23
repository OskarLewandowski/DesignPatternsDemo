using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class NoCash : State
    {
        public NoCash(Context context) : base(context)
        {

        }
        public override void EjectCard()
        {
            Console.WriteLine("ATM is closed.\nSorry we are out of cash");
        }

        public override void InsertCard()
        {
            Console.WriteLine("ATM is closed.\nSorry we are out of cash");
        }

        public override void InsertPin(int pin)
        {
            Console.WriteLine("ATM is closed.\nSorry we are out of cash");
        }

        public override void WithdrawCash(int amount)
        {
            Console.WriteLine("ATM is closed.\nSorry we are out of cash");
        }
    }
}
