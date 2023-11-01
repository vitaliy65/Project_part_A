using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_A
{
    public class Fantasticbeast : IFantasticBeasts
    {
        string name;
        Behavior behavior;
        Abilities abilities;
        Size size;

        public string Name 
        { 
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public Behavior Behavior
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public Abilities Abilities
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public Size Size
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public History? history { get; set; }
        public Environment? environment { get; set; }

        public Fantasticbeast(History? history, Environment? environment, string name, Behavior behavior, Abilities abilities, Size size)
        {
            throw new NotImplementedException();
        }

        public void GetFullInformationAboutBeast() 
        {
            throw new NotImplementedException();
        }
    }
}
