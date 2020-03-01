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
using PLGui;
using BO;
using BlApi;
using WpfApp8;
using System.Collections.ObjectModel;
//using DS;
using BL;

//using DalApi;

namespace PLGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BlApi.IBl bl = BlFactory.GetBl();
        public ObservableCollection<Soldier> Obs { get; set; }
        public meneger meneger { get; set; }
        public MainWindow()
        {
            meneger meneger = bl.GetMeneger();
            Obs = new ObservableCollection<Soldier>(meneger.soldiers);

            InitializeComponent();
            deatal.Text = meneger.deatales;

            soldier.ItemsSource = Obs;
            DataContext = meneger;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReportScreen wnd = new ReportScreen();
            wnd.ShowDialog();
        }
        private void Group(object sender, RoutedEventArgs e)
        {
            //ObservableCollection<Soldier> newObs = new ObservableCollection<Soldier>(bl.GetMeneger("2").soldiers);
            ////    new ObservableCollection<Soldier>(bl.GroupsoldierBycriteria());

            //Obs.Clear();

            //newObs.ToList().ForEach(s => Obs.Add(s));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            formSoldier fs = new formSoldier(Obs);
            fs.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string from = "update";
            serchById sbid = new serchById(from, Obs);
            sbid.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string from = "delete";
            serchById sbid = new serchById(from, Obs);
            sbid.ShowDialog();
        }

        private void signIn(object sender, RoutedEventArgs e)
        {
            menegerSignIn menegerSignIn = new menegerSignIn();
            menegerSignIn.ShowDialog();
        }
    }
}

