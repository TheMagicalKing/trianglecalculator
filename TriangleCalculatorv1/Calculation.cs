using System;

namespace TriangleCalculatorv1
{
    public class Calculation
    {
        public static void CalculateInt()
        {
            int sidea, sideb, sidec; //here we set the variables to be int for a number without decimals


            //This part is where we ask the user in console what their triangles sides are
            Console.WriteLine("\n\ninput your sides below and we'll tell you what kind of triangle you've got! \n\n");
            Console.Write("Input side 1 of triangle: ");
            sidea= Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            sideb= Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Input side 3 of triangle: ");
            sidec= Convert.ToInt32(Console.ReadLine());  
 

            //Here the 'logic' happens, we put the information into an if statement and then 
            //tell the user dependant on which sides are the same what triangle they've got.
            if(sidea==sideb && sideb==sidec) 
            {  
                Console.Write("This is an equilateral triangle.\n");  
            }  
            else if(sidea==sideb || sidea==sidec || sideb==sidec) 
            {  
                Console.Write("This is an isosceles triangle.\n");  
            }  
            else 
            {  
                Console.Write("This is a scalene triangle.\n");  
            }  
        }
    }
}