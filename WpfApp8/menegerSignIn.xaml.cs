using BlApi;
using BO;
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

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for menegerSignIn.xaml
    /// </summary>
    public partial class menegerSignIn : Window
    {
        BlApi.IBl bl = BlFactory.GetBl();
        public meneger meneger { get; set; } = new meneger();

        public menegerSignIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                meneger.Id = id.Text;
                meneger.Name = foolName.Text;
                meneger.password = password.Text;
                meneger.Email = email.Text;
                bl.addMeneger(meneger);
                Close();
            }
            catch
            {
                MessageBox.Show("מנהל זה כבר קיים במערכת",
                   "שים לב",
                   MessageBoxButton.OKCancel, MessageBoxImage.Hand, MessageBoxResult.Cancel);
            }
        }
    }
}
