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

            // TODO: ScoreDice button needs to be depricated before we turn this in.
            // Score dice button should be disabeled till the roll dice button has been clicked.

            // Dice checkboxes should be dissabled till the roll dice button has been clicked.


        }


        // Set up bool value for farkle.
        private bool onePlayer;

        // Set up bool value for farkle.
        private bool twoPlayer;

        // Set up bool value for farkle.
        private bool threePlayer;

        // Set up bool value for farkle.
        private bool fourPlayer;

        // Set up bool value for farkle.
        private bool playerFarkle = false;

        // New instance of the Dice Class.
        Dice die1 = new Dice();
        Dice die2 = new Dice();
        Dice die3 = new Dice();
        Dice die4 = new Dice();
        Dice die5 = new Dice();
        Dice die6 = new Dice();


        // Declare the Dicelist that holds the dice
        public List<int> DiceList = new List<int>();

        // Declare a new list to hold the dice that are in the saved die area.
        List<Dice> savedDieList = new List<Dice>();

        // Set up a new list to hold the dice not being kept.
        List<Dice> diceInPlay = new List<Dice>();

        List<Dice> locked1List = new List<Dice>();

        List<Dice> locked2List = new List<Dice>();

        List<Dice> locked3List = new List<Dice>();

        List<Dice> locked4List = new List<Dice>();

        List<Dice> locked5List = new List<Dice>();

        private int rollIncrementer = 0;

        // Create new list for players.
        List<Player> currentPlayerList = new List<Player>();

        /// <summary>
        /// Gets or sets playerFarkle.
        /// </summary>
        public bool PlayerFarkle
        {
            get => playerFarkle;
            set => playerFarkle = value;
        }

        /// <summary>
        /// Gets or sets onePlayer.
        /// </summary>
        public bool OnePlayer
        {
            get => onePlayer;
            set => onePlayer = value;
        }

        /// <summary>
        /// Gets or sets twoPlayer.
        /// </summary>
        public bool TwoPlayer
        {
            get => twoPlayer;
            set => twoPlayer = value;
        }

        /// <summary>
        /// Gets or sets threePlayer.
        /// </summary>
        public bool ThreePlayer
        {
            get => threePlayer;
            set => threePlayer = value;
        }

        /// <summary>
        /// Gets or sets fourPlayer.
        /// </summary>
        public bool FourPlayer
        {
            get => fourPlayer;
            set => fourPlayer = value;
        }

        /// <summary>
        /// Method to set the images of the dice.
        /// </summary>
        public void SetDiceImg()
        {
            die1.pips = DiceList[0];
            die2.pips = DiceList[1];
            die3.pips = DiceList[2];
            die4.pips = DiceList[3];
            die5.pips = DiceList[4];
            die6.pips = DiceList[5];

            // Set up another array called currentDiceList to hold re-rolled dice.

            // If allDice.Die1-6 is not equal to currentDiceList[1-6]
            // if (all)


            // For die 1
            if (die1.pips >= 1 && die1.pips <= 6)
            {
                imgRoll1.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + die1.pips.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 2
            if (die2.pips >= 1 && die2.pips <= 6)
            {
                imgRoll2.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + die2.pips.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 3
            if (die3.pips >= 1 && die3.pips <= 6)
            {
                imgRoll3.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + die3.pips.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 4
            if (die4.pips >= 1 && die4.pips <= 6)
            {
                imgRoll4.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + die4.pips.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 5
            if (die5.pips >= 1 && die5.pips <= 6)
            {
                imgRoll5.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + die5.pips.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            //For die 6
            if (die6.pips >= 1 && die6.pips <= 6)
            {
                imgRoll6.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + die6.pips.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
        }
        /// --------------------------------------------------------------------------------------------------------------------------------------------------------------
        // New instance of the Player Class.
        /// <summary>
        /// Method for if cbxRoll1 is checked.
        /// </summary>
        private void imgRoll1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgSavedDie1.Visibility == Visibility.Hidden)
            {
                imgSavedDie1.Visibility = Visibility.Visible;
                imgSavedDie1.Source = imgRoll1.Source;
                imgRoll1.Visibility = Visibility.Hidden;
                // sixth spot in the array holds die #6
                currentPlayerList[0].DieKept[0] = die1.pips;
                savedDieList.Add(die1);
                diceInPlay.Remove(die1);
                // player1.ScoreDice(savedDieList);

                // Call Display Score method.
                DisplayScore();
            }
        }

        private void imgSavedDie1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgRoll1.Visibility == Visibility.Hidden)
            {
                if (!die1.locked && !die1.locked && !die1.locked && !die1.locked && !die1.locked)
                {
                    imgRoll1.Source = imgSavedDie1.Source;
                    imgRoll1.Visibility = Visibility.Visible;
                    imgSavedDie1.Visibility = Visibility.Hidden;
                    currentPlayerList[0].DieKept[0] = 0;
                    diceInPlay.Add(die1);
                    savedDieList.Remove(die1);
                    // player1.ScoreDice(savedDieList);
                    /*
                    die1.removed = true;

                    currentPlayerList[0].RemoveDieScore(diceInPlay, savedDieList);

                    lblPendingScore.Content = "Pending Score: " + currentPlayerList[0].TempScore.ToString();
                    */
                    // Call Display Score method.
                    DisplayScore();
                }

            }
        }

        /// <summary>
        /// Method to check if cbxRoll2 is checked.
        /// </summary>
        private void imgRoll2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgSavedDie2.Visibility == Visibility.Hidden)
            {
                imgSavedDie2.Visibility = Visibility.Visible;
                imgSavedDie2.Source = imgRoll2.Source;
                imgRoll2.Visibility = Visibility.Hidden;
                // sixth spot in the array holds die #6
                currentPlayerList[0].DieKept[1] = die2.pips;
                savedDieList.Add(die2);
                diceInPlay.Remove(die2);
                // player1.ScoreDice(savedDieList);

                // Call Display Score method.
                DisplayScore();
            }
        }

        private void imgSavedDie2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgRoll2.Visibility == Visibility.Hidden)
            {
                if (!die2.locked)
                {
                    imgRoll2.Source = imgSavedDie2.Source;
                    imgRoll2.Visibility = Visibility.Visible;
                    imgSavedDie2.Visibility = Visibility.Hidden;
                    currentPlayerList[0].DieKept[1] = 0;
                    diceInPlay.Add(die2);
                    savedDieList.Remove(die2);

                    // Call Display Score method.
                    DisplayScore();
                }

            }
        }

        /// <summary>
        /// Method to check if cbxRoll3 is checked.
        /// </summary>
        private void imgRoll3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgSavedDie3.Visibility == Visibility.Hidden)
            {
                imgSavedDie3.Visibility = Visibility.Visible;
                imgSavedDie3.Source = imgRoll3.Source;
                imgRoll3.Visibility = Visibility.Hidden;

                // sixth spot in the array holds die #6
                currentPlayerList[0].DieKept[2] = die3.pips;
                savedDieList.Add(die3);
                diceInPlay.Remove(die3);

                // Call Display Score method.
                DisplayScore();
            }
        }

        private void imgSavedDie3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgRoll3.Visibility == Visibility.Hidden)
            {
                if (!die3.locked)
                {
                    imgRoll3.Source = imgSavedDie3.Source;
                    imgRoll3.Visibility = Visibility.Visible;
                    imgSavedDie3.Visibility = Visibility.Hidden;
                    currentPlayerList[0].DieKept[2] = 0;
                    diceInPlay.Add(die3);
                    savedDieList.Remove(die3);

                    // Call Display Score method.
                    DisplayScore();
                }

            }
        }

        /// <summary>
        /// Method to check if cbxRoll4 is checked.
        /// </summary>
        private void imgRoll4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgSavedDie4.Visibility == Visibility.Hidden)
            {
                imgSavedDie4.Visibility = Visibility.Visible;
                imgSavedDie4.Source = imgRoll4.Source;
                imgRoll4.Visibility = Visibility.Hidden;

                // sixth spot in the array holds die #6
                currentPlayerList[0].DieKept[3] = die4.pips;
                savedDieList.Add(die4);
                diceInPlay.Remove(die4);

                // Call Display Score method.
                DisplayScore();
            }
        }

        private void imgSavedDie4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgRoll4.Visibility == Visibility.Hidden)
            {
                if (!die4.locked)
                {
                    imgRoll4.Source = imgSavedDie4.Source;
                    imgRoll4.Visibility = Visibility.Visible;
                    imgSavedDie4.Visibility = Visibility.Hidden;
                    currentPlayerList[0].DieKept[3] = 0;
                    diceInPlay.Add(die4);
                    savedDieList.Remove(die4);

                    // Call Display Score method.
                    DisplayScore();
                }
            }
        }

        private void imgRoll5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgSavedDie5.Visibility == Visibility.Hidden)
            {
                imgSavedDie5.Visibility = Visibility.Visible;
                imgSavedDie5.Source = imgRoll5.Source;
                imgRoll5.Visibility = Visibility.Hidden;

                // sixth spot in the array holds die #6
                currentPlayerList[0].DieKept[4] = die5.pips;
                savedDieList.Add(die5);
                diceInPlay.Remove(die5);

                // Call Display Score method.
                DisplayScore();
            }
        }

        private void imgSavedDie5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgRoll5.Visibility == Visibility.Hidden)
            {
                if (!die5.locked && !die5.locked && !die5.locked && !die5.locked && !die5.locked)
                {
                    imgRoll5.Source = imgSavedDie5.Source;
                    imgRoll5.Visibility = Visibility.Visible;
                    imgSavedDie5.Visibility = Visibility.Hidden;
                    currentPlayerList[0].DieKept[4] = 0;
                    diceInPlay.Add(die5);
                    savedDieList.Remove(die5);

                    // Call Display Score method.
                    DisplayScore();
                }
            }
        }

        private void imgRoll6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgSavedDie6.Visibility == Visibility.Hidden)
            {
                imgSavedDie6.Visibility = Visibility.Visible;
                imgSavedDie6.Source = imgRoll6.Source;
                imgRoll6.Visibility = Visibility.Hidden;

                // sixth spot in the array holds die #6
                currentPlayerList[0].DieKept[5] = die6.pips;
                savedDieList.Add(die6);
                diceInPlay.Remove(die6);

                // Call Display Score method.
                DisplayScore();
            }
        }

        private void imgSavedDie6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (imgRoll6.Visibility == Visibility.Hidden)
            {
                if (!die6.locked && !die6.locked && !die6.locked && !die6.locked && !die6.locked)
                {
                    imgRoll6.Source = imgSavedDie6.Source;
                    imgRoll6.Visibility = Visibility.Visible;
                    imgSavedDie6.Visibility = Visibility.Hidden;
                    currentPlayerList[0].DieKept[5] = 0;
                    diceInPlay.Add(die6);
                    savedDieList.Remove(die6);

                    // Call Display Score method.
                    DisplayScore();
                }
                else
                {
                    // MessageBox.Show("You've saved this die and it is locked for this round");
                }

            }
        }
        /// ------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to Check the Dice.
        /// </summary>
        public void CheckDice()     // todo return value for int method. (changed to void to make it work temporarily)
        {
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

            // Clear diceInPlay.
            diceInPlay.Clear();
            
            // If imgRoll1 is in play.
            if (imgRoll1.IsVisible)
            {
                // Add the first die.
                diceInPlay.Add(die1);
            }

            // If imgRoll2 is in play.
            if (imgRoll2.IsVisible)
            {
                // Add the second die.
                diceInPlay.Add(die2);
            }

            // If imgRoll3 is in play.
            if (imgRoll3.IsVisible)
            {
                // Add the third die.
                diceInPlay.Add(die3);
            }

            // If imgRoll4 is in play.
            if (imgRoll4.IsVisible)
            {
                // Add the fourth die.
                diceInPlay.Add(die4);
            }

            // If imgRoll5 is in play.
            if (imgRoll5.IsVisible)
            {
                // Add the fifth die.
                diceInPlay.Add(die5);
            }

            // If imgRoll6 is in play.
            if (imgRoll6.IsVisible)
            {
                // Add the first die.
                diceInPlay.Add(die6);
            }
            

            // Counters for each dice number.
            int oneCounter = 0;
            int twoCounter = 0;
            int threeCounter = 0;
            int fourCounter = 0;
            int fiveCounter = 0;
            int sixCounter = 0;

            // Loop through diceInPlay.
            foreach (Dice die in diceInPlay)
            {
                // Increment the counters.
                if (die.pips == 1)
                {
                    oneCounter++;
                }
                else if (die.pips == 2)
                {
                    twoCounter++;
                }
                else if (die.pips == 3)
                {
                    threeCounter++;
                }
                else if (die.pips == 4)
                {
                    fourCounter++;
                }
                else if (die.pips == 5)
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
            if (savedDieList.Count > 0 && !currentPlayerList[0].ValidDice)
            {
                // Display message that some dice are not scorable.
                MessageBox.Show("Some of your dice are not scorable!");
            }
            else
            {
                if (currentPlayerList[0].ValidDice || rollIncrementer == 0)
                {
                    // Loop through savedDieList
                    foreach (Dice die in savedDieList)
                    {
                        // Check rollIncrementer to see which roll it is.
                        if (rollIncrementer == 1)
                        {
                            // Set locked to true.
                            die.locked = true;

                            // Add to locked1List.
                            locked1List.Add(die);
                        }
                        else if (rollIncrementer == 2)
                        {
                            // Set locked to true.
                            die.locked = true;

                            // Add to locked2List.
                            locked2List.Add(die);
                        }
                        else if (rollIncrementer == 3)
                        {
                            // Set locked to true.
                            die.locked = true;

                            // Add to locked1List.
                            locked3List.Add(die);
                        }
                        else if (rollIncrementer == 4)
                        {
                            // Set locked to true.
                            die.locked = true;

                            // Add to locked1List.
                            locked4List.Add(die);
                        }
                        else if (rollIncrementer == 5)
                        {
                            // Set locked to true.
                            die.locked = true;

                            // Add to locked1List.
                            locked5List.Add(die);
                        }
                        else
                        {
                            // 6th roll: Either hotDice or Farkle.
                        }
                    }

                    // If die 1 is locked.
                    if (die1.locked || die1.locked || die1.locked || die1.locked || die1.locked)
                    {
                        // Make the border visible.
                        bdrDie1.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        bdrDie1.Visibility = Visibility.Hidden;
                    }

                    // If die 2 is locked.
                    if (die2.locked || die2.locked || die2.locked || die2.locked || die2.locked)
                    {
                        // Make the border visible.
                        bdrDie2.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        bdrDie2.Visibility = Visibility.Hidden;
                    }

                    // If die 3 is locked.
                    if (die3.locked || die3.locked || die3.locked || die3.locked || die3.locked)
                    {
                        // Make the border visible.
                        bdrDie3.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        bdrDie3.Visibility = Visibility.Hidden;
                    }

                    // If die 4 is locked.
                    if (die4.locked || die4.locked || die4.locked || die4.locked || die4.locked)
                    {
                        // Make the border visible.
                        bdrDie4.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        bdrDie4.Visibility = Visibility.Hidden;
                    }

                    // If die 5 is locked.
                    if (die5.locked || die5.locked || die5.locked || die5.locked || die5.locked)
                    {
                        // Make the border visible.
                        bdrDie5.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        bdrDie5.Visibility = Visibility.Hidden;
                    }

                    // If die 6 is locked.
                    if (die6.locked || die6.locked || die6.locked || die6.locked || die6.locked)
                    {
                        // Make the border visible.
                        bdrDie6.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        bdrDie6.Visibility = Visibility.Hidden;
                    }

                    // this used to be in the below if statement check
                    // imgSavedDie1.IsVisible && imgSavedDie2.IsVisible && imgSavedDie3.IsVisible
                    // && imgSavedDie4.IsVisible && imgSavedDie5.IsVisible && imgSavedDie6.IsVisible
                    // && player1.ValidDice
                    // Check to see if all dice have been kept and are valid.
                    if (savedDieList.Count == 6)
                    {
                        // Set hot dice to true.
                        currentPlayerList[0].HotDice = true;
                        bdrDie1.Visibility = Visibility.Hidden;
                        bdrDie2.Visibility = Visibility.Hidden;
                        bdrDie3.Visibility = Visibility.Hidden;
                        bdrDie4.Visibility = Visibility.Hidden;
                        bdrDie5.Visibility = Visibility.Hidden;
                        bdrDie6.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        // Hot dice is already false.
                    }

                    // If hot dice is true make imgRoll images visible.
                    if (currentPlayerList[0].HotDice)
                    {
                        // Make the images visible.
                        imgRoll1.Visibility = Visibility.Visible;
                        imgRoll2.Visibility = Visibility.Visible;
                        imgRoll3.Visibility = Visibility.Visible;
                        imgRoll4.Visibility = Visibility.Visible;
                        imgRoll5.Visibility = Visibility.Visible;
                        imgRoll6.Visibility = Visibility.Visible;

                        // If they do, hide all the saved die images. todo moved from scoreDice section.
                        imgSavedDie1.Visibility = Visibility.Hidden;
                        imgSavedDie2.Visibility = Visibility.Hidden;
                        imgSavedDie3.Visibility = Visibility.Hidden;
                        imgSavedDie4.Visibility = Visibility.Hidden;
                        imgSavedDie5.Visibility = Visibility.Hidden;
                        imgSavedDie6.Visibility = Visibility.Hidden;

                        // Unlock each die in savedDieList. todo new
                        foreach (Dice die in savedDieList)
                        {
                            die.locked = false;                            
                        }

                        // Clear the savedDieList. todo new
                        savedDieList.Clear();

                        // Set wasHotDice to true.
                        currentPlayerList[0].WasHotDice = true;

                        // Set the hotDiceAccumulator equal to the tempScore.
                        currentPlayerList[0].HotDiceAccumulator = currentPlayerList[0].TempScore;

                        // todo set hotDiceAccumulator to 0 somewhere other than next turn?

                        // Reset players hotdice value to false.
                        currentPlayerList[0].HotDice = false;
                    }
                    else
                    {
                        // Nothing needs to be done here.
                    }

                    // Add the die to the diceInPlayList.

                    // Add the Die to the list
                    DiceList.Add(die1.pips);
                    DiceList.Add(die2.pips);
                    DiceList.Add(die3.pips);
                    DiceList.Add(die4.pips);
                    DiceList.Add(die5.pips);
                    DiceList.Add(die6.pips);

                    // Call RollDice method using the return value from check dice.
                    RollDice(diceInPlay.Count);
                    die1.pips = DiceList[0];
                    die2.pips = DiceList[1];
                    die3.pips = DiceList[2];
                    die4.pips = DiceList[3];
                    die5.pips = DiceList[4];
                    die6.pips = DiceList[5];

                    // Call the SetDiceImg method.
                    SetDiceImg();


                    DiceList.Clear();

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
                        currentPlayerList[0].TempScore = 0;

                        // Messagebox telling the player they farkled.
                        MessageBox.Show("Farkle! You lost all points for this round."
                            + "\n" + "Please hit the next turn button.");

                        // Disable the roll button.
                        btnRoll.IsEnabled = false;

                        
                        // Disable the imgRoll images.
                        imgRoll1.IsEnabled = false;
                        imgRoll2.IsEnabled = false;
                        imgRoll3.IsEnabled = false;
                        imgRoll4.IsEnabled = false;
                        imgRoll5.IsEnabled = false;
                        imgRoll6.IsEnabled = false;
                        

                        // Call Display Score method.
                        DisplayScore();
                    }

                    // Check if player has hot dice.
                    if (currentPlayerList[0].HotDice)
                    {
                        int i = 0;
                        // if they do reset their dicekept array to 0's
                        while (i < currentPlayerList[0].DieKept.Count())
                        {
                            currentPlayerList[0].DieKept[i] = 0;
                            i++;
                        }

                        // this is where the imgSavedDie.Visibility hidden statements used to be.
                    }
                    else
                    {
                        // Nothing needs to be done here.
                    }

                }
            }

            if (currentPlayerList[0].HotDice)
            {
                rollIncrementer = 0;
            }
            else
            {
                rollIncrementer++;
            }
        }

        /// <summary>
        /// Method for BtnNextTurn Click.
        /// </summary>
        private void BtnNextTurn_Click(object sender, RoutedEventArgs e)
        {
            rollIncrementer = 0;
            // Call ResetFieldsForNewTurn.
            currentPlayerList[0].ResetFieldsForNewTurn();

            // Call ResetLockedLists to reset locked lists and dice.
            ResetLockedLists();

            // Disable the imgRoll images.
            imgRoll1.IsEnabled = true;
            imgRoll2.IsEnabled = true;
            imgRoll3.IsEnabled = true;
            imgRoll4.IsEnabled = true;
            imgRoll5.IsEnabled = true;
            imgRoll6.IsEnabled = true;

            int i = 0;

            // Reset their dikept array to 0's
            while (i < currentPlayerList[0].DieKept.Count())
            {
                currentPlayerList[0].DieKept[i] = 0;
                i++;
            }

            /*
            // reset the locked variable on every die to false
            die1.locked = false;
            die2.locked = false;
            die3.locked = false;
            die4.locked = false;
            die5.locked = false;
            die6.locked = false;
            */

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

            // todo for testing purposes put scoring here.
            // player1.ScoreDice(allDice.DiceList);

            // Set current score.
            if (!playerFarkle)
            {
                // Add the tempScore returned from the score dice method to current score.
                currentPlayerList[0].CurrentScore = currentPlayerList[0].TempScore + currentPlayerList[0].CurrentScore;
            }
            else
            {
                // Add no points to the current score.
                currentPlayerList[0].CurrentScore += 0;

                // Reset farkle to false.
                playerFarkle = false;
            }

            // Reset player1s tempScore to 0.
            currentPlayerList[0].TempScore = 0;

            // Reset lblPendingScore.
            lblPendingScore.Content = "Pending Score: " + currentPlayerList[0].TempScore.ToString();

            // Set text content of lblCurrentScore.
            lblCurrentScore.Content = "Current Score: " + currentPlayerList[0].CurrentScore;

            // Check if score is greater than or equal to 10000. If it is the player wins.
            if (currentPlayerList[0].CurrentScore >= 10000)
            {
                // Message box to show winner message and ask if player wants to start a new game.
                MessageBoxResult dialogResult = MessageBox.Show("Great job, player 1 wins! Would you like to start a new game.",
                                "Winner",
                                MessageBoxButton.YesNo);
                if (dialogResult == MessageBoxResult.Yes)
                {
                    // Start new game.                 
                    // Close the current form.
                    this.Hide();
                    // Create new MainWindow form.
                    // Change to showing options menu to start new game.
                    MainWindow newgame = new MainWindow();
                    // Show form.
                    newgame.ShowDialog();
                }
                else
                {
                    // Close the game.
                    this.Close();
                }
            }
            else
            {
                // Player has not won yet.
            }
            savedDieList.Clear();
            // Update this players score on the right hand side of the screen / play area
            if (currentPlayerList[0].Number == 1)
            {
                lblPlayerOneScore.Content = "Score " + currentPlayerList[0].CurrentScore;

            }
            else if (currentPlayerList[0].Number == 2)
            {
                lblPlayerTwoScore.Content = "Score " + currentPlayerList[0].CurrentScore;
            }
            else if (currentPlayerList[0].Number == 3)
            {
                lblPlayerThreeScore.Content = "Score " + currentPlayerList[0].CurrentScore;
            }
            else if (currentPlayerList[0].Number == 4)
            {
                lblPlayerFourScore.Content = "Score " + currentPlayerList[0].CurrentScore;
            }


            currentPlayerList.Add(currentPlayerList[0]);
            currentPlayerList.Remove(currentPlayerList[0]);

            //Roll for the next turn
            BtnRoll_Click(null, null);

            // Set text content of where the players information goes.
            lblPlayerInformation.Content = "Player " + currentPlayerList[0].Number.ToString() + "'s Turn";

            lblCurrentScore.Content = "Current Score: " + currentPlayerList[0].CurrentScore;

            btnRoll.IsEnabled = false;
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
            // Add the Die to the list
            DiceList.Add(die1.pips);
            DiceList.Add(die2.pips);
            DiceList.Add(die3.pips);
            DiceList.Add(die4.pips);
            DiceList.Add(die5.pips);
            DiceList.Add(die6.pips);
            // dont need this
            // Use as a temporary way to score a straight.
            die1.pips = 1;
            die2.pips = 1;
            die3.pips = 1;
            die4.pips = 2;
            die5.pips = 2;
            die6.pips = 2;

            SetDiceImg();
            
        }


        Random rand = new Random();
        /// <summary>
        /// Method to roll the dice.
        /// </summary>
        public void RollDice(int diceRolled)
        {

            for (int counter = 0; counter < DiceList.Count(); counter++)
            {

                DiceList[counter] = rand.Next(6) + 1;
            }
            

        }

        public void DisplayScore()
        {
            // Score the dice for that hand.
            currentPlayerList[0].ScoreDice(savedDieList, locked1List, locked2List, locked3List, locked4List, locked5List);

            // If dice are valid.
            if (currentPlayerList[0].ValidDice)
            {
                if (!playerFarkle)
                {
                    // Enable the roll button.
                    btnRoll.IsEnabled = true;
                }

                // Set label to show score.
                lblPendingScore.Content = "Pending Score: " + currentPlayerList[0].TempScore.ToString();

                if (!playerFarkle)
                {
                    lblCurrentScore.Content = "Current Score: " + (currentPlayerList[0].CurrentScore + currentPlayerList[0].TempScore).ToString();
                }
                else
                {
                    lblCurrentScore.Content = "Current Score: " + (currentPlayerList[0].CurrentScore).ToString();
                }

            }
            else
            {
                lblPendingScore.Content = "Pending Score: " + currentPlayerList[0].TempScore.ToString();
                lblCurrentScore.Content = "Current Score: " +
                                          (currentPlayerList[0].CurrentScore + currentPlayerList[0].TempScore)
                                          .ToString();
            }

            // Check to see if all dice have been kept and are valid.
            if (imgSavedDie1.IsVisible && imgSavedDie2.IsVisible && imgSavedDie3.IsVisible
                && imgSavedDie4.IsVisible && imgSavedDie5.IsVisible && imgSavedDie6.IsVisible
                && currentPlayerList[0].ValidDice)
            {
                // Set hot dice to true.
                currentPlayerList[0].HotDice = true;
                // Messagebox telling the user they can roll again.
                MessageBox.Show("You have hot dice! You can roll again to try and score" +
                                " more points, or you can press the next turn button to end your turn!"
                                + "\n" + "\n" +
                                "If you decide to roll again you could possibly lose all of your points " +
                                "for this turn!!");
            }
            else
            {
                // Hot dice is already false.
            }



            // todo locked vs scoring maybe?
            // when clicking on saved die the to scores are adding not subtracting
            // Extra dice are being scored.
            // when to lock dice.
            // when to call scoring?
            // inverse display method?

            // todo after some dice are locked dynamic scoring doesnt work if dice is removed.
            // todo maybe add some sort of counter to check if there are less in saved dice than the previous roll?
            // todo checkDice method not working.
            // todo dynamic scoring for currentScore. -- done
            // todo check to make sure resetFields... method is working
            // todo goofy stuff going on with scoring, when 3 of a kind + 1 or 5 and removal/addition of dice to savedDieList.

        }

        private void ResetLockedLists()
        {
            // Reset locked lists.
            locked1List.Clear();
            locked2List.Clear();
            locked3List.Clear();
            locked4List.Clear();
            locked5List.Clear();

            // Reset the locked fields of every dice.
            die1.ResetLockedDice();
            die2.ResetLockedDice();
            die3.ResetLockedDice();
            die4.ResetLockedDice();
            die5.ResetLockedDice();
            die6.ResetLockedDice();

            // Reset the borders.
            bdrDie1.Visibility = Visibility.Hidden;
            bdrDie2.Visibility = Visibility.Hidden;
            bdrDie3.Visibility = Visibility.Hidden;
            bdrDie4.Visibility = Visibility.Hidden;
            bdrDie5.Visibility = Visibility.Hidden;
            bdrDie6.Visibility = Visibility.Hidden;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Player tempPlayer = new Player();
            if (onePlayer)
            {
                tempPlayer.Number = 1;
                currentPlayerList.Add(tempPlayer);

                // Hide the last three player score labels and player labels.
                lblPlayerTwo.Visibility = Visibility.Hidden;
                lblPlayerTwoScore.Visibility = Visibility.Hidden;
                lblPlayerThree.Visibility = Visibility.Hidden;
                lblPlayerThreeScore.Visibility = Visibility.Hidden;
                lblPlayerFour.Visibility = Visibility.Hidden;
                lblPlayerFourScore.Visibility = Visibility.Hidden;

            }
            else if (twoPlayer)
            {
                tempPlayer.Number = 1;
                currentPlayerList.Add(tempPlayer);

                tempPlayer = new Player();
                tempPlayer.Number = 2;
                currentPlayerList.Add(tempPlayer);

                lblPlayerFour.Visibility = Visibility.Hidden;
                lblPlayerThree.Visibility = Visibility.Hidden;
                lblPlayerFourScore.Visibility = Visibility.Hidden;
                lblPlayerThreeScore.Visibility = Visibility.Hidden;

            }
            else if (threePlayer)
            {
                tempPlayer.Number = 1;
                currentPlayerList.Add(tempPlayer);

                tempPlayer = new Player();
                tempPlayer.Number = 2;
                currentPlayerList.Add(tempPlayer);

                tempPlayer = new Player();
                tempPlayer.Number = 3;
                currentPlayerList.Add(tempPlayer);

                lblPlayerFour.Visibility = Visibility.Hidden;
                lblPlayerFourScore.Visibility = Visibility.Hidden;
            }
            else if (fourPlayer)
            {
                tempPlayer = new Player();
                tempPlayer.Number = 1;
                currentPlayerList.Add(tempPlayer);

                tempPlayer = new Player();
                tempPlayer.Number = 2;
                currentPlayerList.Add(tempPlayer);

                tempPlayer = new Player();
                tempPlayer.Number = 3;
                currentPlayerList.Add(tempPlayer);

                tempPlayer = new Player();
                tempPlayer.Number = 4;
                currentPlayerList.Add(tempPlayer);
            }

            lblPlayerInformation.Content = "Player " + currentPlayerList[0].Number + "'s Turn";

            currentPlayerList[0].ValidDice = true;
        }
    }
}
