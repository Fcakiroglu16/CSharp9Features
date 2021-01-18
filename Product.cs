using System;
using System.Collections.Generic;

public class Example
{


    public void Write(Func<string, string> func)
    {
        var countries = new List<string>() { "İstanbul", "Ankara", "İzmir" };

        countries.ForEach(x =>
        {

            Console.WriteLine(func(x));
        });
    }



}