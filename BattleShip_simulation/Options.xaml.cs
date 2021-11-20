﻿using System;
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

namespace BattleShip_simulation
{
    /// <summary>
    /// Logika interakcji dla klasy Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public string OriginalText { get; private set; }
        public Options()
        {
            InitializeComponent();
            SizeOptions.SelectedIndex = 2;
            OriginalText = MapSize.Text;
        }

        internal int SizeChange()
        {

            SizeOptions.ItemsSource = new List<int>()
            {
                { 10},
                { 20},
                { 25},
                { 30}
            };

            return Convert.ToInt32(SizeOptions.Text);
        }

        private void Appr_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                MapSize.Text = $"{OriginalText} {SizeChange()}";
                GameSettings.size = SizeChange();
            }));

        }
    }
}

