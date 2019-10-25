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
        /// <summary>
        /// The number of dice being kept.
        /// </summary>
        private int diceKept;

        /// <summary>
        /// The number of die one.
        /// </summary>
        private int die1;

        /// <summary>
        /// The number of die two.
        /// </summary>
        private int die2;

        /// <summary>
        /// The number of die three.
        /// </summary>
        private int die3;

        /// <summary>
        /// The number of die four.
        /// </summary>
        private int die4;

        /// <summary>
        /// The number of die five.
        /// </summary>
        private int die5;

        /// <summary>
        /// The number of die six.
        /// </summary>
        private int die6;

        /// <summary>
        /// If die 1 is currently being kept.
        /// </summary>
        private bool die1Kept;

        /// <summary>
        /// If die 2 is currently being kept.
        /// </summary>
        private bool die2Kept;

        /// <summary>
        /// If die 3 is currently being kept.
        /// </summary>
        private bool die3Kept;

        /// <summary>
        /// If die 4 is currently being kept.
        /// </summary>
        private bool die4Kept;

        /// <summary>
        /// If die 5 is currently being kept.
        /// </summary>
        private bool die5Kept;

        /// <summary>
        /// If die 6 is currently being kept.
        /// </summary>
        private bool die6Kept;

        /// <summary>
        /// If die 1 is currently being kept.
        /// </summary>
        private bool die1Visible;

        /// <summary>
        /// If die 2 is currently being kept.
        /// </summary>
        private bool die2Visible;

        /// <summary>
        /// If die 3 is currently being kept.
        /// </summary>
        private bool die3Visible;

        /// <summary>
        /// If die 4 is currently being kept.
        /// </summary>
        private bool die4Visible;

        /// <summary>
        /// If die 5 is currently being kept.
        /// </summary>
        private bool die5Visible;

        /// <summary>
        /// If die 6 is currently being kept.
        /// </summary>
        private bool die6Visible;

        /// <summary>
        /// The numbered value of the die between 1 and 6.
        /// </summary>
        private int dieValue;

        /// <summary>
        /// Get or sets dice value.
        /// </summary>
        public int DieValue
        {
            get { return this.dieValue; }
            set { this.dieValue = value; }
        }

        // public List<int> diceList;
        // public List<int> DiceList = new List<int>();

        // Array to hold the dice rolled in.
        public int[] DiceList = new int[6];

        /// <summary>
        /// Get or sets dice kept.
        /// </summary>
        public int DiceKept
        {
            get { return this.diceKept; }
            set { this.diceKept = value; }
        }

        /// <summary>
        /// Get or sets die one.
        /// </summary>
        public int Die1
        {
            get { return this.die1; }
            set { this.die1 = value; }
        }

        /// <summary>
        /// Get or sets die two.
        /// </summary>
        public int Die2
        {
            get { return this.die2; }
            set { this.die2 = value; }
        }

        /// <summary>
        /// Get or sets die three.
        /// </summary>
        public int Die3
        {
            get { return this.die3; }
            set { this.die3 = value; }
        }

        /// <summary>
        /// Get or sets die four.
        /// </summary>
        public int Die4
        {
            get { return this.die4; }
            set { this.die4 = value; }
        }

        /// <summary>
        /// Get or sets die five.
        /// </summary>
        public int Die5
        {
            get { return this.die5; }
            set { this.die5 = value; }
        }

        /// <summary>
        /// Get or sets die six.
        /// </summary>
        public int Die6
        {
            get { return this.die6; }
            set { this.die6 = value; }
        }

        /// <summary>
        /// Gets or sets die1Kept.
        /// </summary>
        public bool Die1Kept
        {
            get => die1Kept;
            set => die1Kept = value;
        }

        /// <summary>
        /// Gets or sets die2Kept.
        /// </summary>
        public bool Die2Kept
        {
            get => die2Kept;
            set => die2Kept = value;
        }

        /// <summary>
        /// Gets or sets die3Kept.
        /// </summary>
        public bool Die3Kept
        {
            get => die3Kept;
            set => die3Kept = value;
        }

        /// <summary>
        /// Gets or sets die4Kept.
        /// </summary>
        public bool Die4Kept
        {
            get => die4Kept;
            set => die4Kept = value;
        }

        /// <summary>
        /// Gets or sets die5Kept.
        /// </summary>
        public bool Die5Kept
        {
            get => die5Kept;
            set => die5Kept = value;
        }

        /// <summary>
        /// Gets or sets die6Kept.
        /// </summary>
        public bool Die6Kept
        {
            get => die6Kept;
            set => die6Kept = value;
        }

        /// <summary>
        /// Gets or sets die1Kept.
        /// </summary>
        public bool Die1Visible
        {
            get => die1Visible;
            set => die1Visible = value;
        }

        /// <summary>
        /// Gets or sets die2Kept.
        /// </summary>
        public bool Die2Visible
        {
            get => die2Visible;
            set => die2Visible = value;
        }

        /// <summary>
        /// Gets or sets die3Kept.
        /// </summary>
        public bool Die3Visible
        {
            get => die3Visible;
            set => die3Visible = value;
        }

        /// <summary>
        /// Gets or sets die4Kept.
        /// </summary>
        public bool Die4Visible
        {
            get => die4Visible;
            set => die4Visible = value;
        }

        /// <summary>
        /// Gets or sets die5Kept.
        /// </summary>
        public bool Die5Visible
        {
            get => die5Visible;
            set => die5Visible = value;
        }

        /// <summary>
        /// Gets or sets die6Kept.
        /// </summary>
        public bool Die6Visible
        {
            get => die6Visible;
            set => die6Visible = value;
        }

        /// <summary>
        /// Method to roll the dice.
        /// </summary>
        public void RollDice(int diceRolled)
        {
            // Pickeclare roll variables and have them equal to a random number between 1 and 6.D
            // .System.Threading.Thread.Sleep() added to prevent the rolls from all being the same number.
            int roll1 = Roll();
            System.Threading.Thread.Sleep(50);
            int roll2 = Roll();
            System.Threading.Thread.Sleep(50);
            int roll3 = Roll();
            System.Threading.Thread.Sleep(50);
            int roll4 = Roll();
            System.Threading.Thread.Sleep(50);
            int roll5 = Roll();
            System.Threading.Thread.Sleep(50);
            int roll6 = Roll();
            System.Threading.Thread.Sleep(50);


            // Return a list of rolled dice (or a die).
            switch (diceRolled)
            {
                // Roll all 6 dice
                case 6:

                    // Set six instances of DiceList[] equal to random roll between 1 and 6.
                    this.DiceList[0] = roll1;
                    this.DiceList[1] = roll2;
                    this.DiceList[2] = roll3;
                    this.DiceList[3] = roll4;
                    this.DiceList[4] = roll5;
                    this.DiceList[5] = roll6;

                    break;

                // Roll 5 dice
                case 5:
                    // Set five instances of DiceList[] equal to random roll between 1 and 6.
                    if (Die1Visible)
                    {
                        // Roll dice 2 through 6.
                        this.DiceList[1] = roll2;
                        this.DiceList[2] = roll3;
                        this.DiceList[3] = roll4;
                        this.DiceList[4] = roll5;
                        this.DiceList[5] = roll6;
                    }
                    else if (Die2Visible)
                    {
                        // Roll dice 1, 3 through 6.
                        this.DiceList[0] = roll1;
                        this.DiceList[2] = roll3;
                        this.DiceList[3] = roll4;
                        this.DiceList[4] = roll5;
                        this.DiceList[5] = roll6;
                    }                    
                    else if (Die3Visible)
                    {
                        // Roll dice 1, 2, 4 through 6.
                        this.DiceList[0] = roll1;
                        this.DiceList[1] = roll2;
                        this.DiceList[3] = roll4;
                        this.DiceList[4] = roll5;
                        this.DiceList[5] = roll6;                                       
                    }
                    else if (Die4Visible)
                    {
                        // Roll dice 1, 2, 3 through 6.
                        this.DiceList[0] = roll1;
                        this.DiceList[1] = roll2;
                        this.DiceList[2] = roll3;
                        this.DiceList[4] = roll4;
                        this.DiceList[5] = roll6;
                    }
                    else if (Die5Visible)
                    {
                        // Roll dice 1 through 4 and 6.
                        this.DiceList[0] = roll1;
                        this.DiceList[1] = roll2;
                        this.DiceList[2] = roll3;
                        this.DiceList[3] = roll4;
                        this.DiceList[5] = roll6;
                    } 
                    else if (Die6Visible)
                    {
                        // Roll first 5 dice.
                        this.DiceList[0] = roll1;
                        this.DiceList[1] = roll2;
                        this.DiceList[2] = roll3;
                        this.DiceList[3] = roll4;
                        this.DiceList[4] = roll5;
                    }
                                
                   // Brake out of the switch.
                   break;

                // Roll 4 dice
                case 4:
                    // Set four instances of DiceList[] equal to random roll between 1 and 6.
                    if (Die1Visible)
                    {
                        // If imgSavedDie1 is visible then do not roll dice 1.
                        if (Die2Visible)
                        {
                            this.DiceList[2] = roll3;
                            this.DiceList[3] = roll4;
                            this.DiceList[4] = roll5;
                            this.DiceList[5] = roll6;
                        }
                        else if (Die3Visible)
                        {
                            this.DiceList[1] = roll2;
                            this.DiceList[3] = roll4;
                            this.DiceList[4] = roll5;
                            this.DiceList[5] = roll6;
                        }
                        else if (Die4Visible)
                        {
                            this.DiceList[1] = roll2;
                            this.DiceList[2] = roll3;
                            this.DiceList[4] = roll5;
                            this.DiceList[5] = roll6;
                        }
                        else if (Die5Visible)
                        {
                            this.DiceList[1] = roll2;
                            this.DiceList[2] = roll3;
                            this.DiceList[3] = roll4;
                            this.DiceList[5] = roll6;
                        }
                        else
                        {
                            // imgSavedDie6 is visible.
                            this.DiceList[1] = roll2;
                            this.DiceList[2] = roll3;
                            this.DiceList[3] = roll4;
                            this.DiceList[4] = roll5;
                        }
                    }
                    else if (Die2Visible)
                    {
                        if (Die3Visible)
                        {
                            this.DiceList[0] = roll1;
                            this.DiceList[3] = roll2;
                            this.DiceList[4] = roll3;
                            this.DiceList[5] = roll4;
                        }
                        else if (Die4Visible)
                        {
                            this.DiceList[0] = roll1;
                            this.DiceList[2] = roll2;
                            this.DiceList[4] = roll3;
                            this.DiceList[5] = roll4;
                        }
                        else if (Die5Visible)
                        {
                            this.DiceList[0] = roll1;
                            this.DiceList[2] = roll2;
                            this.DiceList[3] = roll3;
                            this.DiceList[5] = roll4;
                        }
                        else
                        {
                            // imgSavedDie6 is visible.
                            this.DiceList[0] = roll1;
                            this.DiceList[2] = roll2;
                            this.DiceList[3] = roll3;
                            this.DiceList[4] = roll4;
                        }
                    }
                    else if (Die3Visible)
                    {
                        if (Die4Visible)
                        {
                            this.DiceList[0] = roll1;
                            this.DiceList[1] = roll2;
                            this.DiceList[4] = roll3;
                            this.DiceList[5] = roll4;
                        }
                        else if (Die5Visible)
                        {
                            this.DiceList[0] = roll1;
                            this.DiceList[1] = roll2;
                            this.DiceList[3] = roll3;
                            this.DiceList[5] = roll4;
                        }
                        else
                        {
                            // imgSavedDie6 is visible.
                            this.DiceList[0] = roll1;
                            this.DiceList[1] = roll2;
                            this.DiceList[3] = roll3;
                            this.DiceList[4] = roll4;
                        }
                    }
                    else if (Die4Visible)
                    {
                        if (Die5Visible)
                        {
                            this.DiceList[0] = roll1;
                            this.DiceList[1] = roll2;
                            this.DiceList[2] = roll3;
                            this.DiceList[5] = roll4;
                        }
                        else if (Die6Visible)
                        {
                            // imgSavedDie6 is visible.
                            this.DiceList[0] = roll1;
                            this.DiceList[1] = roll2;
                            this.DiceList[2] = roll3;
                            this.DiceList[4] = roll4;
                        }
                    }
                    else
                    {
                        // imgSavedDie5 and imgSavedDie6 are both visible.
                        this.DiceList[0] = roll1;
                        this.DiceList[1] = roll2;
                        this.DiceList[2] = roll3;
                        this.DiceList[3] = roll4;
                    }
                    

                    break;

                // Roll 3 dice
                case 3:
                    // Set three instances of DiceList[] equal to random roll between 1 and 6.
                    if (Die1Visible)
                    {
                        // if imgSavedDie1 is visible then do not roll dice 1.
                        if (Die2Visible)
                        {
                            if (Die3Visible)
                            {
                                this.DiceList[3] = roll4;
                                this.DiceList[4] = roll5;
                                this.DiceList[5] = roll6;
                            }
                            else if (Die4Visible)
                            {
                                this.DiceList[2] = roll3;
                                this.DiceList[4] = roll5;
                                this.DiceList[5] = roll6;
                            }
                            else if (Die5Visible)
                            {                               
                                this.DiceList[2] = roll3;
                                this.DiceList[3] = roll4;
                                this.DiceList[5] = roll6;
                            }
                            else
                            {
                                // Die6Visible is true
                                this.DiceList[2] = roll3;
                                this.DiceList[3] = roll4;
                                this.DiceList[4] = roll5;
                            }
                        }
                        else if (Die3Visible)
                        {
                            if (Die4Visible)
                            {
                                this.DiceList[1] = roll2;
                                this.DiceList[4] = roll3;
                                this.DiceList[5] = roll4;
                            }
                            else if (Die5Visible)
                            {
                                this.DiceList[1] = roll2;
                                this.DiceList[3] = roll3;
                                this.DiceList[5] = roll4;
                            }
                            else
                            {
                                // Die6Visible is true
                                this.DiceList[1] = roll2;
                                this.DiceList[3] = roll3;
                                this.DiceList[4] = roll4;
                            }
                        }
                        else if (Die4Visible)
                        {
                           if (Die5Visible)
                           {
                                this.DiceList[1] = roll2;
                                this.DiceList[2] = roll3;
                                this.DiceList[5] = roll4;
                           }
                           else
                           {
                               // Die6Visible is true
                               this.DiceList[1] = roll2;
                               this.DiceList[2] = roll3;
                               this.DiceList[4] = roll4;
                           }
                        }
                        else 
                        {
                            // Die5Visible and Die6Visible are true.
                            this.DiceList[1] = roll2;
                            this.DiceList[2] = roll3;
                            this.DiceList[3] = roll4;
                        }      
                    }
                    else if (Die2Visible)
                    {
                        if (Die3Visible)
                        {
                            if (Die4Visible)
                            {
                                this.DiceList[0] = roll1;
                                this.DiceList[4] = roll5;
                                this.DiceList[5] = roll6;
                            }
                            else if (Die5Visible)
                            {
                                this.DiceList[0] = roll1;
                                this.DiceList[3] = roll4;
                                this.DiceList[5] = roll6;
                            }
                            else
                            {
                                // Die6Visible is true
                                this.DiceList[0] = roll1;
                                this.DiceList[3] = roll4;
                                this.DiceList[4] = roll5;
                            }
                        }
                        else if (Die4Visible)
                        {
                            if (Die5Visible)
                            {
                                this.DiceList[0] = roll1;
                                this.DiceList[2] = roll3;
                                this.DiceList[5] = roll6;
                            }
                            else
                            {
                                // Die6Visible is true
                                this.DiceList[0] = roll1;
                                this.DiceList[2] = roll3;
                                this.DiceList[4] = roll5;
                            }
                        }
                        else 
                        {
                            // Die5Visible and Die6Visible is true.
                            this.DiceList[0] = roll1;
                            this.DiceList[2] = roll3;
                            this.DiceList[3] = roll4;
                        }
                    }
                    else if (Die3Visible)
                    {
                        if (Die4Visible)
                        {
                            this.DiceList[0] = roll1;
                            this.DiceList[1] = roll2;
                            this.DiceList[5] = roll6;
                        }
                        else if (Die5Visible)
                        {
                            this.DiceList[0] = roll1;
                            this.DiceList[1] = roll4;
                            this.DiceList[4] = roll6;
                        }
                        else
                        {
                            // Die6Visible is true
                            this.DiceList[0] = roll1;
                            this.DiceList[1] = roll2;
                            this.DiceList[4] = roll5;
                        }
                    }
                    else 
                    {
                        // Die4Visible, Die5Visible, and Die6Visible are true.
                        this.DiceList[0] = roll1;
                        this.DiceList[1] = roll2;
                        this.DiceList[2] = roll3;
                    }
                    
                    break;

                // Roll 2 dice.
                case 2:
                    // If imgSavedDie1 is visible then do not roll dice 1.
                    if (Die1Visible)
                    {
                        // If the 1 and 2 dice are saved do not roll them.
                        if (Die2Visible)
                        {
                            // If the 1 2 and 3 dice are visible do not roll them.
                            if (Die3Visible)
                            {
                                // If the 1 2 3 and 4 die are visible do not roll them.
                                if (Die4Visible)
                                {
                                    // Roll 5 and 6.
                                    this.DiceList[4] = roll5;
                                    this.DiceList[5] = roll6;
                                }
                                else if (Die5Visible)
                                {
                                    // Roll 4 and 6.
                                    this.DiceList[3] = roll4;
                                    this.DiceList[5] = roll6;
                                }
                                else if (Die6Visible)
                                {
                                    // Roll 4 and 5.
                                    this.DiceList[3] = roll4;
                                    this.DiceList[4] = roll5;
                                }
                            }
                            // If 1 2 and 4 are visible do not roll them.
                            else if (Die4Visible)
                            {
                                if (Die5Visible)
                                {
                                    // Roll 3, 6.
                                    this.DiceList[2] = roll3;
                                    this.DiceList[5] = roll6;
                                }
                                else if (Die6Visible)
                                {
                                    // Roll 3, 5.
                                    this.DiceList[2] = roll3;
                                    this.DiceList[4] = roll5;
                                }
                            }
                            // If 1 2 and 5 are visible do not roll them.
                            else if (Die5Visible)
                            {
                                if (Die6Visible)
                                {
                                    // Roll 3 4.
                                    this.DiceList[2] = roll4;
                                    this.DiceList[3] = roll5;
                                }
                            }
                            // 1 2 6 are visible.
                            else
                            {
                                // Die6Visible is true and all rolls are covered above :D
                            }
                        }
                        // If the 1 and 3 dice are saved do not roll them.
                        else if (Die3Visible)
                        {
                            if (Die4Visible)
                            {
                                if (Die5Visible)
                                {
                                    // Roll 2 6.
                                    this.DiceList[1] = roll2;
                                    this.DiceList[5] = roll5;
                                }
                                else if (Die6Visible)
                                {
                                    // Roll 2 5.
                                    this.DiceList[1] = roll2;
                                    this.DiceList[4] = roll5;
                                }
                            }
                            else if (Die5Visible)
                            {
                                if (Die6Visible)
                                {
                                    // roll 2 and 4
                                    this.DiceList[1] = roll2;
                                    this.DiceList[3] = roll4;
                                }
                            }
                        }
                        // If the 1 and 4 dice are saved do not roll them.
                        else if (Die4Visible)
                        {
                            if (Die5Visible)
                            {
                                if (Die6Visible)
                                {
                                    // Roll 2 3.
                                    this.DiceList[1] = roll2;
                                    this.DiceList[2] = roll3;
                                }
                            }
                        }
                        else if (Die5Visible)
                        {
                            //i
                        }
                        else if (Die6Visible)
                        {

                        }
                    }
                    // If die 2 is visible dont roll it.
                    else if (Die2Visible)
                    {
                        // If die 2/3 are visible.
                        if (Die3Visible)
                        {
                            // If die 2/3/4 are visible.
                            if (Die4Visible)
                            {
                                // If die 2/3/4/5.
                                if (Die5Visible)
                                {
                                    // Roll 1 6.
                                    this.DiceList[0] = roll1;
                                    this.DiceList[5] = roll6;
                                }
                                // If die 2/3/4/6.
                                else if (Die6Visible)
                                {
                                    // Roll 1 5.
                                    this.DiceList[0] = roll4;
                                    this.DiceList[4] = roll5;
                                }
                            }
                        }
                    }
                    // If die 3 is visible dont roll it.
                    else if (Die3Visible)
                    {
                        if (Die4Visible)
                        {
                            // If die 2/3/4/5
                            if (Die5Visible)
                            {
                                if (Die6Visible)
                                {
                                    // Roll 1 5
                                    this.DiceList[0] = roll4;
                                    this.DiceList[4] = roll5;
                                }
                            }

                        }
                    }
                    else if (Die4Visible)
                    {
                        if (Die5Visible)
                        {
                            if (Die6Visible)
                            {
                                // Roll 2 and 3
                                this.DiceList[1] = roll2;
                                this.DiceList[2] = roll3;
                            }
                        }
                    }
                    else if (Die5Visible)
                    {

                    }
                    else if (Die6Visible)
                    {

                    }


                    this.DiceList[0] = roll1;
                    this.DiceList[1] = roll2;

                    break;

                // Roll 1 die.
                default:

                    if (Die1Visible == false)
                    {
                        this.DiceList[0] = roll1;
                    }
                    else if (Die2Visible == false)
                    {
                        this.DiceList[1] = roll2;
                    }
                    else if (Die3Visible == false)
                    {
                        this.DiceList[2] = roll3;
                    }
                    else if (Die4Visible == false)
                    {
                        this.DiceList[3] = roll4;
                    }
                    else if (Die5Visible == false)
                    {
                        this.DiceList[4] = roll5;
                    }
                    else
                    {
                        // Die6Visible is true.
                        this.DiceList[5] = roll6;
                    }
                     

                    // Warn the player of their greed? You better hope to get hot dice!
                    break;
            }
        }

        private int Roll()
        {
            // Create instance of random number between 1 and 6.
            Random rand = new Random();

            // Return the random number.
            return rand.Next(1, 7);
        }
    }
}
