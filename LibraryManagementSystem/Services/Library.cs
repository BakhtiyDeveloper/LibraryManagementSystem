using System;
using System.Collections.Generic;

public class Library
{
    private List<Book> books = new List<Book>();

    public void DisplayBooks()
    {
        Console.WriteLine("\nCurrent books in the library:");
        for (int i = 0; i < books.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {books[i].Title} by {books[i].Author}");
        }
    }

    public void AddBook(string title, string author)
    {
        books.Add(new Book { Title = title, Author = author });
        Console.WriteLine($"Book '{title}' by {author} added to the library.");
    }

    public void RemoveBook(int index)
    {
        if (index >= 0 && index < books.Count)
        {
            string removedBookTitle = books[index].Title;
            books.RemoveAt(index);
            Console.WriteLine($"Book '{removedBookTitle}' removed from the library.");
        }
        else
        {
            Console.WriteLine("Invalid index, please try again.");
        }
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}