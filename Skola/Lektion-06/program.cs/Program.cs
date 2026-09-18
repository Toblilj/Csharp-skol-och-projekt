﻿//skriver om denna filen för att kunna jobba med övningar för repetitioner. 
// får kika på invoice generator biten senare. 


//1. Skriv en klass `Book` med fälten `title` och `author` (båda `string`).
//2. Skriv en **konstruktor** för `Book` som tar emot båda som parametrar och sätter fälten — använd `this.` där det behövs.
//3. Skapa två `Book`-objekt i en `Main`-metod med olika titlar, skriv ut båda.

public class Book
{
   public String title{get; set;}
    String author;


public Book(string title, string author)
{
    //sätter dessa värden för att kunna använda dom dynamiskt har vi t.e.x en array lr lista lr objekt med massao lika författare så 
    //vill vi kunna hämta rätt titel och författare. och inte itne ett hårdkodat värde..
this.title=title;
this.author=author;

}
public string PageCount (get;) {
 
}
static void Main (string[] args)
{
    Book book1 = new Book(title, "F. Scott Fitzgerald");
    Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");

    Console.WriteLine($"Book 1: {book1.title} by {book1.author}");
    Console.WriteLine($"Book 2: {book2.title} by {book2.author}");                                                      
}
}

//2. Lägg till en property `PageCount` som bara har `get` (ingen `set`) — 
// sätt värdet direkt i konstruktorn.
//3. Lägg till en property `IsAvailable` (bool) där `set` är `private` — bara klassen själv ska kunna ändra 
//den (t.ex. via en metod `Borrow()` som sätter den till `false`).