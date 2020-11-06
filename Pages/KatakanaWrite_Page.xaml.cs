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
using Nihon_Trainee.CodeBehind;
using Nihon_Trainee.Dictionary;

namespace Nihon_Trainee.Pages
{
    /// <summary>
    /// Interakční logika pro KatakanaWrite_Page.xaml
    /// </summary>
    public partial class KatakanaWrite_Page : Page
    {
        public List<List_Type> katakana_list = new List<List_Type>();
        public Katakana_Writing KWrite = new Katakana_Writing();

        public KatakanaWrite_Page()
        {
            InitializeComponent();

            Katakana_Dict KDict = new Katakana_Dict();
            katakana_list = KDict.Katakana();

            KWrite.KatakanaCharWrite(katakana_list, GuessLabel, Meaning);
        }
        private void ShowBT_Click(object sender, RoutedEventArgs e)
        {
            KWrite.KatakanaWriteSwitch(GuessLabel, Meaning);
        }

        private void NextBT_Click(object sender, RoutedEventArgs e)
        {
            TrainingProgress.Value += 1;

            KWrite.KatakanaCharWrite(katakana_list, GuessLabel, Meaning);
        }
    }
}
