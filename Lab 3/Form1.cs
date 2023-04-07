//Grading ID: R5560
//Lab 3
//Due Date: February 14th, 2021
//Course Section: CIS 199-01
/*Description: This program takes a user inputed radius value of a sphere and outputs the Diameter, Surface Area, and Volume.
This is all done in a GUI */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class valueCalculator : Form
    {
        public valueCalculator()
        {
            InitializeComponent();
        }
        //This click event calculates the diameter, surface area, and volume of a sphere given a user inputted radius. 
        private void buttonCalcValues_Click(object sender, EventArgs e)
        {
            double radius, //user inputted radius, no specific unit was given
               diameter, //diameter of sphere. Found by multiplying radius by 2.
               surfaceArea, //surface area of sphere. Found by using 4*Pi*radius to the second power
               volume; //volume of the sphere. Found by using 4*Pi*radius to the third power / 3

            radius = double.Parse(RadiusTxt.Text); //converts string input into RadiusTxt into a double for later calculations

            //calculations for the doubles
            diameter = 2 * radius;
            surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
            volume = 4 * Math.PI * Math.Pow(radius, 3) / 3;

            //converts doubles into text format with 2 decimal points and outputs them into the text property of their respective output labels.
            //String interpolation with 2 decimal point specifier. 
            labelDiameterOutput.Text = $"{diameter:F2}";
            labelSurfaceAreaOutput.Text = $"{surfaceArea:F2}";
            labelVolumeOutput.Text = $"{volume:F2}";


        }
    }
}
