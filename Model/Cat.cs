using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        private string _name;
        public string Name
        {
            set
            {
                if (_name == null)
                {
                    _name = value;
                }
                else throw new Exception();
            }
            get
            { return _name; }
        }
        public readonly string Age;
        public CatColor Color { get; set; }
        private int _heath { get; set; }
        public Cat(string age, int heath)
        {
            Age = age;
            _heath = heath;
        }
        public int Feed()
        {
            return _heath = _heath + 1;
        }
        public int Punish()
        {
            return _heath = _heath - 1;
        }
        public string CurrentColor()
        {
            if (this._heath < 0)
            { return this.Color.SickColor; }
            else return this.Color.HeathyColor;

        }

    }
}
