public class ConstructorProblem
{

    public ConstructorProblem()
    {
        Console.WriteLine("Student created (default)");
    }

    public ConstructorProblem(string name, int age)
    {
        Console.WriteLine($"Student created: Name = {name}, Age = {age}");
    }
   
}


public class Book
{
    public string? Title { get; set; }

    public string? Author { get; set; }


    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public Book(Book other)
    {
        Title = other.Title;
        Author = other.Author;
    }
}