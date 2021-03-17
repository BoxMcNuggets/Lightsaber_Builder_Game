using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightsaber_Builder_Game.Models
{
    public class Player : Character
    {
        #region ENUMS

        public enum ForceSide { LightSide, DarkSide }

        #endregion

        #region FIELDS

        private int _lives;
        private int _health;
        private ForceSide _forceSide;
        private List<Location> _locationsVisited;

        #endregion

        #region PROPERTIES

        public int Lives
        {
            get { return _lives; }
            set 
            {
                _lives = value;
                OnPropertyChanged(nameof(Lives));
            }
        }

        public ForceSide JobTitle
        {
            get { return _forceSide; }
            set 
            {
                _forceSide = value;
                OnPropertyChanged(nameof(JobTitle));
            }
        }

        public int Health
        {
            get { return _health; }
            set 
            {
                _health = value;
                OnPropertyChanged(nameof(Health));
            }
        }

        #endregion

        #region CONSTRUCTORS
        public Player()
        {
            _locationsVisited = new List<Location>();
        }

        #endregion

        #region METHODS

        public override string DefaultGreeting()
        {
            string article = "a";

            List<string> vowels = new List<string>() { "A", "E", "I", "O", "U" };

            if (vowels.Contains(_forceSide.ToString().Substring(0, 1)));
            {
                article = "A";
            }

            return $"Hello, my name is {_name} and I am {article} {_forceSide}.";
        }

        #endregion

        #region EVENTS



        #endregion

    }
}
