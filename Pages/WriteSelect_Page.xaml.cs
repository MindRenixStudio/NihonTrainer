using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nihon_Trainee.Pages
{
    /// <summary>
    /// Interakční logika pro WriteSelect_Page.xaml
    /// </summary>
    public partial class WriteSelect_Page : Page
    {
        public WriteSelect_Page()
        {
            InitializeComponent();
        }

        private void Hiragana_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/HiraganaWrite_Page.xaml", UriKind.Relative));
        }

        private void Katakana_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/KatakanaWrite_Page.xaml", UriKind.Relative));
        }

        private void Kanji_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/KanjiWrite_Page.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
