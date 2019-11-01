//-----------------------------------------------------------------------
// <copyright file="Dice.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace farkle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class representing the Dice.
    /// </summary>
    class Dice
    {
        // Holds the value that the Die has
        public int pips = 0;

        // Bool to see if the die has been saved or not
        // public bool isLocked = false;

        public bool locked1 = false;

        public bool locked2 = false;

        public bool locked3 = false;

        public bool locked4 = false;

        public bool locked5 = false;

        // Bool to see if the die has been scored or not.
        public bool removed = false;

        // Gets the dies position in the saved dice area
        public int position = 0;

        // Method to reset locked dice fields.
        public void ResetLockedDice()
        {
            locked1 = false;
            locked2 = false;
            locked3 = false;
            locked4 = false;
            locked5 = false;
        }

    }
}
