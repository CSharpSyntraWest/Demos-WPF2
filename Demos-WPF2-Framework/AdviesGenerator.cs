using System;
using System.Collections.Generic;
using System.Text;

namespace Demos_WPF2_Framework
{
    public class AdviesGenerator
    {
        private List<string> _antwoorden;
        public AdviesGenerator()
        {
            _antwoorden = new List<string>();
            VulAntwoorden();
        }
        private void VulAntwoorden()
        {
            _antwoorden.Add("42");
            _antwoorden.Add("Het is bewolkt maar geen regen");
            _antwoorden.Add("Met mij gaat het goed, dank u");
        }
        public string GetRandomAntwoord(string vraag)
        {
            int index = vraag.Length % 3;
            return _antwoorden[index];
        }
    }
}
