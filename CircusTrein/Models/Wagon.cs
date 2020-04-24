using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Models
{
    public class Wagon
    {
        private List<Animal> _animals;
        private static int _Id;

        public Wagon()
        {
            _animals = new List<Animal>();
            _Id++;
        }

        //Getting the total points of each wagon
        public int GetTotalPoints()
        {
            var totalPoints = 0;
            foreach (var animal in _animals)
            {
                totalPoints = totalPoints + animal.GetPoints();
            }
            return totalPoints;
        }
        //Adding a animal
        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }
        //Checking the rules (Alghoritm)
        public bool CheckRules(Animal animal)
        {
            return CheckSize(animal.GetFormat()) && CarnivoreExists(animal);
        }

        //Checking the size of each animal
        private bool CheckSize(Format animalSize)
        {
            var totalPointsWithNewAnimal = GetTotalPoints() + Convert.ToInt16(animalSize);
            if (totalPointsWithNewAnimal > 10)
            {
                return false;
            }
            return true;
        }

        //Checking if a carnivore exists
        private bool CarnivoreExists(Animal animal)
        {
            if (animal.GetTypeAnimal() == TypeAnimal.Herbivore)
            {
                var checkCarniSize = _animals.Find(x => (x.GetTypeAnimal() == TypeAnimal.Carnivore) && (x.GetFormat() >= animal.GetFormat()));
                return checkCarniSize == null;
            }

            var checkCarnivore = _animals.Find(x => x.GetTypeAnimal() == TypeAnimal.Carnivore);
            var checkSmallerAnimal = _animals.Find(x => x.GetFormat() <= animal.GetFormat());
            return (checkCarnivore == null) && checkSmallerAnimal == null;
        }

        public override string ToString()
        {
            return $"{_Id} Wagons ";
        }
    }
}
