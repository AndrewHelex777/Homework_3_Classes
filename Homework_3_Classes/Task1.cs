namespace Homework_3_Classes
{
    class WebSite
    {
        public string name { get; set; }
        public string path { get; set; }
        public string desc { get; set; }
        public string address { get; set; }
        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter path: ");
            path = Console.ReadLine();
            Console.Write("Enter description: ");
            desc = Console.ReadLine();
            Console.Write("Enter address: ");
            address = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Name: {name}\nPath: {path}\nDescription: {desc}\nAddress: {address}";
        }
    }
    internal class Task1
    {
        static void Main(string[] args)
        {
            WebSite site = new WebSite();
            site.Input();
            Console.WriteLine("Site information with ToString()");
            Console.WriteLine(site.ToString());
            Console.Write($"Site name: {site.name}");
        }
    }
}