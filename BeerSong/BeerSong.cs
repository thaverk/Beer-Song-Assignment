using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerSong
{
    internal class BeerSong
    {
       
        public static string Lyrics() 
        {


            int beers = 100;
            

            for (int i = 1; i <= 99; i++)
            {
                beers--;

                if (beers > 1)
                {
                    Console.WriteLine($"{beers} bottles of beer on the wall, {beers} bottles of beer. ");
                 
                    if (beers - 1 == 1)
                   {
                        Console.WriteLine($"Take one down and pass it around, {beers - 1} bottle of beer\n");
                    }

                    else 
                    {
                        
                        Console.WriteLine($"Take one down and pass it around, {beers - 1} bottles of beer\n");

                    }
                
                
                
                }

               

                else
                {
                    Console.WriteLine($"{beers} bottle of beer on the wall, {beers} bottle of beer. ");
                    
                  
                }
               

                
               

                


            }

            return "";
        
        
        }
    
    
    
    
    }
}
