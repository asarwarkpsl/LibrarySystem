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
using System.Windows.Shapes;

namespace LibrarySystem
{
    /// <summary>
    /// Interaction logic for ReplacingBooks.xaml
    /// </summary>
    public partial class IdentifyAreas : Window
    {
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

        public IdentifyAreas()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Generate random categories
            List<string> cats = new List<string>();

            cats.Add("Select Main Category here ...");

            while(cats.Count < 5)
            {
                string c = generateRandomCategoreis();
                if(!cats.Contains(c))
                    cats.Add(generateRandomCategoreis());
            }

            List<string> catDesc = new List<string>();

            catDesc.Add("Select Category Description here ...");

            for(int i=1;i<cats.Count;i++)
                catDesc.Add(deweyAreas[cats[i]]);

            //wrong answers
            List<string> temp=new List<string>();

            while (catDesc.Count < 8) //4 correct descriptions + 3 incorrect descriptions
            {
                string c = generateRandomCategoreis();

                if (!cats.Contains(c) && !temp.Contains(c))
                {
                    temp.Add(c);
                    catDesc.Add(deweyAreas[c]);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                //populate categories
                ComboBox categories = new ComboBox();
                categories.ItemsSource = cats;
                categories.SelectedIndex = 0;

                lstCategories.Items.Add(categories);

                //populate category Description

                ComboBox categoriesDesc = new ComboBox();
                categoriesDesc.ItemsSource = catDesc;
                categoriesDesc.SelectedIndex = 0;


                lstDescriptions.Items.Add(categoriesDesc);
            }
        }

        private string generateRandomCategoreis()
        {
            Random random = new Random();

            int mainCategory = random.Next(0, 900);

            while(mainCategory % 100 != 0)
                mainCategory = random.Next(0, 900);

            return mainCategory.ToString().PadRight(3, '0');
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            foreach (ComboBox items in lstCategories.Items)
                items.SelectedIndex = 0;

            foreach (ComboBox items in lstDescriptions.Items)
                items.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnValidate_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, string> userMatching = new Dictionary<string, string>();
            Dictionary<string, string> correctMatching = new Dictionary<string, string>();


            for (int i = 0; i < 4; i++)
            {
                ComboBox cat = lstCategories.Items[i] as ComboBox;
                if (cat.SelectedIndex == 0)
                {
                    MessageBox.Show("select category");
                    return;
                }
                string c = cat.SelectedItem.ToString().Trim();

                ComboBox catDesc = lstDescriptions.Items[i] as ComboBox;

                if(catDesc.SelectedIndex == 0)
                {
                    MessageBox.Show("select description");
                    return;
                }

                string d = catDesc.SelectedItem.ToString().Trim();

                if (userMatching.ContainsKey(c))
                {
                    MessageBox.Show("multiple keys");
                    return;
                }
                userMatching.Add(c, d);

                //get correct list from dewey lsit

                correctMatching.Add(c, deweyAreas[c]);
            }



            if (correctMatching.SequenceEqual(userMatching))
            {
                  MessageBox.Show("Greate work done");
            }
            else
                MessageBox.Show("Try Again");

        }
    }
}
