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
using AnimalDataEntitities;

namespace WCFClient_WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //ServiceReference.AnimalDataServiceClient client = new ServiceReference.AnimalDataServiceClient();
            //Animal animal = new Animal();
        
            //var animals = client.GetAnimals();
            ListViewItem lvi = new ListViewItem();
            lvi.Content= "LALA";
     

            listView1.Items.Add(lvi);

            //foreach (Animal animalData in client.GetAnimals())
            //{
            //    ListViewItem lvi = new ListViewItem();
            //    lvi.Content = animalData.Name;

            //    listView1.Items.Add(lvi);
            //}


        }
    }
}
