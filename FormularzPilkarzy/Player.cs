using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularzPilkarzy
{
    class Player
    {
        private string _name;
        private string _surrname;
        private float _weight;
        private int _age;

        public Player(string name = "None", string surrname = "None2", float weight = 60f, int age = 25 )
        {
            _name = name;
            _surrname = surrname;
            _weight = weight;
            _age = age;
        }

        public Player(Player p)
        {
            _name = p.Name;
            _surrname = p.Surrname;
            _weight = p.Weight;
            _age = p.Age;
        }

        public override string ToString()
        {
            return $"{Name} {Surrname} waga: {Weight} wiek: {Age}";
        }

        public string Name { get { return _name; } set {_name = value; } }
        public string Surrname { get {return _surrname; } set {_surrname =value; } }
        public float Weight { get {return _weight; } set { _weight = value; } }
        public int Age { get { return _age; } set { _age = value; } }
    }
}
