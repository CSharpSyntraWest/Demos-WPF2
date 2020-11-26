using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
/*
 * Oefening WPF Binding
 * Maak een nieuwe public property GeboorteDatum met enkel get die je geboortedatum bindt aan de Eerste datepicker control
 * initialiseer de geboortedatum in de constructor van DatePickerViewModel
 * Ga daarna naar DatePickerDemo.xaml en zet de Text="{Binding GeboorteDatum}" van de bovenste datepicker control
 */
namespace Demos_navigatieControls
{
    //MVVM - Model - ViewModel - View
    public class DatePickerViewModel: INotifyPropertyChanged //ViewModel om te binden aan een View (DatePickerDemo.xaml view)
    {
        public DatePickerViewModel()
        {
            _datumVandaag = DateTime.Now.ToShortDateString();
            //_geboorteDatum = new DateTime(1977, 12, 10);
            _selectedDate = new DateTime(1977, 12, 10);
            _geboorteDatum = _selectedDate.ToShortDateString();
        }
        private string _datumVandaag;
        public string DatumVandaag
        {
            get { return _datumVandaag; }
        }
        private string _geboorteDatum;
        public string GeboorteDatum
        {
            get { return _geboorteDatum; }
            
        }
        private DateTime _selectedDate;

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime SelectedDate
        {
            get {
                return _selectedDate;
            }
            set {
                _selectedDate = value;
                OnPropertyChanged();
                Debug.WriteLine(_selectedDate.ToShortDateString());
            }
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }


}
