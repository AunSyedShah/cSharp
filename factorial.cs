using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace we3
{

    public class We3 
    {
    	public int factorial(int num) {
         /* local variable declaration */
         int result;
         if (num == 1) {
            return 1;
         } else {
            result = factorial(num - 1) * num;
            return result;
         }
    		
    	}
    	//driver function
        static void Main(string[] args)
        {
        	We3 f = new We3();
        	Console.WriteLine(f.factorial(5));
        }
    }
}
