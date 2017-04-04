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

namespace WPFSliderDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Animal elukka;
        public MainWindow()
        {
            InitializeComponent();
            //Omat alustukset 
            elukka = new WPFSliderDemo.Animal();
            elukka.Name = "Musti";
            elukka.Happiness = 10;
            myProgressBar.DataContext = elukka;
            tbAnimal.DataContext = elukka;

        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            // TODO lisätään olio Happiness-ominaistuutta
            Animal olio = (Animal) myProgressBar.DataContext;
            olio.Happiness++;
            
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            //luodaan toinen elukka
            Animal kisu = new Animal();
            kisu.Name = "Kitu";
            kisu.Happiness = 50;
            myProgressBar.DataContext = kisu;
            tbAnimal.DataContext = kisu;
        }
    }
}
