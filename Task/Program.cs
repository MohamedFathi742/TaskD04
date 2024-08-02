namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mohamed", 22, "October", "Egyption") { };


            Studentt student = new Studentt("Abdelkarem", 20, "Grga", "Egyption", "College Student", "Mechanics",5) { };


            Employee employee = new Employee("Abdelrahman",18,"Grga","Egyption",10000,"Doctor","Doctor") { };


           HoureEmpolyee houreEmpolyee=new HoureEmpolyee("Mahmoud",22,"Grga","Egyption",50000,"ttt","fff",8,5) { };

             SalariedEmployee salariedEmployee = new SalariedEmployee("Ahmed", 25, "Grga", "Egyption", 7700, "ttt", "fff", 20, 5) { };


        }
    }
}
