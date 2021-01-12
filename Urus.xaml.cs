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
using System.Windows.Shapes;

namespace Lamborghini_App
{
    /// <summary>
    /// Interaction logic for Urus.xaml
    /// </summary>
    public partial class Urus : Window
    {
        public Urus()
        {
            InitializeComponent();
        }

        int total = 0;

        int fuelTotal = 0;
        int tireTotal = 0;
        int leatherTotal = 0;

        private void SetTotal()
        {
            total = fuelTotal + tireTotal + leatherTotal;


            if (TotalUrus != null)
            {
                TotalUrus.Text = $"Total: $ {total}".Insert(12, ",");
            }
        }

        //Color Customization
        private void UrusWhite_Click(object sender, RoutedEventArgs e)
        {
            UrusPicture.Source = new BitmapImage(new Uri(@"Resources\CarColors\UrusWhite.png", UriKind.Relative));
        }
        private void UrusYellow_Click(object sender, RoutedEventArgs e)
        {
            UrusPicture.Source = new BitmapImage(new Uri(@"Resources\CarColors\UrusYellow.png", UriKind.Relative));
        }

        private void UrusBlue_Click(object sender, RoutedEventArgs e)
        {
            UrusPicture.Source = new BitmapImage(new Uri(@"Resources\CarColors\UrusRed.png", UriKind.Relative));
        }

        private void UrusBlack_Click(object sender, RoutedEventArgs e)
        {
            UrusPicture.Source = new BitmapImage(new Uri(@"Resources\CarColors\UrusBlack.png", UriKind.Relative));
        }

        //Fuel Total Counter
        private void TotalUrus_Loaded(object sender, RoutedEventArgs e)
        {
            SetTotal();
        }

        private void Gascar_Checked(object sender, RoutedEventArgs e)
        {
            fuelTotal = 229428;
            SetTotal();
        }

        private void ElcerticCar_Checked(object sender, RoutedEventArgs e)
        {
            fuelTotal = 340160;
            SetTotal();
        }


        //Tire Total Counter
        private void Tire1RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tireTotal = 990;
            SetTotal();
        }

        private void Tire2RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tireTotal = 850;
            SetTotal();
        }

        private void Tire3RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tireTotal = 690;
            SetTotal();
        }

        private void Tire4RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tireTotal = 580;
            SetTotal();
        }


        //Leather Total Counter
        private void WhiteLeatherRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            leatherTotal = 290;
            SetTotal();
        }

        private void BlueLeatherRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            leatherTotal = 420;
            SetTotal();
        }

        private void RedLeatherRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            leatherTotal = 399;
            SetTotal();
        }

        private void BlackLeatherRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            leatherTotal = 990;
            SetTotal();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            Selection selection = new Selection();
            selection.Show();
        }
        private void ButtonX_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
        private void Finalization_Button_Click(object sender, RoutedEventArgs e)
        {
            Summary summary = new Summary();
            summary.Show();
        }
    }
}
