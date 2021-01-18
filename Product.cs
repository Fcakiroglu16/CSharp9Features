
public abstract class Product
{
    public string Name { get; set; }
    public int CategoryId { get; set; }


    public abstract ProductOrder Order(int quantity);

}


public class BookProduct : Product
{

    public override BookOrder Order(int quantity)
    {
        return new BookOrder { Quantity = 23, BookOrderName = "Kitap 1" };
    }
}


public class MusicProduct : Product
{
    public override MusicOrder Order(int quantity)
    {
        return new MusicOrder { Quantity = 5, MusicOrderName = "Music 1" };
    }
}

public class ProductOrder
{
    public int Quantity { get; set; }
}
public class BookOrder : ProductOrder
{
    public string BookOrderName { get; set; }
}

public class MusicOrder : ProductOrder
{
    public string MusicOrderName { get; set; }
}

