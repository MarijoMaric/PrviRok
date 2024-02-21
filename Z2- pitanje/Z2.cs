using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok.Z2__pitanje
{
    public class Z2
    {
        public static void RunZ2()
        {
            /*AudioBook audioBook = new AudioBook("Proba", "Maric", Genre.Fantasy, new DateTime(2/15/2024), 4608, 2);
            double minutes = audioBook.MinutesPerDayNeeded(new DateTime(2 / 22 / 2024));
            Console.WriteLine(minutes);*/


            
            Book book = new Book("The Lord of the Rings", "J.R.R. Tolkien", Genre.Fantasy);
            Console.WriteLine($"Book: {book.Title} by {book.Author}, Genre: {book.Genre}");

            
            DateTime startedAt = DateTime.Now.AddDays(-10); 
            AudioBook audioBook = new AudioBook("The Lord of the Rings", "J.R.R. Tolkien", Genre.Fantasy, startedAt, 2400,5); // Trajanje audioknjige je 2400 minuta (40 sati)

            DateTime desiredEndDate = DateTime.Now.AddDays(5); 

            double minutesPerDay = audioBook.MinutesPerDayNeeded(desiredEndDate); 
            Console.WriteLine($"End date: {desiredEndDate}: min: {minutesPerDay}");

            


        }


    }
}
