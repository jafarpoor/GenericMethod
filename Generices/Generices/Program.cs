// See https://aka.ms/new-console-template for more information


using Generices;

GenericList<int> genericList = new GenericList<int>();
genericList.Add(1);
genericList.Add(2);
genericList.Add(3);

GenericList<string>  generic = new GenericList<string>();
generic.Add("Test1");
generic.Add("Test2");

////
TestKeyValuePair<int, string> valuePair = new TestKeyValuePair<int , string>();
valuePair.Generickey = 1;
valuePair.GenericValue = "test";

TestKeyValuePair<int, int> valuePair1 = new TestKeyValuePair<int, int>();
valuePair1.Generickey = 1;
valuePair1.GenericValue =2;

////
List<Book> Books = new List<Book>()
{
    new Book()
    {
        Id=1,
        Name="book1"
    },
    new Book()
    {
        Id=2,
        Name="book2"
    }
};

foreach (var item in Books)
{
    Console.WriteLine(item.Name);
}

////
GenericClass<ClassB> genericClass = new GenericClass<ClassB>();
genericClass.ValueClassGenericClass = 1;
///
Console.WriteLine("Hello, World!");
Console.ReadKey();
