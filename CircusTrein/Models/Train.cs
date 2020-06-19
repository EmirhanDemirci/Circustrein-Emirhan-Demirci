using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Models
{
    public class Train
    {
        private readonly List<Wagon> _wagons;

        public Train()
        {
            _wagons = new List<Wagon>();
        }

        //Get the wagon
        public void AddWagon(Wagon wagon)
        {
            _wagons.Add(wagon);  
        }

        //Get all the wagons back
        public List<Wagon> GetWagon()
        {
            return _wagons;
        }
    }
}
D