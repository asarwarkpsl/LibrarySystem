using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LibrarySystem
{
    /// <summary>
    /// Interaction logic for FindCallNumber.xaml
    /// </summary>
    public partial class FindCallNumber : Window
    {
        List<deweyData> data = null;
        List<QuizQuestion> allQuestions;
        int questionIndex = 0;

        Dictionary<string, string> deweyAreas = new Dictionary<string, string>()
                                                    {
                                                        {"000","Computer science, information and general works"},
                                                        {"100","Philosophy and psychology"},
                                                        {"200","Religion"},
                                                        {"300","Social sciences"},
                                                        {"400","Language"},
                                                        {"500","Science"},
                                                        {"600","Technology"},
                                                        {"700","Arts and recreation"},
                                                        {"800","Literature"},
                                                        {"900","History and geography"}
                                                    };
        public FindCallNumber()
        {
            InitializeComponent();
            loadFile();
            LoadQuestions();
            LoadNextQuestion();
        }

        private void loadFile()
        {
            string fileName = "data.json";
            string jsonString = File.ReadAllText(fileName);
            data = JsonSerializer.Deserialize<List<deweyData>>(jsonString);

            foreach (var v in data)
            {
                foreach (books book in v.books)
                {
                    Console.WriteLine($"Summary: {book.code}");
                    Console.WriteLine($"Summary: {book.name}");
                }
            }


            //foreach (var v in data)
            //{
            //    Console.WriteLine($"Date: {v.code}");
            //    Console.WriteLine($"TemperatureCelsius: {v.name}");

            //    foreach (books book in v.books)
            //    {
            //        Console.WriteLine($"Summary: {book.code}");
            //        Console.WriteLine($"Summary: {book.name}");
            //    }
            //}
        }

        private void LoadNextQuestion()
        {
            if (allQuestions == null) return;

            QuizQuestion q = allQuestions[questionIndex];
            lblQuestion.Tag = q.QuestionCode;

            lblQuestion.Content = $"The Call Number: {q.QuestionCode} belongs to which main category ?";

            lstOptions.Items.Clear();

            foreach (var v in q.QuestOptions)
            {
                RadioButton opt = new RadioButton();
                opt.Content = v;

                lstOptions.Items.Add(opt);
            }
        }
        private void LoadQuestions()
        {
            // var shufflednames = leadScore.OrderBy(a => Guid.NewGuid()).ToList();
            var books = from d in data
                        select d.books;

            var shufflebooks = books.OrderBy(a => Guid.NewGuid()).ToList();

            List<QuizQuestion> quizQuestions = new List<QuizQuestion>();

            //foreach (List<books> b in shufflebooks)
            for(int i=0;i<shufflebooks.Count;i++)
            {
                List<books> b = shufflebooks[i];

                string bookCode = b.First().code;


                int categoryCodei = (int)(int.Parse(bookCode)) / 100;


                int categoryCode = categoryCodei * 100;

                //Correct option
                string questOption = $"{categoryCode.ToString()} ( {deweyAreas[categoryCode.ToString()]} )";

                QuizQuestion question = new QuizQuestion();

                question.QuestionCode = categoryCode.ToString();
                question.QuestOptions = new List<string>();
                question.QuestOptions.Add(questOption);


                //False option
                for (int ii = 0; ii < 3; ii++)
                {

                    do
                    {
                        Random rand = new Random();

                        int c = rand.Next(0, 10);

                        categoryCodei = c;

                        categoryCode = categoryCodei * 100;
                    }
                    while (question.QuestOptions.Any(cc => cc.ToString().Contains(categoryCode.ToString())));

                    questOption = $"{categoryCode.ToString()} ( {deweyAreas[categoryCode.ToString()]} )";

                    question.QuestOptions.Add(questOption);                  

                }

                //var shuffleOptions = question.QuestOptions.OrderBy(a => Guid.NewGuid()).ToList();
                question.QuestOptions = question.QuestOptions.OrderBy(a => Guid.NewGuid()).ToList();

                if (allQuestions == null)
                    allQuestions = new List<QuizQuestion>();

                allQuestions.Add(question);
            }
        }

        private void btnPreviousQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (questionIndex <= 0) return;

            --questionIndex;

            LoadNextQuestion();
        }

        private void btnNextQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (questionIndex == allQuestions.Count-1) return;

            ++questionIndex;

           


            LoadNextQuestion();
        }

        private void btnVerifyAns_Click(object sender, RoutedEventArgs e)
        {
            bool isOptCheck = false;

            foreach (var v in lstOptions.Items)
            {
                RadioButton opt = v as RadioButton;

                if (opt.IsChecked == false) continue;

                isOptCheck = true;

                string selectedOptCatCode = opt.Content.ToString();

                if (!selectedOptCatCode.Substring(0, selectedOptCatCode.IndexOf(' ')).Equals(lblQuestion.Tag.ToString()))
                    opt.Background = Brushes.Red;
                else
                    opt.Background = Brushes.LightGreen;

                break;
            }

            if(isOptCheck != true)
            {
                CustomMessageBox msgBox = new CustomMessageBox("Select any answere to verify", MessageType.Error, MessageButtons.Ok);
                msgBox.ShowDialog();
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            questionIndex = 0;

            LoadNextQuestion();
        }
    }

    public class deweyData
    {
        public string code { get; set; }
        public string name { get; set; }
        public List<books> books { get; set; }
    }

    public class books
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class QuizQuestion
    {
        public string  QuestionCode{ get; set; }
        public List<string> QuestOptions{ get; set; }
    }
}
