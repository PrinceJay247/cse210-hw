 
public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;
   

    public Person()
    {
        _title = "";
        _firstName = "anonymus";
        _lastName = "unknown";

    }

    public Person(string first, string last )
    {
        _title = "";
        _firstName = first;
        _lastName = last;
        
    }

    public Person(string first, string last, string title)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }

   
}