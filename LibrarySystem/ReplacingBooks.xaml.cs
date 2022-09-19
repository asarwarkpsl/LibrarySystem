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
    public partial class ReplacingBooks : Window
    {
        List<string> userSortedList = new List<string>();
        List<string> sortedList = new List<string>();

        public ReplacingBooks()
        {
            InitializeComponent();
        }

      
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Generate 10 different call numbers, store them in the list

            List<string> callNumbers = new List<string>();

            while(callNumbers.Count < 10)
            {
                string str = generateRandomCallNumbers();

                if(!callNumbers.Contains(str))
                    callNumbers.Add(str);

            }

            sortedList = callNumbers.ToList();
            sortedList.Sort();

            lstAvailableBooks.ItemsSource = callNumbers;
        }

        private string generateRandomCallNumbers()
        {
            Random random = new Random();

            int mainCategory = random.Next(0, 999);
            int subCategoryRand = random.Next(0, 999);

            StringBuilder callNumber = new StringBuilder();

            callNumber.Append(mainCategory.ToString().PadLeft(3, '0'))
                        .Append(".")
                        .Append(subCategoryRand.ToString())//.PadLeft(3, '0'))
                        .Append(" ")
                        .Append(GenerateRandomName());


            return callNumber.ToString();
        }

        private string GenerateRandomName()
        {
            StringBuilder name = new StringBuilder();
            //int previousAscii = 0;
            int[] previousAscii = new int[3];

            for (int i = 0; i < 3; i++)
            {
                //Random Uppercase letter:
                Random rnd = new Random();
                int ascii_index = rnd.Next(65, 91); //ASCII character codes 65-90


                while (previousAscii.Contains(ascii_index))
                {
                    ascii_index = rnd.Next(65, 91);
                }

                previousAscii[i] = ascii_index;


                char myRandomUpperCase = Convert.ToChar(ascii_index); //produces any char A-Z

                name.Append(myRandomUpperCase);
            }

            return name.ToString();

        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            object obj = lstAvailableBooks.SelectedItem;

            if (obj != null)
            {
                if (!userSortedList.Contains(obj.ToString()))
                {
                    userSortedList.Add(obj.ToString());
                    lstSortedList.ItemsSource = userSortedList;
                    lstSortedList.Items.Refresh();
                }
            }
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            object obj = lstSortedList.SelectedItem;

            if (obj != null)
            {
                userSortedList.Remove(obj.ToString());
                lstSortedList.ItemsSource = userSortedList;
                lstSortedList.Items.Refresh();
            }
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            object obj = lstSortedList.SelectedItem;

            if (obj != null)
            {
                int index = userSortedList.IndexOf(obj.ToString());
                if (index == 0) return;

                userSortedList.Insert(index-1, obj.ToString());

                userSortedList.RemoveAt(index+1);
                lstSortedList.ItemsSource = userSortedList;
                lstSortedList.Items.Refresh();
            }
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            object obj = lstSortedList.SelectedItem;

            if (obj != null)
            {
                int index = userSortedList.IndexOf(obj.ToString());
                if (index == userSortedList.Count-1) return;

                userSortedList.Insert(index + 2, obj.ToString());

                userSortedList.RemoveAt(index);
                lstSortedList.ItemsSource = userSortedList;
                lstSortedList.Items.Refresh();
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            lstSortedList.ItemsSource = null;
            lstSortedList.Items.Refresh();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnValidate_Click(object sender, RoutedEventArgs e)
        {
            CustomMessageBox msgBox = null;

            if(userSortedList.Count == 0 ||userSortedList.Count < lstAvailableBooks.Items.Count)
            {
                msgBox = new CustomMessageBox("Please sort all numbers to Validate", MessageType.Info, MessageButtons.Ok);
                msgBox.ShowDialog();
                return;
            }

            if (userSortedList.SequenceEqual(sortedList))
            {
                msgBox = new CustomMessageBox("Greate Work Done!", MessageType.Success, MessageButtons.Ok);
                msgBox.ShowDialog();
            }
            else
            { 
                msgBox = new CustomMessageBox("Try Again!", MessageType.Error, MessageButtons.Ok);
                msgBox.ShowDialog();
            }
        }
    }
}
