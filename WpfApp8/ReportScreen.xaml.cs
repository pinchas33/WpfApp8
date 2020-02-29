using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using BlApi;
using BO;
using PLGui;


namespace PLGui
{
    /// <summary>
    /// Interaction logic for ReportScreen.xaml
    /// </summary>
    public partial class ReportScreen : Window
    {
        BlApi.IBl bl = BlFactory.GetBl();
        public ObservableCollection<Soldier> Obs { get; set; }
        public ObservableCollection<string> ObsName { get; set; }

        public ReportScreen()
        {
            meneger meneger = bl.GetMeneger("2");
            Obs = new ObservableCollection<Soldier>(meneger.soldiers);

            InitializeComponent();

            soldier.ItemsSource = Obs;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            report report = new report();

            report.Reports = new List<DetalsOfReport>();
            DetalsOfReport DOR = new DetalsOfReport();
            foreach (var o in Obs)
            {
                DOR.Id = o.Id;
                DOR.firstName = o.firstName;
                DOR.lastName = o.lastName;
                DOR.Staff = o.Staff;
                DOR.status = o.status;
                report.Reports.Add(DOR);
            }

            report.idOfReport = "0";

            bl.addReport(report);
        }
    }
}
