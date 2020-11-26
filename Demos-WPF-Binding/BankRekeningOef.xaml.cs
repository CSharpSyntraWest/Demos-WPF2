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
    /// Interaction logic for BankRekeningOef.xaml
    /// </summary>
    public class Bankrekening:INotifyPropertyChanged
    {
        public Bankrekening()
        {
            RekNr = "BE1234654654";
            Saldo = 500.00;
        }
        public Bankrekening(string rekNr, double saldo)
        {
            RekNr = rekNr;
            Saldo = saldo;
        }
        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value;
                OnPropertyChanged();
                Debug.WriteLine(_saldo);
            }
        }

        public string RekNr
        {
            get;
            private set;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
    public partial class BankRekeningOef : UserControl
    {
        public BankRekeningOef()
        {
            InitializeComponent();
            Bankrekening bankrek = new Bankrekening("BE12346579",500.00);
            this.DataContext = bankrek;
        }
    }
}
