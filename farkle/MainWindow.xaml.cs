//-----------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
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
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Score dice button should be disabeled till the roll dice button has been clicked.
            btnScoreDice.IsEnabled = false;

            // Dice checkboxes should be dissabled till the roll dice button has been clicked.
            cbxRoll1.IsEnabled = false;
            cbxRoll2.IsEnabled = false;
            cbxRoll3.IsEnabled = false;
            cbxRoll4.IsEnabled = false;
            cbxRoll5.IsEnabled = false;
            cbxRoll6.IsEnabled = false;
        }

        // Set up bool value for farkle.
        private bool playerFarkle = false;

        // New instance of the Dice Class.
        Dice allDice = new Dice();

        // New instance of the Player Class.
        Player player1 = new Player();

        public bool PlayerFarkle
        {
            get => playerFarkle;
            set => playerFarkle = value;
        }

        /// <summary>
        /// Method to set the images of the dice.
        /// </summary>
        public void SetDiceImg()
        {
            allDice.Die1 = allDice.DiceList[0];
            allDice.Die2 = allDice.DiceList[1];
            allDice.Die3 = allDice.DiceList[2];
            allDice.Die4 = allDice.DiceList[3];
            allDice.Die5 = allDice.DiceList[4];
            allDice.Die6 = allDice.DiceList[5];

            // Set up another array called currentDiceList to hold re-rolled dice.

            // If allDice.Die1-6 is not equal to currentDiceList[1-6]
            // if (all)


            // For die 1
            if (allDice.Die1 >= 1 && allDice.Die1 <= 6)
            {
                imgRoll1.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + allDice.Die1.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 2
            if (allDice.Die2 >= 1 && allDice.Die2 <= 6)
            {
                imgRoll2.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + allDice.Die2.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 3
            if (allDice.Die3 >= 1 && allDice.Die3 <= 6)
            {
                imgRoll3.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + allDice.Die3.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 4
            if (allDice.Die4 >= 1 && allDice.Die4 <= 6)
            {
                imgRoll4.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + allDice.Die4.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 5
            if (allDice.Die5 >= 1 && allDice.Die5 <= 6)
            {
                imgRoll5.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + allDice.Die5.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            //For die 6
            if (allDice.Die6 >= 1 && allDice.Die6 <= 6)
            {
                imgRoll6.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + allDice.Die6.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
        }

        /// <summary>
        /// Method for if cbxRoll1 is checked.
        /// </summary>
        private void cbxRoll1_Checked(object sender, RoutedEventArgs e)
        {

            if (imgSavedDie1.Visibility == Visibility.Hidden)
            {
                imgSavedDie1.Visibility = Visibility.Visible;
                imgSavedDie1.Source = imgRoll1.Source;
                imgRoll1.Visibility = Visibility.Hidden;
                cbxRoll1.IsChecked = false;
                allDice.Die1Visible = true;
                // add the roll to the dice kept array for that player
                player1.DieKept[0] = allDice.Die1;
            }
            else
            {
                imgSavedDie1.Visibility = Visibility.Hidden;
                imgRoll1.Visibility = Visibility.Visible;
                cbxRoll1.IsChecked = false;
                allDice.Die1Visible = false;
                // if the roll is saved, and between 1 and 6, remove it from the dice kept array and set the image source back to the original
                player1.DieKept[0] = 0;
                imgRoll1.Source = imgSavedDie1.Source;


            }
        }

        /// <summary>
        /// Method to check if cbxRoll2 is checked.
        /// </summary>
        private void cbxRoll2_Checked(object sender, RoutedEventArgs e)
        {

            if (imgSavedDie2.Visibility == Visibility.Hidden)
            {
                imgSavedDie2.Visibility = Visibility.Visible;
                imgSavedDie2.Source = imgRoll2.Source;
                imgRoll2.Visibility = Visibility.Hidden;
                cbxRoll2.IsChecked = false;
                allDice.Die2Visible = true;
                // second spot in the array holds die #2
                player1.DieKept[1] = allDice.Die2;
            }
            else
            {
                imgSavedDie2.Visibility = Visibility.Hidden;
                imgRoll2.Visibility = Visibility.Visible;
                cbxRoll2.IsChecked = false;
                allDice.Die2Visible = false;
                // if the roll is saved, and between 1 and 6, remove it from the dice kept array and set the image source back to the original
                player1.DieKept[1] = 0;
                imgRoll2.Source = imgSavedDie2.Source;
            }
        }

        /// <summary>
        /// Method to check if cbxRoll3 is checked.
        /// </summary>
        private void cbxRoll3_Checked(object sender, RoutedEventArgs e)
        {

            if (imgSavedDie3.Visibility == Visibility.Hidden)
            {
                imgSavedDie3.Visibility = Visibility.Visible;
                imgSavedDie3.Source = imgRoll3.Source;
                imgRoll3.Visibility = Visibility.Hidden;
                cbxRoll3.IsChecked = false;
                allDice.Die3Visible = true;
                // third spot in the array holds die #3
                player1.DieKept[2] = allDice.Die3;
            }
            else
            {
                imgSavedDie3.Visibility = Visibility.Hidden;
                imgRoll3.Visibility = Visibility.Visible;
                cbxRoll3.IsChecked = false;
                allDice.Die3Visible = false;
                // if the roll is saved, and between 1 and 6, remove it from the dice kept array and set the image source back to the original

                player1.DieKept[2] = 0;
                imgRoll3.Source = imgSavedDie3.Source;

            }
        }

        /// <summary>
        /// Method to check if cbxRoll4 is checked.
        /// </summary>
        private void cbxRoll4_Checked(object sender, RoutedEventArgs e)
        {

            if (imgSavedDie4.Visibility == Visibility.Hidden)
            {
                imgSavedDie4.Visibility = Visibility.Visible;
                imgSavedDie4.Source = imgRoll4.Source;
                imgRoll4.Visibility = Visibility.Hidden;
                cbxRoll4.IsChecked = false;
                allDice.Die4Visible = true;
                // fourth spot in the array holds die #4
                player1.DieKept[3] = allDice.Die4;
            }
            else
            {
                imgSavedDie4.Visibility = Visibility.Hidden;
                imgRoll4.Visibility = Visibility.Visible;
                cbxRoll4.IsChecked = false;
                allDice.Die4Visible = false;
                // if the roll is saved, and between 1 and 6, remove it from the dice kept array and set the image source back to the original
                player1.DieKept[3] = 0;
                imgRoll4.Source = imgSavedDie4.Source;
            }
        }

        /// <summary>
        /// Method to check if cbxRoll5 is checked.
        /// </summary>
        private void cbxRoll5_Checked(object sender, RoutedEventArgs e)
        {

            if (imgSavedDie5.Visibility == Visibility.Hidden)
            {
                imgSavedDie5.Visibility = Visibility.Visible;
                imgSavedDie5.Source = imgRoll5.Source;
                imgRoll5.Visibility = Visibility.Hidden;
                cbxRoll5.IsChecked = false;
                allDice.Die5Visible = true;
                // fifth spot in the array holds die #5
                player1.DieKept[4] = allDice.Die5;
            }
            else
            {
                imgSavedDie5.Visibility = Visibility.Hidden;
                imgRoll5.Visibility = Visibility.Visible;
                cbxRoll5.IsChecked = false;
                allDice.Die5Visible = false;
                // if the roll is saved, and between 1 and 6, remove it from the dice kept array and set the image source back to the original
                player1.DieKept[4] = 0;
                imgRoll5.Source = imgSavedDie5.Source;
            }
        }

        /// <summary>
        /// Method to check if cbxRoll6 is checked.
        /// </summary>
        private void cbxRoll6_Checked(object sender, RoutedEventArgs e)
        {

            if (imgSavedDie6.Visibility == Visibility.Hidden)
            {
                imgSavedDie6.Visibility = Visibility.Visible;
                imgSavedDie6.Source = imgRoll6.Source;
                imgRoll6.Visibility = Visibility.Hidden;
                cbxRoll6.IsChecked = false;
                allDice.Die6Visible = true;
                // sixth spot in the array holds die #6
                player1.DieKept[5] = allDice.Die6;
            }
            else
            {
                imgSavedDie6.Visibility = Visibility.Hidden;
                imgRoll6.Visibility = Visibility.Visible;
                cbxRoll6.IsChecked = false;
                allDice.Die6Visible = true;
                // if the roll is saved, and between 1 and 6, remove it from the dice kept array and set the image source back to the original
                player1.DieKept[5] = 0;
                imgRoll6.Source = imgSavedDie6.Source;
            }
        }

        /// <summary>
        /// Method to Check the Dice.
        /// </summary>
        public void CheckDice()     // todo return value for int method. (changed to void to make it work temporarily)
        {
            /*
            int dv1 = player1.DieKept[0];
            int dv2 = player1.DieKept[1];
            int dv3 = player1.DieKept[2];
            int dv4 = player1.DieKept[3];
            int dv5 = player1.DieKept[4];
            int dv6 = player1.DieKept[5];
            */

            // Set up a new list to hold the dice not being kept.
            List<int> diceInPlay = new List<int>();

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

            // Set up a bool value to hold true if there are scorable dice.
            bool scoreableDice = false;

            // If imgRoll1 is in play.
            if (imgRoll1.IsVisible)
            {
                // Add the first die.
                diceInPlay.Add(allDice.DiceList[0]);
            }

            // If imgRoll2 is in play.
            if (imgRoll2.IsVisible)
            {
                // Add the second die.
                diceInPlay.Add(allDice.DiceList[1]);
            }

            // If imgRoll3 is in play.
            if (imgRoll3.IsVisible)
            {
                // Add the third die.
                diceInPlay.Add(allDice.DiceList[2]);
            }

            // If imgRoll4 is in play.
            if (imgRoll4.IsVisible)
            {
                // Add the fourth die.
                diceInPlay.Add(allDice.DiceList[3]);
            }

            // If imgRoll5 is in play.
            if (imgRoll5.IsVisible)
            {
                // Add the fifth die.
                diceInPlay.Add(allDice.DiceList[4]);
            }

            // If imgRoll6 is in play.
            if (imgRoll6.IsVisible)
            {
                // Add the first die.
                diceInPlay.Add(allDice.DiceList[5]);
            }

            // Counters for each dice number.
            int oneCounter = 0;
            int twoCounter = 0;
            int threeCounter = 0;
            int fourCounter = 0;
            int fiveCounter = 0;
            int sixCounter = 0;

            // Loop through diceInPlay.
            foreach (int die in diceInPlay)
            {
                // Increment the counters.
                if (die == 1)
                {
                    oneCounter++;
                }
                else if (die == 2)
                {
                    twoCounter++;
                }
                else if (die == 3)
                {
                    threeCounter++;
                }
                else if (die == 4)
                {
                    fourCounter++;
                }
                else if (die == 5)
                {
                    fiveCounter++;
                }
                else
                {
                    // Die is 6, increment the six counter.
                    sixCounter++;
                }
            }

            if (diceInPlay.Count == 6)
            {
                // Check for a straight.
                if (oneCounter == 1 && twoCounter == 1 && threeCounter == 1 &&
                    fourCounter == 1 && fiveCounter == 1 && sixCounter == 1)
                {
                    // Set bool straight to true.
                    straight = true;
                }
                else if (oneCounter > 0 || fiveCounter > 0 || twoCounter >= 3 || threeCounter >= 3 ||
                         fourCounter >= 3 || sixCounter >= 3)
                {
                    // Set scoreableDice to true.
                    scoreableDice = true;
                }
                else
                {
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
                }

                // Check all bool values to see if there are scorable dice.
                if (straight || threePairs || scoreableDice)
                {
                    // There are scorable dice.
                }
                else
                {
                    // Set farkle to true.
                    playerFarkle = true;
                }

            }
            else if (diceInPlay.Count >= 3)
            {
                if (twoCounter < 3 && threeCounter < 3 && fourCounter < 3 && sixCounter < 3
                    && oneCounter == 0 && fiveCounter == 0)
                {
                    // Set farkle to true.
                    playerFarkle = true;
                }
                else
                {
                    // There are scorable dice.
                }
            }
            else if (diceInPlay.Count < 3 && diceInPlay.Count > 0)
            {
                // Check the one and five counters to see if they are greater than 0.
                if (oneCounter == 0 && fiveCounter == 0)
                {
                    // Set farkle to true.
                    playerFarkle = true;
                }
                else
                {
                    // There are scorable dice.
                }
            }
        }

        /// <summary>
        /// Method for BtnRoll Click.
        /// </summary>
        private void BtnRoll_Click(object sender, RoutedEventArgs e)
        {
            // If hot dice is true make imgRoll images visible.
            if (player1.HotDice)
            {
                imgRoll1.Visibility = Visibility.Visible;
                imgRoll2.Visibility = Visibility.Visible;
                imgRoll3.Visibility = Visibility.Visible;
                imgRoll4.Visibility = Visibility.Visible;
                imgRoll5.Visibility = Visibility.Visible;
                imgRoll6.Visibility = Visibility.Visible;
            }
            else
            {
                // Nothing needs to be done here.
            }

            // Reset players hotdice value to false.
            player1.HotDice = false;
            
            // Call RollDice method using the return value from check dice.
            Random rand = new Random();

            // Set up a counter for images visible.
            int visibleCounter = 0;

            if (imgRoll1.IsVisible)
            {
                visibleCounter++;
            }

            if (imgRoll2.IsVisible)
            {
                visibleCounter++;
            }

            if (imgRoll3.IsVisible)
            {
                visibleCounter++;
            }

            if (imgRoll4.IsVisible)
            {
                visibleCounter++;
            }

            if (imgRoll5.IsVisible)
            {
                visibleCounter++;
            }

            if (imgRoll6.IsVisible)
            {
                visibleCounter++;
            }


            allDice.RollDice(visibleCounter);
            allDice.Die1 = allDice.DiceList[0];
            allDice.Die2 = allDice.DiceList[1];
            allDice.Die3 = allDice.DiceList[2];
            allDice.Die4 = allDice.DiceList[3];
            allDice.Die5 = allDice.DiceList[4];
            allDice.Die6 = allDice.DiceList[5];
            // todo set text content of lblPendingScore. Im not sure how were going to do this continuously.

            // Call the SetDiceImg method.
            SetDiceImg();

            //allDice.DiceList.Clear();

            // btnRoll.IsEnabled = false;

            // Call Check Dice method.
            CheckDice();

            // If player did or did not farkle.
            if (!playerFarkle)
            {
                // There are scorable dice.
                // Player did not farkle but btnRoll should not be enabled until scoreDice is hit.
            }
            else
            {
                // The player farkled and it is no longer their turn.

                // Set the players score tempScore to 0.
                player1.TempScore = 0;

                // Messagebox telling the player they farkled.
                MessageBox.Show("Farkle! You lost all points for this round.");
            }

            // Disable the roll button.
            btnRoll.IsEnabled = false;

            // Enable the score dice button.
            btnScoreDice.IsEnabled = true;

            if (playerFarkle)
            {
                // Disable the dice check boxes.
                cbxRoll1.IsEnabled = false;
                cbxRoll2.IsEnabled = false;
                cbxRoll3.IsEnabled = false;
                cbxRoll4.IsEnabled = false;
                cbxRoll5.IsEnabled = false;
                cbxRoll6.IsEnabled = false;

                // Disable the score dice button.
                btnScoreDice.IsEnabled = false;
            }
            else
            {
                // Enable the dice check boxes
                cbxRoll1.IsEnabled = true;
                cbxRoll2.IsEnabled = true;
                cbxRoll3.IsEnabled = true;
                cbxRoll4.IsEnabled = true;
                cbxRoll5.IsEnabled = true;
                cbxRoll6.IsEnabled = true;
            }
        }

        /// <summary>
        /// Method for BtnNextTurn Click.
        /// </summary>
        private void BtnNextTurn_Click(object sender, RoutedEventArgs e)
        {
            // Reset round to 0.
            player1.Round = 0;

            int i = 0;
            // Reset their dikept array to 0's
            while (i < player1.DieKept.Count())
            {
                player1.DieKept[i] = 0;
                i++;
            }

            // Hide all the saved die images.
            imgSavedDie1.Visibility = Visibility.Hidden;
            imgSavedDie2.Visibility = Visibility.Hidden;
            imgSavedDie3.Visibility = Visibility.Hidden;
            imgSavedDie4.Visibility = Visibility.Hidden;
            imgSavedDie5.Visibility = Visibility.Hidden;
            imgSavedDie6.Visibility = Visibility.Hidden;

            // Make the imgRoll images visible.
            imgRoll1.Visibility = Visibility.Visible;
            imgRoll2.Visibility = Visibility.Visible;
            imgRoll3.Visibility = Visibility.Visible;
            imgRoll4.Visibility = Visibility.Visible;
            imgRoll5.Visibility = Visibility.Visible;
            imgRoll6.Visibility = Visibility.Visible;

            // Call the score dice method.
            // player1.ScoreDice();

            // Enable the roll button.
            btnRoll.IsEnabled = true;

            // todo for testing purposes put scoring here.
            // player1.ScoreDice(allDice.DiceList);

            // Set current score.
            if (!playerFarkle)
            {
                // Add the tempScore returned from the score dice method to current score.
                player1.CurrentScore += player1.TempScore;
            }
            else
            {
                // Add no points to the current score.
                player1.CurrentScore += 0;

                // Disable the dice check boxes.
                cbxRoll1.IsEnabled = false;
                cbxRoll2.IsEnabled = false;
                cbxRoll3.IsEnabled = false;
                cbxRoll4.IsEnabled = false;
                cbxRoll5.IsEnabled = false;
                cbxRoll6.IsEnabled = false;

                // Reset farkle to false.
                playerFarkle = false;
            }

            // Reset player1s tempScore to 0.
            player1.TempScore = 0;

            // Reset lblPendingScore.
            lblPendingScore.Content = "Pending Score: " + player1.TempScore.ToString();

            // Set text content of lblCurrentScore.
            lblCurrentScore.Content = "Current Score: " + player1.CurrentScore;

            // Check if score is greater than or equal to 10000. If it is the player wins.
            if (player1.CurrentScore >= 10000) 
            {
                // Message box to show winner message.
                MessageBox.Show("Great job! You won a single player game!");

                // Close the game.
                this.Close();
            }
            else
            {
                // Player has not won yet.
            }

            // Disable the score dice button.
            btnScoreDice.IsEnabled = false;

            // Disable the dice check boxes.
            cbxRoll1.IsEnabled = false;
            cbxRoll2.IsEnabled = false;
            cbxRoll3.IsEnabled = false;
            cbxRoll4.IsEnabled = false;
            cbxRoll5.IsEnabled = false;
            cbxRoll6.IsEnabled = false;
        }

        /// <summary>
        /// Method for BtnExitTurn Click.
        /// </summary>
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void btnScoring_Click(object sender, RoutedEventArgs e)
        {
            Scoring ScoreSheet = new Scoring();
            ScoreSheet.Show();
        }

        private void BtnScoreDice_Click(object sender, RoutedEventArgs e)
        {
            // Score the dice for that hand.
            player1.ScoreDice(player1.DieKept);

            // If dice are valid.
            if (player1.ValidDice)
            {
                // Enable the roll button.
                btnRoll.IsEnabled = true;

                // Set label to show score.
                lblPendingScore.Content = "Pending Score: " + player1.TempScore.ToString();
                
                // Disable the button: we don't want any cheaters.
                btnScoreDice.IsEnabled = false;

                // Disable the dice check boxes.
                cbxRoll1.IsEnabled = false;
                cbxRoll2.IsEnabled = false;
                cbxRoll3.IsEnabled = false;
                cbxRoll4.IsEnabled = false;
                cbxRoll5.IsEnabled = false;
                cbxRoll6.IsEnabled = false;
            }
            else
            {
                // Disable the roll button.
                btnRoll.IsEnabled = false;

                // Display message that some dice are not scorable.
                MessageBox.Show("Some of your dice are not scorable!");

            }

            // Check to see if all dice have been kept and are valid.
            if (imgSavedDie1.IsVisible && imgSavedDie2.IsVisible && imgSavedDie3.IsVisible
                && imgSavedDie4.IsVisible && imgSavedDie5.IsVisible && imgSavedDie6.IsVisible
                && player1.ValidDice)
            {
                // Set hot dice to true.
                player1.HotDice = true;

                // Messagebox telling the user they can roll again.
                MessageBox.Show("You have hot dice! Roll again!");

                // Disable the dice check boxes.
                cbxRoll1.IsEnabled = false;
                cbxRoll2.IsEnabled = false;
                cbxRoll3.IsEnabled = false;
                cbxRoll4.IsEnabled = false;
                cbxRoll5.IsEnabled = false;
                cbxRoll6.IsEnabled = false;
            }
            else
            {
                // Hot dice is already false.
            }

            // Check if player has hot dice.
            if (player1.HotDice)
            {
                int i = 0;
                // if they do reset their dikept array to 0's
                while(i < player1.DieKept.Count())
                {
                    player1.DieKept[i] = 0;
                    i++;
                } 
               
                // If they do, hide all the saved die images.
                imgSavedDie1.Visibility = Visibility.Hidden;
                imgSavedDie2.Visibility = Visibility.Hidden;
                imgSavedDie3.Visibility = Visibility.Hidden;
                imgSavedDie4.Visibility = Visibility.Hidden;
                imgSavedDie5.Visibility = Visibility.Hidden;
                imgSavedDie6.Visibility = Visibility.Hidden;
            }
            else
            {
                // Nothing needs to be done here.
            }
        }
    }
}
