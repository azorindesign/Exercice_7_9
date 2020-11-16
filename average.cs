/*Calculates the average of a set of marks, until the user types
“end”.*/

using System;

public class Average{
	public static void Main(){
		
		double mark1 = 0, mark2, mark3 = 0, mark4;
		string newmark;
		
		Console.Write("Insert a mark: ");
		userwrite=Console.ReadLine(); 
		
		while(newmark!="end"){
			mark2 = Convert.ToDouble(userwrite);
			mark3++;   //counter of numbers
			mark1 += mark2;  // sum of all the notes
			
			Console.Write("Insert a mark: ");
			newmark=Console.ReadLine();
		}
		if(mark3!=0){
			mark4=mark1/mark3;  //calculate the average
		Console.WriteLine("The average is {0}.",mark4);
		}
	}
}
