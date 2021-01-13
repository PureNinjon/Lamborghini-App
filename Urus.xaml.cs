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
using System.Windows.Shapes;
using System.IO;

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

        public void OutputMaker()
        {
            List<string> output = new List<string>();
            output.Add($"{CarData};{FuelData};{TireData};{LeatherData};{PriceData}");

            string filepath = @"C:\Users\Krisz\Desktop\Lamborghini Customization\Lamborghini App\Resources\FinalData.txt";
            File.WriteAllLines(filepath, output);
        }



        int total = 0;

        int fuelTotal = 0;
        int tireTotal = 0;
        int leatherTotal = 0;

        string CarData = @"Resources\CarColors\UrusWhite.png";
        string FuelData;
        string TireData;
        string LeatherData = @"Resources\Leathers\WhiteLeather.png";
        string PriceData;
        

        private void SetTotal()
        {
            total = fuelTotal + tireTotal + leatherTotal;


            if (TotalUrus != null)
            {
                TotalUrus.Text = $"Total: $ {total}".Insert(12, ",");
            }

            PriceData = TotalUrus.Text;
        }

        //Color Customization
        private void UrusWhite_Click(object sender, RoutedEventArgs e)
        {
            UrusPicture.Source = new BitmapImage(new Uri(@"Resources\CarColors\UrusWhite.png", UriKind.Relative));
            CarData = @"Resources\CarColors\UrusWhite.png";
            OutputMaker();

        }
        private void UrusYellow_Click(object sender, RoutedEventArgs e)
        {
            UrusPicture.Source = new BitmapImage(new Uri(@"Resources\CarColors\UrusYellow.png", UriKind.Relative));
            CarData = @"Resources\CarColors\UrusYellow.png";
            OutputMaker();
        }

        private void UrusBlue_Click(object sender, RoutedEventArgs e)
        {
            UrusPicture.Source = new BitmapImage(new Uri(@"Resources\CarColors\UrusRed.png", UriKind.Relative));
            CarData = @"Resources\CarColors\UrusRed.png";
            OutputMaker();
        }

        private void UrusBlack_Click(object sender, RoutedEventArgs e)
        {
            UrusPicture.Source = new BitmapImage(new Uri(@"Resources\CarColors\UrusBlack.png", UriKind.Relative));
            CarData = @"Resources\CarColors\UrusBlack.png";
            OutputMaker();
        }

        //Fuel Total Counter
        private void TotalUrus_Loaded(object sender, RoutedEventArgs e)
        {
            SetTotal();
        }

        private void GasCar_Checked(object sender, RoutedEventArgs e)
        {
            fuelTotal = 249615;
            SetTotal();
            FuelData = GasCar.Content.ToString();
            OutputMaker();

        }

        private void ElcerticCar_Checked(object sender, RoutedEventArgs e)
        {
            fuelTotal = 323480;
            SetTotal();
            FuelData = ElectricCar.Content.ToString();
            OutputMaker();

        }

        //Tire Total Counter
        private void Tire1RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tireTotal = 233;
            SetTotal();
            TireData = Tire1RadioButton.Content.ToString();
            OutputMaker();
        }

        private void Tire2RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tireTotal = 749;
            SetTotal();
            TireData = Tire2RadioButton.Content.ToString();
            OutputMaker();


        }

        private void Tire3RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tireTotal = 666;
            SetTotal();
            TireData = Tire3RadioButton.Content.ToString();
            OutputMaker();


        }

        private void Tire4RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tireTotal = 577;
            SetTotal();
            TireData = Tire4RadioButton.Content.ToString();
            OutputMaker();


        }


        //Leather Total Counter
        private void WhiteLeatherRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            leatherTotal = 222;
            SetTotal();

            if(WhiteLeatherRadioButton.Content!=null) LeatherData = WhiteLeatherRadioButton.Content.ToString();
            OutputMaker();

        }

        private void BlueLeatherRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            leatherTotal = 421;
            SetTotal();
            LeatherData = BlueLeatherRadioButton.Content.ToString();
            OutputMaker();

        }

        private void RedLeatherRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            leatherTotal = 499;
            SetTotal();
            LeatherData = RedLeatherRadioButton.Content.ToString();
            OutputMaker();

        }

        private void BlackLeatherRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            leatherTotal = 999;
            SetTotal();
            LeatherData = BlackLeatherRadioButton.Content.ToString();
            OutputMaker();


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
            OutputMaker();
            
        }

    }
}
