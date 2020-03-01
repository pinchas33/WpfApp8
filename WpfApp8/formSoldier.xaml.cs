using BlApi;
using BO;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace PLGui
{
    /// <summary>
    /// Interaction logic for formSoldier.xaml
    /// </summary>
    public partial class formSoldier : Window
    {
        BlApi.IBl bl = BlFactory.GetBl();
        public string textOfAction { get; set; }
        public Soldier curentSoldier { get; set; } = new Soldier();
        public Soldier oldSoldier { get; set; } = new Soldier();
        public ObservableCollection<Soldier> Obs { get; set; }

        public formSoldier(ObservableCollection<Soldier> obs)
        {
            InitializeComponent();
            DynamicButton.Content = "הוספה";
            Obs = obs;
        }
        public formSoldier(Soldier soldierToChange, string textOfButton, ObservableCollection<Soldier> obs)
        {
            InitializeComponent();
            Obs = obs;
            oldSoldier = soldierToChange;
            id.Text = soldierToChange.Id;
            firstName.Text = soldierToChange.firstName;
            lastName.Text = soldierToChange.lastName;
            Staff.Text = soldierToChange.Staff;
            phone.Text = soldierToChange.phone;
            rank.Text = soldierToChange.rank;
            addres.Text = soldierToChange.addres;
            remarks.Text = soldierToChange.Remarks;
            if (textOfButton == "update")
            {
                DynamicButton.Content = "עדכן";
                id.IsEnabled = false;
            }
            if (textOfButton == "delete")
            {
                DynamicButton.Content = "מחק";
                id.IsEnabled = false;
            
            }
            curentSoldier = soldierToChange;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textOfAction = DynamicButton.Content.ToString();
            switch(textOfAction)
            {
                case "הוספה":
                    addSoldier();
                    break;
                case "עדכן":
                    updateSoldier();
                    break;
                case "מחק":
                    DeleteSoldier();
                    break;
                default:
                    break;
            }

        }

        private void DeleteSoldier()
        {
            try
            {
                bl.DeleteSoldier(curentSoldier.Id);
                Obs.Clear();
                meneger meneger = bl.GetMeneger();
                ObservableCollection<Soldier> newObs = new ObservableCollection<Soldier>(meneger.soldiers);
                newObs.ToList().ForEach(s => Obs.Add(s));
                Close();
            }
            catch
            {
                MessageBox.Show("חייל זה לא קיים במערכת",
                   "שים לב",
                   MessageBoxButton.OKCancel, MessageBoxImage.Hand, MessageBoxResult.Cancel);
            }
        }

        private void updateSoldier()
        {
            Soldier soldier = Obs.Where(s => s.Id == getSoldierUpdated().Id) as Soldier;
            Obs.Clear();
            bl.updateSoldier(getSoldierUpdated());
            meneger meneger = bl.GetMeneger();
            ObservableCollection<Soldier> newObs = new ObservableCollection<Soldier>(meneger.soldiers);
            newObs.ToList().ForEach(s => Obs.Add(s));
            Close();
        }

        private void addSoldier()
        {
            try
            {
                bl.addSoldier(getSoldierUpdated());
                Obs.Add(getSoldierUpdated());
                Close();
            }
            catch
            {
                MessageBox.Show("חייל זה קיים במערכת",
                   "שים לב",
                   MessageBoxButton.OKCancel, MessageBoxImage.Hand, MessageBoxResult.Cancel);
            }
            
        }

        private Soldier getSoldierUpdated()
        {

            Soldier newSoldier = new Soldier();
            newSoldier.Id = id.Text;
            newSoldier.firstName = firstName.Text;
            newSoldier.lastName = lastName.Text;
            newSoldier.Staff = Staff.Text;
            newSoldier.phone = phone.Text;
            newSoldier.rank = rank.Text;
            newSoldier.addres = addres.Text;
            newSoldier.Remarks = remarks.Text;
            if (id.Text == "")
            {


            }
            return newSoldier;
        }


    }
}
