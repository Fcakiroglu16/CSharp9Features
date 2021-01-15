
//norminal records
public record Product
{

    public string Name { get; init; }
    public int CategoryId { get; init; }
}

//Eski yöntem
public record Employee2
{

    Employee2(string name, string surName) => (Name, SurName) = (name, surName);
    public string Name { get; init; }
    public string SurName { get; init; }
    public int Age { get; init; }
}

//Yeni yöntem
//Positional Record
//Class tanınlarken belirtilen degişkenler otomatik bir şekilde init olur. initializer dışında set edilemezler.
//Ama  class içerisindeki propery'i degişebilir.
public record Employee(string Name, string SurName)
{
    public int Age { get; set; }
}



