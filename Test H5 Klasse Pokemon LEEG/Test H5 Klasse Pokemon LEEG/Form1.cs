using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Private Variable
        private string _speler1;
        private string _speler2;
        private Random will = new Random();

        // Instantie aanmaken
        Speler spel1 = new Speler("Mario", 100,Speler.PositieX.will.Next(1, 501), Speler.PositieY.will.
            Next(1, 501), true);

        Speler spel2 = new Speler("Mario", 100, Speler.PositieX.will.Next(1, 501), Speler.PositieY.will.
            Next(1, 501), true);

        private void buttonGenees1_Click(object sender, EventArgs e)
        {
            Speler.Genees(will.Next(1, 5));
            labelGezondheid1.Text = "Gezondheid:" + Speler.spel1.Gezondheid;
        }

        private void buttonGenees2_Click(object sender, EventArgs e)
        {
            Speler.Genees(will.Next(1, 5));
            labelGezondheid2.Text = "Gezondheid:" + Speler.spel2.Gezondheid;
        }

        private void buttonValAan1_Click(object sender, EventArgs e)
        {
            Speler.OntvangSchade(will.Next(1, 10));

        }

        private void buttonValAan2_Click(object sender, EventArgs e)
        {
            Speler.OntvangSchade(will.Next(1, 10));
        }

        private void buttonToonPos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ", "Speler 1:" (" + positiex1 + ", " + positiey1 +") " +
                "\t" + "Speler 2: (" + positiex2 + ", " + positiey2 + ")", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


    }
}
