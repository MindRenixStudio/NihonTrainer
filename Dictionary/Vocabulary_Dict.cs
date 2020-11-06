using System;
using System.Collections.Generic;
using System.Text;

namespace Nihon_Trainee.Dictionary
{
    public class Vocabulary_Dict
    {
        public List<Dictionary_Type> GreetingsVocab()
        {
            List<Dictionary_Type> Vocab1 = new List<Dictionary_Type>();

            Vocab1.Add(new Dictionary_Type { JapWord = "おはようございます", Romaji = "Ohayou gozaimasu", Trans = "Good morning" });
            Vocab1.Add(new Dictionary_Type { JapWord = "こんにちは", Romaji = "Konnichiwa", Trans = "Hello" });
            Vocab1.Add(new Dictionary_Type { JapWord = "こんばんは", Romaji = "Konbanwa", Trans = "Good evening" });
            Vocab1.Add(new Dictionary_Type { JapWord = "おやすみなさい", Romaji = "Oyasuminasai", Trans = "Goodnight" });
            Vocab1.Add(new Dictionary_Type { JapWord = "ありがとうございます", Romaji = "Arigatou gozaimasu", Trans = "Thank you" });
            Vocab1.Add(new Dictionary_Type { JapWord = "すみません", Romaji = "Sumimasen", Trans = "Excuse me" });
            Vocab1.Add(new Dictionary_Type { JapWord = "ごめんなさい", Romaji = "Gomennasai", Trans = "Sorry" });
            Vocab1.Add(new Dictionary_Type { JapWord = "はい", Romaji = "Hai", Trans = "Yes" });
            Vocab1.Add(new Dictionary_Type { JapWord = "いいえ", Romaji = "Iie", Trans = "No" });

            return Vocab1;
        }

        public List<Dictionary_Type> FamilyVocab()
        {
            List<Dictionary_Type> Vocab2 = new List<Dictionary_Type>();

            Vocab2.Add(new Dictionary_Type { JapWord = "わたし", Romaji = "Watashi", Trans = "I / Me" });
            Vocab2.Add(new Dictionary_Type { JapWord = "あなた", Romaji = "Anata", Trans = "You" });
            Vocab2.Add(new Dictionary_Type { JapWord = "おかあさん", Romaji = "Okaasan", Trans = "Mother" });
            Vocab2.Add(new Dictionary_Type { JapWord = "おとうさん", Romaji = "Otousan", Trans = "Father" });
            Vocab2.Add(new Dictionary_Type { JapWord = "おじいさん", Romaji = "Ojiisan", Trans = "Grandfather" });
            Vocab2.Add(new Dictionary_Type { JapWord = "おばあさん", Romaji = "Obaasan", Trans = "Grandmother" });
            Vocab2.Add(new Dictionary_Type { JapWord = "おじさん", Romaji = "Ojisan", Trans = "Uncle" });
            Vocab2.Add(new Dictionary_Type { JapWord = "おばさん", Romaji = "Obasan", Trans = "Aunt" });
            Vocab2.Add(new Dictionary_Type { JapWord = "おにいさん", Romaji = "Oniisan", Trans = "Older brother" });
            Vocab2.Add(new Dictionary_Type { JapWord = "おねえさん", Romaji = "Oneesan", Trans = "Older sister" });
            Vocab2.Add(new Dictionary_Type { JapWord = "おとうと", Romaji = "Otouto", Trans = "Younger brother" });
            Vocab2.Add(new Dictionary_Type { JapWord = "いもうと", Romaji = "Imouto", Trans = "Younger sister" });

            return Vocab2;
        }

        public List<Dictionary_Type> NumbersVocab()
        {
            List<Dictionary_Type> Vocab3 = new List<Dictionary_Type>();

            Vocab3.Add(new Dictionary_Type { JapWord = "いち", Romaji = "Ichi", Trans = "One" });
            Vocab3.Add(new Dictionary_Type { JapWord = "に", Romaji = "Ni", Trans = "Two" });
            Vocab3.Add(new Dictionary_Type { JapWord = "さん", Romaji = "San", Trans = "Three" });
            Vocab3.Add(new Dictionary_Type { JapWord = "よん", Romaji = "Yon", Trans = "Four" });
            Vocab3.Add(new Dictionary_Type { JapWord = "ご", Romaji = "Go", Trans = "Five" });
            Vocab3.Add(new Dictionary_Type { JapWord = "ろく", Romaji = "Roku", Trans = "Six" });
            Vocab3.Add(new Dictionary_Type { JapWord = "なな", Romaji = "Nana", Trans = "Seven" });
            Vocab3.Add(new Dictionary_Type { JapWord = "はち", Romaji = "Hachi", Trans = "Eight" });
            Vocab3.Add(new Dictionary_Type { JapWord = "きゅう", Romaji = "Kyuu", Trans = "Nine" });
            Vocab3.Add(new Dictionary_Type { JapWord = "じゅう", Romaji = "Juu", Trans = "Ten" });

            return Vocab3;
        }

        public List<Dictionary_Type> MonthsVocab()
        {
            List<Dictionary_Type> Vocab4 = new List<Dictionary_Type>();

            Vocab4.Add(new Dictionary_Type { JapWord = "いちがつ", Romaji = "Ichigatsu", Trans = "January" });
            Vocab4.Add(new Dictionary_Type { JapWord = "にがつ", Romaji = "Nigatsu", Trans = "February" });
            Vocab4.Add(new Dictionary_Type { JapWord = "さんがつ", Romaji = "Sangatsu", Trans = "March" });
            Vocab4.Add(new Dictionary_Type { JapWord = "しがつ", Romaji = "Shigatsu", Trans = "April" });
            Vocab4.Add(new Dictionary_Type { JapWord = "ごがつ", Romaji = "Gogatsu", Trans = "May" });
            Vocab4.Add(new Dictionary_Type { JapWord = "ろくがつ", Romaji = "Rokugatsu", Trans = "June" });
            Vocab4.Add(new Dictionary_Type { JapWord = "しちがつ", Romaji = "Shichigatsu", Trans = "July" });
            Vocab4.Add(new Dictionary_Type { JapWord = "はちがつ", Romaji = "Hachigatsu", Trans = "August" });
            Vocab4.Add(new Dictionary_Type { JapWord = "くがつ", Romaji = "Kugatsu", Trans = "September" });
            Vocab4.Add(new Dictionary_Type { JapWord = "じゅうがつ", Romaji = "Juugatsu", Trans = "October" });
            Vocab4.Add(new Dictionary_Type { JapWord = "じゅういちがつ", Romaji = "Juuichigatsu", Trans = "November" });
            Vocab4.Add(new Dictionary_Type { JapWord = "じゅうにがつ", Romaji = "Juunigatsu", Trans = "December" });
            
            return Vocab4;
        }

        public List<Dictionary_Type> TimeVocab()
        {
            List<Dictionary_Type> Vocab5 = new List<Dictionary_Type>();

            Vocab5.Add(new Dictionary_Type { JapWord = "げつようび", Romaji = "Getsuyoubi", Trans = "Monday" });
            Vocab5.Add(new Dictionary_Type { JapWord = "かようび", Romaji = "Kayoubi", Trans = "Tuesday" });
            Vocab5.Add(new Dictionary_Type { JapWord = "すいようび", Romaji = "Suiyoubi", Trans = "Wednesday" });
            Vocab5.Add(new Dictionary_Type { JapWord = "もくようび", Romaji = "Mokuyoubi", Trans = "Thursday" });
            Vocab5.Add(new Dictionary_Type { JapWord = "きんようび", Romaji = "Kinyoubi", Trans = "Friday" });
            Vocab5.Add(new Dictionary_Type { JapWord = "どようび", Romaji = "Doyoubi", Trans = "Saturday" });
            Vocab5.Add(new Dictionary_Type { JapWord = "にちようび", Romaji = "Nichiyoubi", Trans = "Sunday" });
            Vocab5.Add(new Dictionary_Type { JapWord = "きのう", Romaji = "Kinou", Trans = "Yesterday" });
            Vocab5.Add(new Dictionary_Type { JapWord = "きょう", Romaji = "Kyou", Trans = "Today" });
            Vocab5.Add(new Dictionary_Type { JapWord = "あした", Romaji = "Ashita", Trans = "Tomorrow" });
            Vocab5.Add(new Dictionary_Type { JapWord = "あさ", Romaji = "Asa", Trans = "Morning" });
            Vocab5.Add(new Dictionary_Type { JapWord = "ひる", Romaji = "Hiru", Trans = "Noon" });
            Vocab5.Add(new Dictionary_Type { JapWord = "ゆうがた", Romaji = "Yuugata", Trans = "Evening" });
            Vocab5.Add(new Dictionary_Type { JapWord = "よる", Romaji = "Yoru", Trans = "Night" });

            return Vocab5;
        }

        public List<Dictionary_Type> AdjectivesVocab()
        {
            List<Dictionary_Type> Vocab6 = new List<Dictionary_Type>();

            Vocab6.Add(new Dictionary_Type { JapWord = "たのしい", Romaji = "Tanoshii", Trans = "Happy" });
            Vocab6.Add(new Dictionary_Type { JapWord = "かなしい", Romaji = "Kanashii", Trans = "Sad" });
            Vocab6.Add(new Dictionary_Type { JapWord = "たかい", Romaji = "Takai", Trans = "Expensive" });
            Vocab6.Add(new Dictionary_Type { JapWord = "ひくい", Romaji = "Hikui", Trans = "Low" });
            Vocab6.Add(new Dictionary_Type { JapWord = "やすい", Romaji = "Yasui", Trans = "Cheap" });
            Vocab6.Add(new Dictionary_Type { JapWord = "はやい", Romaji = "Hayai", Trans = "Fast / early" });
            Vocab6.Add(new Dictionary_Type { JapWord = "おそい", Romaji = "Osoi", Trans = "Slow" });
            Vocab6.Add(new Dictionary_Type { JapWord = "いそがしい", Romaji = "Isogashii", Trans = "Busy" });
            Vocab6.Add(new Dictionary_Type { JapWord = "おいしい", Romaji = "Oishii", Trans = "Delicious" });
            Vocab6.Add(new Dictionary_Type { JapWord = "まずい", Romaji = "Mazui", Trans = "Awful" });
            Vocab6.Add(new Dictionary_Type { JapWord = "あまい", Romaji = "Amai", Trans = "Sweet" });
            Vocab6.Add(new Dictionary_Type { JapWord = "しょっぱい", Romaji = "Shoppai", Trans = "Salty" });
            Vocab6.Add(new Dictionary_Type { JapWord = "すっぱい", Romaji = "Suppai", Trans = "Sour" });
            Vocab6.Add(new Dictionary_Type { JapWord = "にがい", Romaji = "Nigai", Trans = "Bitter" });
            Vocab6.Add(new Dictionary_Type { JapWord = "からい", Romaji = "Karai", Trans = "Hot / spicy" });
            Vocab6.Add(new Dictionary_Type { JapWord = "あつい", Romaji = "Atsui", Trans = "Hot" });
            Vocab6.Add(new Dictionary_Type { JapWord = "あたたかい", Romaji = "Atatakai", Trans = "Warm" });
            Vocab6.Add(new Dictionary_Type { JapWord = "つめたい", Romaji = "Tsumetai", Trans = "Cold" });
            Vocab6.Add(new Dictionary_Type { JapWord = "あかるい", Romaji = "Akarui", Trans = "Bright" });
            Vocab6.Add(new Dictionary_Type { JapWord = "くらい", Romaji = "Kurai", Trans = "Dark" });

            return Vocab6;
        }

        public List<Dictionary_Type> VerbsVocab()
        {
            List<Dictionary_Type> Vocab7 = new List<Dictionary_Type>();

            Vocab7.Add(new Dictionary_Type { JapWord = "する", Romaji = "Suru", Trans = "To do" });
            Vocab7.Add(new Dictionary_Type { JapWord = "みる", Romaji = "Miru", Trans = "To see" });
            Vocab7.Add(new Dictionary_Type { JapWord = "きく", Romaji = "Kiku", Trans = "To listen" });
            Vocab7.Add(new Dictionary_Type { JapWord = "はなす", Romaji = "Hanasu", Trans = "To talk / speak" });
            Vocab7.Add(new Dictionary_Type { JapWord = "いう", Romaji = "Iu", Trans = "To say" });
            Vocab7.Add(new Dictionary_Type { JapWord = "かく", Romaji = "Kaku", Trans = "To write" });
            Vocab7.Add(new Dictionary_Type { JapWord = "たべる", Romaji = "Taberu", Trans = "To eat" });
            Vocab7.Add(new Dictionary_Type { JapWord = "のむ", Romaji = "Nomu", Trans = "To drink" });
            Vocab7.Add(new Dictionary_Type { JapWord = "あるく", Romaji = "Aruko", Trans = "To walk" });
            Vocab7.Add(new Dictionary_Type { JapWord = "はしる", Romaji = "Hashiru", Trans = "To run" });
            Vocab7.Add(new Dictionary_Type { JapWord = "すわる", Romaji = "Suwaru", Trans = "To sit" });
            Vocab7.Add(new Dictionary_Type { JapWord = "たつ", Romaji = "Tatsu", Trans = "To stand" });

            return Vocab7;
        }

        public List<Dictionary_Type> FoodVocab()
        {
            List<Dictionary_Type> Vocab8 = new List<Dictionary_Type>();

            Vocab8.Add(new Dictionary_Type { JapWord = "たべもの", Romaji = "Tabemono", Trans = "Food" });
            Vocab8.Add(new Dictionary_Type { JapWord = "のみもの", Romaji = "Nomimono", Trans = "Drinks" });
            Vocab8.Add(new Dictionary_Type { JapWord = "ごはん", Romaji = "Gohan", Trans = "Rice / meal" });
            Vocab8.Add(new Dictionary_Type { JapWord = "みず", Romaji = "Mizu", Trans = "Water" });
            Vocab8.Add(new Dictionary_Type { JapWord = "おゆ", Romaji = "Oyu", Trans = "Hot water" });
            Vocab8.Add(new Dictionary_Type { JapWord = "にく", Romaji = "Niku", Trans = "Meat" });
            Vocab8.Add(new Dictionary_Type { JapWord = "やさい", Romaji = "Yasai", Trans = "Vegetable" });
            Vocab8.Add(new Dictionary_Type { JapWord = "さかな", Romaji = "Sakana", Trans = "Fish" });
            Vocab8.Add(new Dictionary_Type { JapWord = "ラーメン", Romaji = "Ramen", Trans = "Ramen" });
            Vocab8.Add(new Dictionary_Type { JapWord = "すし", Romaji = "Sushi", Trans = "Sushi" });
            Vocab8.Add(new Dictionary_Type { JapWord = "おにぎり", Romaji = "Onigiri", Trans = "Onigiri" });

            return Vocab8;
        }
    }
}
