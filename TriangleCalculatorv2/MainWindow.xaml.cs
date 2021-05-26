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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TriangleCalculatorv2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int sidea, sideb, sidec;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sidea = Convert.ToInt32(Input1.Text);
            sideb = Convert.ToInt32(Input2.Text); //here we convert the inputs to an int in order so the program can properly read it
            sidec = Convert.ToInt32(Input3.Text);

            GuiCalculator guiCalc = new GuiCalculator();

            switch (guiCalc.GuiTriangleCalculator(sidea, sideb, sidec)) //Here we take the input of our Guicalculator class and define which case it should choose from
            {
                case 1:
                    TriangleDesc.Text = "This is an equilateral triangle.";
                    break;
                case 2:
                    TriangleDesc.Text = "This is an isosceles triangle.";
                    break;
                case 3:
                    TriangleDesc.Text = "This is a scalene triangle.";
                    break;
            }

        }
    }
}