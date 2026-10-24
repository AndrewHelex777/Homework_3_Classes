namespace Homework_3_Classes
{
    class Shop
    {
        public string name { get; set; }
        public string address { get; set; }
        public string desc { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter address: ");
            address = Console.ReadLine();
            Console.Write("Enter description: ");
            desc = Console.ReadLine();
            Console.Write("Enter tel: ");
            tel = Console.ReadLine();
            Console.Write("Enter email: ");
            email = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Name: {name}\nAddress: {address}\nDescription: {desc}\nContact telephone: {tel}\nEmail: {email}";
        }
    }
    internal class Task3
    {
        static void Main(string[] args)
        {
            Shop sh = new Shop();
            sh.Input();
            Console.WriteLine("Shop information with ToString()");
            Console.WriteLine(sh.ToString());
            Console.Write($"Shop email: {sh.email}");
        }
    }
}