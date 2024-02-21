using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok
{
    public class Book
    {
        Genre genre;
        string title;
        string author;

        
        public Book(string title, string author, Genre genre)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
        }

        public Book(Book book)
        {
            this.title = book.Title;
            this.author = book.Author;
            this.genre = book.Genre;
        }

        /*public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set;}*/
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public Genre Genre
        {
            get { return genre; }
            set { genre = value; }
        }


    }
}
