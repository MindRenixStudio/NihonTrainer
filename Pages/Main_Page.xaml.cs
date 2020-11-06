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
using Nihon_Trainee.Pages;

namespace Nihon_Trainee.Pages
{
    /// <summary>
    /// Interakční logika pro Main_Page.xaml
    /// </summary>
    public partial class Main_Page : Page
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void Hiragana_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/Hiragana_Page.xaml", UriKind.Relative));
        }
        private void Katakana_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/Katakana_Page.xaml", UriKind.Relative));
        }
        private void Kanji_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/Kanji_Page.xaml", UriKind.Relative));
        }
        private void Writing_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/WriteSelect_Page.xaml", UriKind.Relative));
        }
        private void More_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/VocabularyMain_Page.xaml", UriKind.Relative));
        }
    }
}
