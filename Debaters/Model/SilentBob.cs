using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SilentBob: Gambler
    {
        public SilentBob() : base("Silent Bob")
        {
        }

        public override void FetchNewNumber(int i)
        {
            if (i.IsEven() == false)
            {
                Score = Score + 1;
            }
        }
    }
}
