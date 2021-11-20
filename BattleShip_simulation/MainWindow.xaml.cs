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
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    /// check changes
    static class GameSettings
    {
        internal static Options GameOptions = new Options();
        internal static readonly bool[,] Rects = new bool[10, 10];
        internal static int size = GameOptions.SizeChange();
        internal static readonly int space = 2;
        internal static bool GameOver = false;
        internal static int AmountOfShips = 0;
        internal static List<int> PlayerGame = new List<int>()
        {{0 },{0 }};
        internal static List<string> IsHit = new List<string>()
        {{""},{""}};
    }

public partial class MainWindow : Window
    {
        Player1 pl1 = new Player1();
        Player2 pl2 = new Player2();
        GameBegin begin = new GameBegin();
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void GameStart_Click(object sender, RoutedEventArgs e)
        {
            PlayerAndGraficsSetting();
            ShowBoards();
            Close();
            await Task.WhenAll(Game());
        }
        private void PlayerAndGraficsSetting()
        {
            pl1.GameBegin();
            pl2.GameBegin();
        }
        private void ShowBoards()
        {
            pl1.Show();
            pl2.Show();
        }
        private async Task Game()
        {
            Close();
            await Task.Run(() =>
            {
                while (GameSettings.GameOver == false)
                    begin.Game
                    (
                        pl1.PlayerChoosing(GameSettings.AmountOfShips),
                        pl2.PlayerChoosing(GameSettings.AmountOfShips)
                    );

            });
        }
        private void Options_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GameSettings.GameOptions.Show();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
