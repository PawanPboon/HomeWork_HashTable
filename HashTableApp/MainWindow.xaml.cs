using System;
using System.Collections;
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

namespace HashTableApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            //Add
            MessageBox.Show("Added Complete");
            hashtable.Add(txtKey.Text,txtValue.Text);
           
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            //remove
            MessageBox.Show("Removed Complete");
            hashtable.Remove(txtKey.Text);
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            
            ICollection icollection = hashtable.Keys;
            //show
            foreach(string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
                
            }
            MessageBox.Show("Count is       " + hashtable.Count.ToString());
        }
    }
}
