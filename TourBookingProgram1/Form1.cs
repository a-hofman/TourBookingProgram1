using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourBookingProgram1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //string tourType = comboBox1.SelectedItem.ToString();
            //decimal tourNumberOfPeople = numericUpDown1.Value;
            //decimal tourCostPerPerson = TourCostPerPerson();
        }

        private string TourType()
        {
            string tourType = comboBox1.SelectedItem.ToString();
            return tourType;
        }

        private decimal TourNumberOfPeople()
        {
            decimal tourNumberOfPeople = numericUpDown1.Value;
            return tourNumberOfPeople;
        }

        private decimal TourCostPerPerson()
        {
            string tourType = comboBox1.SelectedItem.ToString();

            if (tourType == "Safari")
            {
                return 400;
            }
            if (tourType == "Mountain")
            {
                return 100;
            }
            else //Tropical
            {
                return 300;
            }
        }

        private string TourTotalCostString()
        {
            decimal tourTotalCost;
            tourTotalCost = TourNumberOfPeople() * TourCostPerPerson();
            string tourTotalCostString = tourTotalCost.ToString();
            return tourTotalCostString;
        }

        private string TourDescriptionLine()
        {
            string Tour = "A special " + TourType() + " tour for " + TourNumberOfPeople() + " will cost you " + TourTotalCostString() + ".\nTo add this to your booking click Add Booking.";

            return Tour;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedItem == null) || (numericUpDown1.Value < 1))
            {
                MessageBox.Show("Please complete all fields.");
            }
            else
            {
                label1.Text = TourDescriptionLine();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(TourDescriptionLine());
        }
    }
}
