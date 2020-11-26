using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demos_WPF2
{
    /// <summary>
    /// Interaction logic for TextBoxDemo.xaml
    /// </summary>
    public partial class TextBoxDemo : UserControl
    {
        public TextBoxDemo()
        {
            InitializeComponent();
        }

        private void btnGeefAntwoord_Click(object sender, RoutedEventArgs e)
        {
            AdviesGenerator adviesGenerator = new AdviesGenerator();
            txtAntwoord.Text = adviesGenerator.GetRandomAntwoord(txtVraag.Text);
        }
    }
}
