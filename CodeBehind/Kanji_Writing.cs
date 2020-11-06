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
using Nihon_Trainee.Dictionary;
using Nihon_Trainee.CodeBehind;

namespace Nihon_Trainee.CodeBehind
{
    public class Kanji_Writing
    {
        public void KanjiCharWrite(List<Kanji_Type> kanji_list, Label GuessLabel, Label Meaning, Label Trans)
        {
            Random rnd = new Random();
            int kanjiInt = rnd.Next(kanji_list.Count);

            GuessLabel.Content = kanji_list[kanjiInt].Romaji;
            Meaning.Content = kanji_list[kanjiInt].Character;
            Trans.Content = kanji_list[kanjiInt].Trans;

            Meaning.Background = Brushes.Black;
        }

        public void KanjiWriteSwitch(Label GuessLabel, Label Meaning)
        {
            string guessLabel = GuessLabel.Content.ToString();
            string meaning = Meaning.Content.ToString();

            GuessLabel.Content = meaning;
            Meaning.Content = guessLabel;

            Meaning.Background = Brushes.White;
        }
    }
}
