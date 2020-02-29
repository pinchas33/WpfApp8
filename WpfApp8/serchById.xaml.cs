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
using BO;
using BlApi;
using WpfApp8;
using System.Collections.ObjectModel;

namespace PLGui
{
    /// <summary>
    /// Interaction logic for serchById.xaml
    /// </summary>
    public partial class serchById : Window
    {
        BlApi.IBl bl = BlFactory.GetBl();
        public string idToFind { get; set; }
        public string fromWhere { get; set; }
        public ObservableCollection<Soldier> Obs { get; set; }

        public serchById(string from, ObservableCollection<Soldier> obs)
        {
            InitializeComponent();
            fromWhere = from;
            Obs = obs;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            idToFind = idToSerch.Text;

            try
            {
                Soldier s = new Soldier();
                s = bl.GetSoldier(idToFind);
                formSoldier fs = new formSoldier(s, fromWhere, Obs);
                fs.Show();
                Close();
            }
            catch
            {
                MessageBox.Show("חייל זה לא נמצא במערכת",
                   "שים לב",
                   MessageBoxButton.OKCancel, MessageBoxImage.Hand, MessageBoxResult.Cancel);
            }

        }
    }
}
