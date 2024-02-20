var Person1 = new Person();
System.Console.Write("Enter your Fullname: ");
Person1.GetFullName = Console.ReadLine();                      
System.Console.WriteLine("Enter your Age");
Person1.GetBirthYear = int.Parse(Console.ReadLine());
Person1.GetInfo();
Person1.GetBirthyear();

public class Person
{
    public string FirstName ; 
        public string LastName ;
        public int  Age ;
        public string Address;
        public string GetFullName ;
        public int  GetBirthYear;

    public void GetInfo()
    {
        System.Console.WriteLine($"My name is : {GetFullName}");
    }

    public void GetBirthyear(){
        System.Console.WriteLine($"My Birth year is: {GetBirthYear} ");
    }
}
