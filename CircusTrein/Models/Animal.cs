using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircusTrein;

namespace CircusTrein
{
    public enum TypeAnimal
    {
        Carnivore,
        Herbivore
    }

    public enum Format
    {
        Small,
        Medium,
        Large
    }

    public class Animal
    {
        private readonly TypeAnimal _type;
        private readonly Format _format;
        private int _points;

        public Animal(TypeAnimal typeAnimal, Format format)
        {
            _type = typeAnimal;
            _format = format;
            SetPoints();
        }

        //Setting the points based on the format of the animal
        private void SetPoints()
        {
            switch (_format)
            {
                case Format.Small:
                    _points = 1;
                    break;
                case Format.Medium:
                    _points = 3;
                    break;
                case Format.Large:
                    _points = 5;
                    break;
            }
        }

        public TypeAnimal GetTypeAnimal()
        {
            return _type;
        }

        public Format GetFormat()
        {
            return _format;
        }

        public int GetPoints()
        {
            return _points;
        }
        public override string ToString()
        {
            return $"{_type}, {_format}";
        }
    }
}
