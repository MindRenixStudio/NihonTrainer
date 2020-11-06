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
    /// Interakční logika pro KanjiWrite_Page.xaml
    /// </summary>
    public partial class KanjiWrite_Page : Page
    {
        public List<Kanji_Type> kanji_list = new List<Kanji_Type>();
        public Kanji_Writing KaWrite = new Kanji_Writing();

        public KanjiWrite_Page()
        {
            InitializeComponent();

            Kanji_Dict KaDict = new Kanji_Dict();
            kanji_list = KaDict.Kanji();

            KaWrite.KanjiCharWrite(kanji_list, GuessLabel, Meaning, Trans);
        }
        private void ShowBT_Click(object sender, RoutedEventArgs e)
        {
            KaWrite.KanjiWriteSwitch(GuessLabel, Meaning);
        }

        private void NextBT_Click(object sender, RoutedEventArgs e)
        {
            TrainingProgress.Value += 1;

            KaWrite.KanjiCharWrite(kanji_list, GuessLabel, Meaning, Trans);
        }
    }
}
