using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Demos_WPF_Binding
{
    /// <summary>
    /// Interaction logic for BindingObject.xaml
    /// </summary>
    public class Werknemer : INotifyPropertyChanged
    {
        public Werknemer()
        {
            _voornaam = "Jan";
            _familienaam = "Jansen";
        }
        private string _familienaam;

        public string FamilieNaam
        {
            get { return _familienaam; }
            set
            {

                _familienaam = value;
                OnPropertyChanged();
                Debug.WriteLine(_familienaam);
            }
        }

        private string _voornaam;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public string VoorNaam
        {
            get
            {
                return _voornaam;
            }
            set
            {
                _voornaam = value;
                OnPropertyChanged();
                Debug.WriteLine(_voornaam);
            }
        }
    }
    public partial class BindingObject : UserControl
    {
        public BindingObject()
        {
            InitializeComponent();
            Werknemer werknemer = new Werknemer();
            DataContext = werknemer;
        }
    }


}
