namespace Homework_3_Classes
{
    class WebSite
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private string path;
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }
        private string desc;
        public string Desc
        {
            get
            {
                return desc;
            }
            set
            {
                desc = value;
            }
        }
        private string address;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
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
    class Journal
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        private string desc;
        public string Desc
        {
            get
            {
                return desc;
            }
            set
            {
                desc = value;
            }
        }
        private string tel;
        public string Tel
        {
            get
            {
                return tel;
            }
            set
            {
                tel = value;
            }
        }
        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
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
    class Shop
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private string address;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        private string desc;
        public string Desc
        {
            get
            {
                return desc;
            }
            set
            {
                desc = value;
            }
        }
        private string tel;
        public string Tel
        {
            get
            {
                return tel;
            }
            set
            {
                tel = value;
            }
        }
        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WebSite");
            WebSite site = new WebSite();
            site.Input();
            Console.WriteLine("Site information with ToString()");
            Console.WriteLine(site.ToString());
            Console.Write($"Site name: {site.Name}");
            Console.WriteLine("\n\nJournal");
            Journal journal = new Journal();
            journal.Input();
            Console.WriteLine("Journal information with ToString()");
            Console.WriteLine(journal.ToString());
            Console.Write($"Journal description: {journal.Desc}");
            Console.WriteLine("\n\nShop");
            Shop sh = new Shop();
            sh.Input();
            Console.WriteLine("Shop information with ToString()");
            Console.WriteLine(sh.ToString());
            Console.Write($"Shop email: {sh.Email}");
        }
    }
}