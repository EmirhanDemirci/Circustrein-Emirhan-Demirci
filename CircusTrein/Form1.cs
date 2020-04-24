using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CircusTrein.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CircusTrein
{
    public partial class Form1 : Form
    {
        private Train _train;
        List<Animal> Animals = new List<Animal>();

        public Form1()
        {
            _train = new Train();
            InitializeComponent();
            cbxTypeAnimal.DataSource = Enum.GetValues(typeof(TypeAnimal));
            cbxFormatAnimal.DataSource = Enum.GetValues(typeof(Format));
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            TypeAnimal typeAnimal;
            Format format;
            Enum.TryParse<TypeAnimal>(cbxTypeAnimal.SelectedValue.ToString(), out typeAnimal);
            Enum.TryParse<Format>(cbxFormatAnimal.SelectedValue.ToString(), out format);

            var animal = new Animal(typeAnimal, format);
            Animals.Add(animal);
            listBox1.Items.Add($"Type: {animal.GetTypeAnimal()}");
            listBox1.Items.Add($"Format: {animal.GetFormat()}");
            listBox1.Items.Add($"Points: {animal.GetPoints()}");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            foreach (var animal in Animals)
            {
                if (!_train.GetWagon().Any())
                {
                    CreateWagon(animal);
                    continue;
                }

                var canEnter = false;
                foreach (var wagon in _train.GetWagon())
                {
                    canEnter = wagon.CheckRules(animal);
                    if (canEnter)
                    {
                        wagon.AddAnimal(animal);
                        listBox2.Items.Add(wagon.ToString());
                        break;
                    }
                }

                if (!canEnter)
                {
                    CreateWagon(animal);
                }
            }
        }

        private void CreateWagon(Animal animal)
        {
            var wagon = new Wagon();
            wagon.AddAnimal(animal);
            _train.AddWagon(wagon);
        }
    }
}
