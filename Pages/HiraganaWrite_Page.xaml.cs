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
    /// Interakční logika pro HiraganaWrite_Page.xaml
    /// </summary>
    public partial class HiraganaWrite_Page : Page
    {
        public List<List_Type> hiragana_list = new List<List_Type>();
        public Hiragana_Writing HWrite = new Hiragana_Writing();

        public HiraganaWrite_Page()
        {
            InitializeComponent();

            Hiragana_Dict HDict = new Hiragana_Dict();
            hiragana_list = HDict.Hiragana();

            HWrite.HiraganaCharWrite(hiragana_list, GuessLabel, Meaning);
        }

        private void ShowBT_Click(object sender, RoutedEventArgs e)
        {
            HWrite.HiraganaWriteSwitch(GuessLabel, Meaning);
        }

        private void NextBT_Click(object sender, RoutedEventArgs e)
        {
            TrainingProgress.Value += 1;

            HWrite.HiraganaCharWrite(hiragana_list, GuessLabel, Meaning);
        }
    }
}
