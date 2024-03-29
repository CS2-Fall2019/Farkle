﻿//-----------------------------------------------------------------------
// <copyright file="Winner.xaml.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Farkle
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Media;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Shapes;

    /// <summary>
    /// Interaction logic for Winner.xaml
    /// </summary>
    public partial class Winner : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Winner" /> class.
        /// </summary>
        public Winner()
        {
            this.InitializeComponent();

            // Play the applause sound.
            Stream strApplause = Properties.Resources.applause;
            SoundPlayer sndApplause = new SoundPlayer(strApplause);
            sndApplause.Play();
        }

        /// <summary>
        /// Exit button click event.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">RoutedEventArgs e.</param>
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            // Close application.
            this.Close();
        }

        /// <summary>
        /// New Game button click event.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">RoutedEventArgs e.</param>
        private void BtnNewGame_Click(object sender, RoutedEventArgs e)
        {
            MainMenu newGame = new MainMenu();
            newGame.Show();

            this.Close();
        }
    }
}
