using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string yesOrNo;
        do 
        {
            try 
            { 
                Console.WriteLine("My personal library : ");
                Console.WriteLine("1. list of books");
                Console.WriteLine("2. Add a book");
                Console.WriteLine("3. Remove Book");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        library.DisplayBooks();
                        break;
                    case "2":
                        Console.Write("Enter the title of the book to add: ");
                        string bookTitleToAdd = Console.ReadLine();
                        Console.Write("Enter the author of the book: ");
                        string bookAuthorToAdd = Console.ReadLine();
                        library.AddBook(bookTitleToAdd, bookAuthorToAdd);
                        break;
                    case "3":
                        library.DisplayBooks();

                        Console.Write("Enter the index of the book to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            library.RemoveBook(index - 1);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index, please enter a valid number.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"You entered an invalid value: {exception.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Do you want to continue? (yes / no)");
            yesOrNo = Console.ReadLine();

        } while (yesOrNo.ToLower() == "yes" || yesOrNo.ToLower() == "y");

        Console.WriteLine("Thank you for using our program");
    }
}