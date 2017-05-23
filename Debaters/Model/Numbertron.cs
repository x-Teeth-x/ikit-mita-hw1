using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        public delegate void NumberHendler(int a);
        public event NumberHendler NewNumber;

        public void Generate(int numb)
        {
            Random run = new Random();
            for (int i = 0; i < numb; i++)
            {
                NewNumber?.Invoke(run.Next());
            }
        }
    }
}
