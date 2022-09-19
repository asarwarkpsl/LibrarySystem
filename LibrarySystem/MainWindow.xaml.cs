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

namespace LibrarySystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnReplaceBooks_Click(object sender, RoutedEventArgs e)
        {
            ReplacingBooks frmReplaceBooks = new ReplacingBooks();
            frmReplaceBooks.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IdentifyAreas frmIdentifyAreas = new IdentifyAreas();
            frmIdentifyAreas.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Leadboard score = new Leadboard();
            List<Leadboard> scores = new List<Leadboard>();

            Dictionary<string, int> leadScore = new Dictionary<string, int> {
                { "John",7464 },
                {"Guest",7322 } ,
                {"Ivoy",6743 },
                {"Bandile",5543 },
                {"Guest1",4322 },
                {"Guest2",3399 },
                {"Siyabonga",2345 },
                {"Minenhle",1233 }
            };


            var shufflednames = leadScore.OrderBy(a => Guid.NewGuid()).ToList();
            shufflednames.Insert(0, new KeyValuePair<string, int>("Martin", 9323));

            // for (int i = 0; i < 8; i++)
            int i = 1;
           foreach(KeyValuePair<string,int> s in shufflednames)
            {
                Leadboard score = new Leadboard();

                score.serialNum = i++;

                score.Name = s.Key;

                score.scroe = s.Value;

                scores.Add(score);
            }

            foreach (Leadboard score in scores)
            {
                ListViewItem item = new ListViewItem();

                string s = score.Name.ToString().PadRight(120, ' ');
                item.Content = $"{score.serialNum}\t {s} {score.scroe}";

                lstLeadBoard.Items.Add(item);
            }

            ////////////
            ///

            Random rand = new Random();

            lblTotal.Content = rand.Next(1221, 9999);
            lblNew.Content = rand.Next(100, 999);
            lblProgress.Content = rand.Next(100, 999);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CustomMessageBox msgBox = new CustomMessageBox("You are about to Logout of the System, Are you Sure", MessageType.Info, MessageButtons.YesNo);

            if (msgBox.ShowDialog() == true)
                this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FindCallNumber frm = new FindCallNumber();
            frm.ShowDialog();
        }
    }

    public class Leadboard
    {
        public int serialNum { get; set; }
        public string Name { get;set; }
        public int scroe { get; set; }
    }
}
