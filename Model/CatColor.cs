using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CatColor
    {
        public string HeathyColor { get; set; }
        public string SickColor { get; set; }
        public CatColor(string heathycol, string sickcol)
        {
            HeathyColor = heathycol;
            SickColor = sickcol;
        }

    }
}
