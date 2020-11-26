using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_navigatieControls
{
    //MVVM - Model - ViewModel - View
    public class DatePickerViewModel //ViewModel om te binden aan een View (DatePickerDemo view)
    {
        public DatePickerViewModel()
        {
            _datumVandaag = DateTime.Now.ToShortDateString();
        }
        private string _datumVandaag;
        public string DatumVandaag
        {
            get { return _datumVandaag; }
        }
    }


}
