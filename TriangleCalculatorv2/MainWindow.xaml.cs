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
        private int sidea, sideb, sidec;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sidea = Convert.ToInt32(Input1.Text);
            sideb = Convert.ToInt32(Input2.Text);
            sidec = Convert.ToInt32(Input3.Text);
            
            if(sidea==sideb && sideb==sidec)
            {
                TriangleDesc.Text = "This is an equilateral triangle.";
            }  
            else if(sidea==sideb || sidea==sidec || sideb==sidec) 
            {
                TriangleDesc.Text = "This is an isosceles triangle.";
            }  
            else 
            {
                TriangleDesc.Text = "This is a scalene triangle.";
            }  
            
        }
    }
}