using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_A
{
    public class Environment : IEnvironment
    {
        string location;
        string climate;
        List<string> resources;

        public string Location
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public string Climate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public List<string> Resources
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public Environment(string location, string climate, List<string> resources) 
        {
            throw new NotImplementedException();
        }

        public void GetFullInformationAboutLocation()
        {
            throw new NotImplementedException();
        }
    }
}
