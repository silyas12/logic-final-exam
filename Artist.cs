using System;
using System.Collections;

class Artist{
  public string FirstName{get;set;}
  public string LastName{get;set;}
  public string Email {get;set;}

  //constructor
  public Artist(string firstName, string lastName)
  {
    this.FirstName = firstName;
    this.LastName = lastName;
    this.Email ="unknown";
  }

  //method
  public void Display()
  {
    Console.WriteLine("Artist info: " + this.FirstName + " " + 
    this.LastName);
  }
}
/*1.	Create a class called Artist
a.	Create the following properties:
i.	First Name (text)
•	Auto-implemented property
ii.	Last Name (text)
•	Auto-implemented property
iii.	Email (text)
•	Auto-implemented property
b.	Create a constructor that takes first name, last name as input.
i.	Set Email to “unknown”
c.	Create method
i.	Display()
•	Display artist first name, last name
•	 
*/