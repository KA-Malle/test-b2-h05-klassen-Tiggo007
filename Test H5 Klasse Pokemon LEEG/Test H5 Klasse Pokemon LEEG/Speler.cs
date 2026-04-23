using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    internal class Speler
    {
        // Instancie variable
        private string _naam;
        private int _gezondheid;
        private int _positieX;
        private int _positieY;
        private bool _isLevend;

        //Properties

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public int Gezondheid
        {
            get { return _gezondheid; }
            set { _gezondheid = value; }
        }

        public int PositieX
        {
            get { return _positieX; }
            set { _positieX = value; }
        }

        public int PositieY
        {
            get { return _positieY; }
            set { _positieY = value; }
        }

        public bool IsLevend
        {
            get { return _isLevend; }
            set { _isLevend = value; }
        }

       //Default constructor
        public Speler()
        {
            Naam = " ";
            Gezondheid = 100;
            PositieX = 0;
            PositieY = 0;
            IsLevend = true;
        }

        // Tweede constructor, maar dan me	argumenten.
        public Speler (string naam, int gezond, int x, int y, bool levend)
        {
            Naam = naam;
            Gezondheid = gezond;
            PositieX = x;
            PositieY = y;
            IsLevend = levend;
        }



        public int Verplaats(int x, int y)
        {
            PositieX += x;
            PositieY += y;
            return PositieX + PositieY;
        }

        public int OntvangSchade(int schade)
        {
            Gezondheid -= schade;
            return Gezondheid;
        }

        public int Genees(int heal)
        {
            Gezondheid += heal;
            return Gezondheid;
        }
    }
}
