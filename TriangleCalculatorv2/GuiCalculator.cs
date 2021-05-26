namespace TriangleCalculatorv2
{
    public class GuiCalculator
    {
        /*
         * the function is made into an int so we have something to return
         * making it possible to use a Switch instead of if, elif and else statements in MainWindow.xaml.cs
         * This could also have been done with a string function instead.
         */
        
        public int GuiTriangleCalculator(int sidea, int sideb, int sidec)
        {
            if(sidea==sideb && sideb==sidec)
            {
                return 1;
            }  
            else if(sidea==sideb || sidea==sidec || sideb==sidec)
            {
                return 2;
            }  
            else
            {
                return 3;
            }  
        }
    }
}