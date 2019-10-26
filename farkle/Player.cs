//-----------------------------------------------------------------------
// <copyright file="Player.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Windows;

namespace farkle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Player
    {
        // Players total score.
        private int score;

        // Players score for the current round
        private int pendingScore;

        /// <summary>
        /// Players temporary current score for this round. Can be added to w/ hot dice or lost if farkled.
        /// </summary>
        private int tempScore;

        /// <summary>
        /// The current score for the player.
        /// </summary>
        private int currentScore;

        /// <summary>
        /// The numbered value of the die between 1 and 6.
        /// </summary>
        private int[] dieKept = new int[6];

        /// <summary>
        /// Bool value to hold true if all the dice kept are scorable.
        /// </summary>
        private bool validDice = false;

        /// <summary>
        /// Bool value to hold true if all 6 dice are kept, scorable, and ready for re-roll.
        /// </summary>
        private bool hotDice;

        /// <summary>
        /// Intger value to increment every time the player gets hot dice. Resets on new turn.
        /// </summary>
        private int round;

        /// <summary>
        /// Intger value to increment every time the player gets hot dice. Resets on new turn.
        /// </summary>
        private int oldTemp;

        /// <summary>
        /// Gets or sets validDice.
        /// </summary>
        public int OldTemp
        {
            get => oldTemp;
            set => oldTemp = value;
        }

        /// <summary>
        /// Get or sets dice value.
        /// </summary>
        public int[] DieKept
        {
            get { return this.dieKept; }
            set { this.dieKept = value; }
        }

        // Instance of dice class
        public Dice currentDie;

        /// <summary>
        /// Gets or sets Score.
        /// </summary>
        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        /// <summary>
        /// Gets or sets Pending Score. for specific roll
        /// </summary>
        public int PendingScore
        {
            get { return this.pendingScore; }
            set { this.pendingScore = value; }
        }

        /// <summary>
        /// Gets or sets the current score.
        /// </summary>
        public int CurrentScore
        {
            get => currentScore;
            set => currentScore = value;
        }

        /// <summary>
        /// Gets or sets tempScore. 
        /// </summary>
        public int TempScore
        {
            get => tempScore;
            set => tempScore = value;
        }

        /// <summary>
        /// Gets or sets validDice.
        /// </summary>
        public bool ValidDice
        {
            get => validDice;
            set => validDice = value;
        }

        /// <summary>
        /// Gets or sets hotDice.
        /// </summary>
        public bool HotDice
        {
            get => hotDice;
            set => hotDice = value;
        }

        /// <summary>
        /// Gets or sets round.
        /// </summary>
        public int Round
        {
            get => round;
            set => round = value;
        }

        public void ScoreDice(int[] diceArray)
        {
            // Variable for total score from the dice roll.
            int totalScore = 0;
            // Scoring 

            // Set up a list to store the diceKept in.
            // List<int> diceKept = new List<int>();

            // Set bool valid dice and bool hot dice to false.
            validDice = false;
            this.hotDice = false;

            // Set up variables to hold the scores for a single 1 or single 5 rolled.
            int die1 = 100;
            int die5 = 50;

            // Create variables to keep count of each die.
            int oneCounter = 0;
            int twoCounter = 0;
            int threeCounter = 0;
            int fourCounter = 0;
            int fiveCounter = 0;
            int sixCounter = 0;

            // Set up a bool value to hold true if all 6 dice are kept.
            //bool hotDice = false;
            // we are using a field of player to do this

            // Set up a boolean value to hold true if there is a straight.
            bool straight = false;

            // Set up bool values to hold true if counters are pairs.
            bool pairOnes = false;
            bool pairTwos = false;
            bool pairThrees = false;
            bool pairFours = false;
            bool pairFives = false;
            bool pairSixes = false;

            // Set up a bool value to hold true if there are three pairs.
            bool threePairs = false;

            // Set up bool values to hold true if counters are 3.
            bool threeOnes = false;
            bool threeTwos = false;
            bool threeThrees = false;
            bool threeFours = false;
            bool threeFives = false;
            bool threeSixes = false;

            // Set up a bool value to hold true if there are two three of a kinds.
            bool threeOfAKinds = false;

            // Set up a bool value to hold true if there are dice that can be scored.
            bool keptDiceScorable = false;

            // todo set up a way to tell if there are scoreable dice.
            // todo list of dice that arent being kept.
            List<int> rolledDice = new List<int>();


            // todo not sure what was going here.
            // If 
            if (this.HotDice == false)
            {
                this.pendingScore = 0;
            }
            else
            {

            }

            // Loop through the dieKept array.
            for (int index = 0; index < dieKept.Length; index++)
            {
                // If the value in each element of dieKept is not 0...
                if (dieKept[index] > 0)
                {
                    // Add the value to a list.
                    rolledDice.Add(dieKept[index]);
                }
            }

            // If there is only one dice kept.
            if (rolledDice.Count == 1)
            {
                // If the dice kept is a 1.
                if (rolledDice[0] == 1)
                {
                    // Add 100 to pendingScore.
                    pendingScore = die1;

                    // Increment the oneCounter.
                    oneCounter++;

                    // Set validDice to true.
                    validDice = true;
                }
                else if (rolledDice[0] == 5)
                {
                    // The dice kept is a 5. Add 50 to the pendingScore.
                    pendingScore = die5;

                    // Increment the fiveCounter.
                    fiveCounter++;

                    // Set validDice to true.
                    validDice = true;
                }
                else
                {
                    // The dice kept is not scoreable.
                    MessageBox.Show("The die you kept is not scorable.");
                }
            }
            else
            {
                // Loop through the diceKept list and increment the counters of each die rolled.
                foreach (int die in rolledDice)
                {
                    // If the current die is a 1.
                    if (die == 1)
                    {
                        // Increment the one counter.
                        oneCounter++;
                    }
                    else if (die == 2)
                    {
                        // Increment the two counter
                        twoCounter++;
                    }
                    else if (die == 3)
                    {
                        // Increment the three counter.
                        threeCounter++;
                    }
                    else if (die == 4)
                    {
                        // Increment the four counter.
                        fourCounter++;
                    }
                    else if (die == 5)
                    {
                        // Increment the five counter.
                        fiveCounter++;
                    }
                    else
                    {
                        // Increment the six counter.
                        sixCounter++;
                    }
                }

                // todo right here check if there are scorable dice by comparing the one/fiveCounters and 
                // the other counters compared to the total counter?

                // If there are ones to be scored.
                if (oneCounter > 0)
                {
                    // If there are less than 3 ones rolled.
                    if (oneCounter < 3)
                    {
                        // Add 100 for each one rolled.
                        pendingScore += oneCounter * 100;
                    }
                    else
                    {
                        // If there are 3 or more ones rolled.
                        if (oneCounter == 3)
                        {
                            // If oneCounter is 3 add 1000.
                            pendingScore += 1000;

                            // Set threeOnes to true;
                            threeOnes = true;
                        }
                        else if (oneCounter == 4)
                        {
                            // If oneCounter is 4 add 2000.
                            pendingScore += 2000;
                        }
                        else if (oneCounter == 5)
                        {
                            // If oneCounter is 5 add 4000.
                            pendingScore += 4000;
                        }
                        else
                        {
                            // If oneCounter is 6 add 8000.
                            pendingScore += 8000;
                        }
                    }
                }
                else
                {
                    // Pending score remains the same.
                }

                // If there are twos to be scored.
                if (twoCounter >= 3)
                {
                    // If there are 3 or more twos rolled.
                    if (twoCounter == 3)
                    {
                        // If twoCounter is 3 add 200.
                        pendingScore = 200;

                        // Set threeTwos to true;
                        threeTwos = true;
                    }
                    else if (twoCounter == 4)
                    {
                        // If twoCounter is 4 add 400.
                        pendingScore = 400;
                    }
                    else if (twoCounter == 5)
                    {
                        // If twoCounter is 5 add 800.
                        pendingScore = 800;
                    }
                    else
                    {
                        // If twoCounter is 6 add 1600.
                        pendingScore = 1600;
                    }
                }
                else
                {
                    // Pending score remains the same.
                }

                // If there are threes to be scored.
                if (threeCounter >= 3)
                {
                    // If there are 3 or more threes rolled.
                    if (threeCounter == 3)
                    {
                        // If threeCounter is 3 add 300.
                        pendingScore += 300;

                        // Set threeThrees to true;
                        threeThrees = true;
                    }
                    else if (threeCounter == 4)
                    {
                        // If threeCounter is 4 add 600.
                        pendingScore += 600;
                    }
                    else if (threeCounter == 5)
                    {
                        // If threeCounter is 5 add 1200.
                        pendingScore += 1200;
                    }
                    else
                    {
                        // If threeCounter is 6 add 2400.
                        pendingScore += 2400;
                    }
                }
                else
                {
                    // Pending score remains the same.
                }

                // If there are fours to be scored.
                if (fourCounter >= 3)
                {
                    // If there are 3 or more fours rolled.
                    if (fourCounter == 3)
                    {
                        // If fourCounter is 3 add 400.
                        pendingScore += 400;

                        // Set threeFours to true;
                        threeFours = true;
                    }
                    else if (fourCounter == 4)
                    {
                        // If fourCounter is 4 add 800.
                        pendingScore += 800;
                    }
                    else if (fourCounter == 5)
                    {
                        // If fourCounter is 5 add 1600.
                        pendingScore += 1600;
                    }
                    else
                    {
                        // If fourCounter is 6 add 3200.
                        pendingScore += 3200;
                    }
                }
                else
                {
                    // Pending score remains the same.
                }

                // If there are fivess to be scored.
                if (fiveCounter > 0)
                {
                    // If there are less than 3 fives rolled.
                    if (fiveCounter < 3)
                    {
                        // Add 50 for each 5 rolled.
                        pendingScore += fiveCounter * 50;
                    }
                    else
                    {
                        // If there are 3 or more fives rolled.
                        if (fiveCounter == 3)
                        {
                            // If fiveCounter is 3 add 500.
                            pendingScore += 500;

                            // Set threeFives to true;
                            threeFives = true;
                        }
                        else if (fiveCounter == 4)
                        {
                            // If fiveCounter is 4 add 1000.
                            pendingScore += 1000;
                        }
                        else if (fiveCounter == 5)
                        {
                            // If fiveCounter is 5 add 2000.
                            pendingScore += 2000;
                        }
                        else
                        {
                            // If fiveCounter is 6 add 4000.
                            pendingScore += 4000;
                        }
                    }
                }
                else
                {
                    // Pending score remains the same.
                }

                // If there are sixes to be scored.
                if (sixCounter >= 3)
                {
                    // If there are 3 or more sixes rolled.
                    if (sixCounter == 3)
                    {
                        // If sixCounter is 3 add 600.
                        pendingScore += 600;

                        // Set threeSixes to true;
                        threeSixes = true;
                    }
                    else if (sixCounter == 4)
                    {
                        // If sixCounter is 4 add 1200.
                        pendingScore += 1200;
                    }
                    else if (sixCounter == 5)
                    {
                        // If sixCounter is 5 add 2400.
                        pendingScore += 2400;
                    }
                    else
                    {
                        // If sixCounter is 6 add 4800.
                        pendingScore += 4800;
                    }
                }
                else
                {
                    // Pending score remains the same.
                }

                // Check to see if the player rolled a straight or three pairs.
                if (rolledDice.Count == 6)
                {
                    // Set hotDice to true.
                    this.HotDice = true;

                    // Check for pairs.
                    // If theres a pair of ones.
                    if (oneCounter == 2)
                    {
                        // Set pairOnes as true.
                        pairOnes = true;
                    }

                    // If theres a pair of twos.
                    if (twoCounter == 2)
                    {
                        // Set pairTwos as true.
                        pairTwos = true;
                    }

                    // If theres a pair of threes.
                    if (threeCounter == 2)
                    {
                        // Set pairThrees as true.
                        pairThrees = true;
                    }

                    // If theres a pair of fours.
                    if (fourCounter == 2)
                    {
                        // Set pairFours as true.
                        pairFours = true;
                    }

                    // If theres a pair of fives.
                    if (fiveCounter == 2)
                    {
                        // Set pairFives as true.
                        pairFives = true;
                    }

                    // If theres a pair of sixes.
                    if (sixCounter == 2)
                    {
                        // Set pairSixes as true.
                        pairSixes = true;
                    }

                    // Check for a straight.
                    if (oneCounter == 1 && twoCounter == 1 && threeCounter == 1 &&
                        fourCounter == 1 && fiveCounter == 1 && sixCounter == 1)
                    {
                        // Set bool straight to true.
                        straight = true;

                        // Add 3000 to the pending score for a straight.
                        pendingScore = 3000;
                    }
                    else
                    {
                        // Check for three pairs.
                        // If theres a pair of ones.
                        if (pairOnes)
                        {
                            // Check if theres another pair.
                            if (pairTwos)
                            {
                                // Check if theres a third pair.
                                if (pairThrees)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairFours)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairFives)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else if (pairThrees)
                            {
                                // Check if theres a third pair.
                                if (pairFours)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairFives)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else if (pairFours)
                            {
                                // Check if theres a third pair.
                                if (pairFives)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else if (pairFives)
                            {
                                // Check if theres a third pair.
                                if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else
                            {
                                // There are not three pairs.
                            }
                        }
                        else if (pairTwos)
                        {
                            // Check if theres another pair.
                            if (pairThrees)
                            {
                                // Check if theres a third pair.
                                if (pairFours)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairFives)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else if (pairFours)
                            {
                                // Check if theres a third pair.
                                if (pairFives)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else if (pairFives)
                            {
                                // Check if theres a third pair.
                                if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else
                            {
                                // There are not three pairs.
                            }
                        }
                        else if (pairThrees)
                        {
                            // Check if theres another pair.
                            if (pairFours)
                            {
                                // Check if theres a third pair.
                                if (pairFives)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else if (pairFives)
                            {
                                // Check if theres a third pair.
                                if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else
                            {
                                // There are not three pairs.
                            }
                        }
                        else if (pairFours)
                        {
                            // Check if theres another pair.
                            if (pairFives)
                            {
                                // Check if theres a third pair.
                                if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else
                            {
                                // There are not three pairs.
                            }
                        }
                        else
                        {
                            // There are not three pairs.
                        }

                        // If there are three pairs.
                        if (threePairs)
                        {
                            // Add 1500 to the pending score for three pairs.
                            pendingScore = 1500;
                        }
                        else
                        {
                            // Pending score stays as pending score.
                        }
                    }

                    if (!threePairs)
                    {
                        // Check for 2 3-of-a-kinds.
                        if (threeOnes)
                        {
                            if (threeTwos)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else if (threeThrees)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else if (threeFours)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else if (threeFives)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else if (threeSixes)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else
                            {
                                // Theres not 2 3-of-a-kinds.
                            }
                        }
                        else if (threeTwos)
                        {
                            if (threeThrees)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else if (threeFours)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else if (threeFives)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else if (threeSixes)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else
                            {
                                // Theres not 2 3-of-a-kinds.
                            }
                        }
                        else if (threeThrees)
                        {
                            if (threeFours)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else if (threeFives)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else if (threeSixes)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else
                            {
                                // Theres not 2 3-of-a-kinds.
                            }
                        }
                        else if (threeFours)
                        {
                            if (threeFives)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else if (threeSixes)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else
                            {
                                // Theres not 2 3-of-a-kinds.
                            }
                        }
                        else if (threeFives)
                        {
                            if (threeSixes)
                            {
                                // There is 2 3-of-a-kinds.
                                // Set threeOfAKinds to true.
                                threeOfAKinds = true;
                            }
                            else
                            {
                                // Theres not 2 3-of-a-kinds.
                            }
                        }
                        else
                        {
                            // There is not 2 3-of-a-kinds.
                        }
                    }
                    else
                    {
                        // There is not three pairs and not 2 3-of-a-kinds
                    }
                }
            }


            // Check to make sure the dice kept are scorable.
            if (twoCounter >= 3 && twoCounter + oneCounter + fiveCounter == rolledDice.Count)
            {
                // Set scorable dice to true.
                keptDiceScorable = true;
            }
            else if (threeCounter >=3 && threeCounter + oneCounter + fiveCounter == rolledDice.Count)
            {
                // Set scorable dice to true.
                keptDiceScorable = true;
            }
            else if(fourCounter >= 3 && fourCounter + oneCounter + fiveCounter == rolledDice.Count)
            {
                // Set scorable dice to true.
                keptDiceScorable = true;
            }
            else if (sixCounter >= 3 && sixCounter + oneCounter + fiveCounter == rolledDice.Count)
            {
                // Set scorable dice to true.
                keptDiceScorable = true;
            }
            else
            {
                // Some of the dice are not scorable.
                keptDiceScorable = false;
            }

            if (straight || threePairs || threeOfAKinds || keptDiceScorable || (oneCounter + fiveCounter == rolledDice.Count))
            {
                if (rolledDice.Count == 6)
                {
                    // Set hot dice to true.
                    this.HotDice = true;
                }

                // Dice are valid.
                // Set validDice to true.
                validDice = true;

                // Keep the scores sepererated, roll to roll.
                // tempScore holds the total pending score, where as the pendingScore is for each seperate roll.
                // ex. During the first roll only a 5 is kept (50pts). The second roll three 5's are kept, we don't want the
                // value of the pending score to be 2000 when it should only be 550.

                //if (tempScore > pendingScore)
                //{
                //    tempScore = tempScore - pendingScore;
                //}
                //else
                //{
                //    tempScore = pendingScore - tempScore;
                //}

                // Set the tempScore field as pending score.
                //currentScore += tempScore;
                
                /*
                if (round == 0)
                {
                    tempScore += pendingScore;
                    oldTemp = tempScore;
                    round++;
                }
                else
                {
                    // Add new score.
                    tempScore += (pendingScore - oldTemp);                    
                }
                */
                
                tempScore += pendingScore;


                
                // Reset pending score to 0.
                pendingScore = 0;
            }
            else
            {
                // Dice are not valid.
                // MessageBox.Show("Some of the dice you kept are not scorable.");
                validDice = false;
            }

            // Clear rolledDice.
            rolledDice.Clear();

            /*
            else if (diceKept.Count == 2)
            {

            }
            else if (diceKept.Count == 3)
            {
                // Three of the dice have been kept.
            }
            else if (diceKept.Count == 4)
            {
                // Four of the dice have been kept.
            }
            else if (diceKept.Count == 5)
            {
                // Five of the dice have been kept.
            }
            else
            {
                // Dice kept count is 6.

                // Re-roll.
                Dice Die = new Dice();
                int returnAmt;
                returnAmt = Die.RollDice();
            }
            */

            // Die 1-dot = 100pts

            // Die 1-dot x 3 = 1000pts

            // Die 5-dot x 3 = 500pts

            // Die 3 x 2 = 200pts

            // Die 3 x 3 = 300pts

            // Die 3 x 4 = 400pts

            // Die 3 x 5 = 500pts

            // Die 3 x 6 = 600pts

            // Straight = 3000pts

            // Three pair = 1500pts

            // todo return tempScore???

            for(int i = 0; i < 6; i++)
            {
                if (DieKept[i] != 0)
                {
                    DieKept[i] = 0;
                }
            }

        }
    }
}
