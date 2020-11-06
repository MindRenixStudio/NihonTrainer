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
    /// Interakční logika pro VocabularyMain_Page.xaml
    /// </summary>
    public partial class VocabularyMain_Page : Page
    {
        public VocabularyMain_Page()
        {
            InitializeComponent();
        }

        private void Greetings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/VocabularyGreeting_Page.xaml", UriKind.Relative));
        }

        private void From_Main_Page_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
