using Library;

// Create new book objects
Book book = new Book();
// This information is for one book in our library
book.Title = "C# for beginners";
book.Author = "BillGates";
book.ISBN = "12345678";

// Display specific information about the book
Console.WriteLine("Book Information:");
Console.WriteLine("------------------");
book.DisplayInfo();

// This is another book in our library
Book book1 = new Book();
book1.Title = "C# Methods and classes";
book1.Author = "Microsoft";
book1.ISBN = "55667778";

// Display specific information about book1
book1.DisplayInfo();

// Create new member objects
Member member = new Member(1, "John Doe", "123 Main St", 5551234);

// Display specific information about the member
Console.WriteLine("Member Information:");
Console.WriteLine("-------------------");
member.DisplayInfo();

Member member1 = new Member(2, "Jane Smith", "456 Oak Ave", 5555678);
// Display specific information about member1
member1.DisplayInfo();



