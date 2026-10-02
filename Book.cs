


public class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public DateTime BorrowDate = new DateTime();
    public DateTime DueDate { get; set; }
    public BookStatus status = new BookStatus();
    public bool IsOverdue { get; set; }
    public void Boorrow(int days)
    {
        if(days == 0 || days < 0)
        {
            System.Console.WriteLine("Error");
        }
        if(status != BookStatus.Available)
        {
            System.Console.WriteLine("The book is not avaible");
        }
        else
        {
            status = BookStatus.Borrowed;
            BorrowDate = DateTime.Today;
            BorrowDate.AddDays(days);
            System.Console.WriteLine(BorrowDate);
        }
    }
    public void Return(DateTime returnDate)
    {
        int shtraf = 0;
        if(status != BookStatus.Borrowed)
        {
            System.Console.WriteLine("Error");
            shtraf = 0;
        }
        if(returnDate != DueDate)
        {
            for (int i = 0; i < returnDate.Day - DueDate.Day; i++)
            {
                shtraf += 5;
            }
            status = BookStatus.Available;
            IsOverdue = true;
            System.Console.WriteLine(shtraf);
        }
        else if(returnDate == DueDate)
        {
            status = BookStatus.Available;
        }
    }
    public enum BookStatus
    {
    Available,
    Borrowed,
    Reserved,
    Lost
    }
}