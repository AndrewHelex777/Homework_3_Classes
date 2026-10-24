namespace Homework_3_Classes
{
    class Journal
    {
        public string name { get; set; }
        public int year { get; set; }
        public string desc { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter year: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Enter description: ");
            desc = Console.ReadLine();
            Console.Write("Enter tel: ");
            tel = Console.ReadLine();
            Console.Write("Enter email: ");
            email = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Name: {name}\nYear: {year}\nDescription: {desc}\nContact telephone: {tel}\nEmail: {email}";
        }
    }
    internal class Task2
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            journal.Input();
            Console.WriteLine("Journal information with ToString()");
            Console.WriteLine(journal.ToString());
            Console.Write($"Journal description: {journal.desc}");
        }
    }
}