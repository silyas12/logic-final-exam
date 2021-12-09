using System;
using System.Collections;

class Song{
  pubic int Id{
    get{
      return id;
    }
    set{
      if(value.ToString().Length !=10){
        Console.WriteLine("Id must be 10 digits only, try again.");
      }
      id=value;
    }
  }
  public string Title{get;set;}
  public Artist ArtistInfo
}




/*a.	Create the following properties:
i.	Id (number)
•	Length should be exactly 10.
ii.	Title (text)
•	Auto-implemented property
iii.	ArtistInfo (Artist)
•	Auto-implemented property
b.	Constructors
i.	Create a constructor that takes no parameters
ii.	Create a constructor that takes id, title.
c.	Create the following methods:
i.	AddArtistInfo
•	Method gets Artist as input parameter
•	Method adds Artist to ArtistInfo and will display a message to console 
*/