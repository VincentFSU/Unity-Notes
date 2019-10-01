using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Andrea
{
    public class Inventory
    {
        #region Member Declaration
        public static Inventory _singleton;
        public static Inventory singleton
        {
            get
            {
                if (_singleton == null)
                    _singleton = new Inventory(); //lazy instantiation

                return _singleton;
            }
            private set
            {
                _singleton = value;
            }
        }

        public static void Reset()
        {
            singleton = new Inventory();
        }


        public bool hasSword = false;
        public bool hasKeyCrystal = false;

        public float totalXP = 500;
        public float nextLevelXP = 750;
        #endregion

        private Inventory() { } //private constructor

    }
}
