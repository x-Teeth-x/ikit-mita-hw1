using System;

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
        public string Age { get; }
        public CatColor Color { get; set; }
        private int _health;
        public Cat(string age, int health)
        {
            Age = age;
            _health = health;
        }
        public int Feed()
        {
            return _health = _health + 1;
        }
        public int Punish()
        {
            return _health = _health - 1;
        }
        public string CurrentColor()
        {
            if (this._health < 0)
            { return this.Color.SickColor; }
            else return this.Color.HeathyColor;

        }

    }
}
