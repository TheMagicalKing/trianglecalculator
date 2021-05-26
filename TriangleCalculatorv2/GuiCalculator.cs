namespace TriangleCalculatorv2
{
    public class GuiCalculator
    {
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