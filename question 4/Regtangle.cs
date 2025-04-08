using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_4
{
    internal class Regtangle
    {
        double width;
        double height;


        public double Width
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("error : u entered a negative value");
                 else width = value;
            }
            get 
            { return width; }
        }

        public double Height
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("error : u entered a negative value");
                else height = value;
            }
            get { return height; }
        }




        public double get_area
        {
            get
            {
                return (width * height) ;
            
            }
        
        
        }






    }
}
