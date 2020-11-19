/*Calculates the average of a set of marks, until the user types
“end”.*/

using System;

public class Average {
	
	public static void Main(){
		
		double sum = 0, usermark, markcounter = 0, average;
		string userwrite;
		
		Console.Write("Insert a mark: ");
		userwrite = Console.ReadLine(); 
		
		/*We enter at the bucle until the user write "end" and convert 
		 * string to int to calculate de markcounter and the sum of notes*/
		 
		while(userwrite != "end"){										
			
			usermark = Convert.ToDouble(userwrite);						
			markcounter++;
			sum += usermark;
			
			Console.Write("Insert a mark: ");
			userwrite=Console.ReadLine();
		}
		
		if(markcounter!=0){
			
			average = sum / markcounter;
			
			Console.WriteLine("The average is {0}.",average);
		}
	}
}
