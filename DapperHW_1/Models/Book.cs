namespace DapperHW_1.Models;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Page { get; set; }
    public string Author { get; set; }
    public int Price { get; set; }
    public int Stock { get; set; }

    public override string ToString() => Name + " " + Page + " " + Author + " " + Price + " " + Stock;
}
