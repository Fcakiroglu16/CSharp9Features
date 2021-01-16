
//norminal records
public class Product
{

    public string Name { get; set; }
    public int CategoryId { get; set; }
}

public class BookProduct:Product
{
    public string    Price { get; set; }
}

public class  PhoneProduct:Product
{

    public  string Sim { get; set; }
}


