using HomeWork3.Task1;
using HomeWork3.Task2;
using HomeWork3.Task3;
using HomeWork3.Task4;
using System;
namespace HomeWork3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //RunTask1_Library();
            //RunTask2_Univercity();
            //RunTask3_OnlineShop();
            RunTask4_Hospital();

        }
        static void RunTask1_Library()
        {
            Library library = new Library();

            Book b1 = new Book("C# Basic", "Amir Ghasemzade", "1111");
            Book b2 = new Book("C++", "Parsa Panahpoor", "2222");

            library.AddBook(b1);
            library.AddBook(b2);

            while (true)
            {
                Console.WriteLine("Library Menu");
                Console.WriteLine("1_ Show All Books");
                Console.WriteLine("2_Borrow Books");
                Console.WriteLine("3_Return Books");
                Console.WriteLine("0_Exit");
                Console.Write("Choose");

                string choice = Console.ReadLine();

                if (choice == "0")
                    break;
                switch (choice)
                {
                    case "1":
                        library.PrintBooks();
                        break;

                    case "2":
                        Console.WriteLine("Title of Book for Borrow:");
                        string borrowTitle = Console.ReadLine();
                        library.BorrowBook(borrowTitle);
                        break;

                    case "3":
                        Console.WriteLine("Title of Book for Return:");
                        string returnTitle = Console.ReadLine();
                        library.ReturnBook(returnTitle);
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                Console.WriteLine("------------------------------------------");
            }
            Console.WriteLine("Press a Key for EXIT");
            Console.ReadKey();
        }

        static void RunTask2_Univercity()
        {
            List<Task2.Person> people = new List<Task2.Person>();

            Student student1 = new Student("Amir", 26, "S1001", "Art");
            Student student2 = new Student("Sahar", 20, "S1002", "Math");
            Professor professor1 = new Professor("Reza", 55, "P1003", "C#");
            Professor professor2 = new Professor("Arman", 65, "P1004", "C++");

            people.Add(student1);
            people.Add(student2);
            people.Add(professor1);
            people.Add(professor2);

            foreach (Task2.Person person in people)
            {
                Console.WriteLine(person.GetDetails());
            }
        }
        static void RunTask3_OnlineShop()
        {
            List<Product> products = new List<Product>();

            while (true) 
            {
                Console.WriteLine("Stores Menu");
                Console.WriteLine("1_Add Electronic Product");
                Console.WriteLine("2_Add Clothing Product");
                Console.WriteLine("3_Show All Products");
                Console.WriteLine("4_apply Discount On All Products");
                Console.WriteLine("0_Exit The Store");
                Console.WriteLine("Choose");

                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "0")
                    break;
                switch (choice)
                {
                    case "1":
                        Console.Write("Product name");
                        string eProductname = Console.ReadLine();

                        Console.Write("Price");
                        double eProductPrice = double.Parse(Console.ReadLine());

                        Console.Write("Warranty");
                        int eWarranty = int.Parse(Console.ReadLine());

                        Electronic electronic = new Electronic(eProductname, eProductPrice, eWarranty);
                        products.Add(electronic);

                        Console.WriteLine("Electronic Product Added");
                        break;


                    case "2":
                        Console.Write("Product name");
                        string cProductname = Console.ReadLine();

                        Console.Write("Price");
                        double cProductprice = double.Parse(Console.ReadLine());

                        Console.Write("Size");
                        string size = Console.ReadLine();

                        Console.Write("Material");
                        string material = Console.ReadLine();

                        Clothing clothing = new Clothing(cProductname, cProductprice, size, material);
                        products.Add(clothing);

                        Console.WriteLine("Clothing Product Added");
                        break;


                    case "3":
                        if (products.Count == 0)
                        {
                            Console.WriteLine("There is no Products");
                        }
                        else
                        {
                            Console.WriteLine("Products List");
                            foreach (Product product in products)
                            {
                                Console.WriteLine(product.GetProductDetail());
                            }
                            Console.WriteLine();
                        }
                        break;


                    case "4":
                        Console.WriteLine("Discount Percentage");
                        double percent = double.Parse(Console.ReadLine());

                        foreach (Product product in products)
                        {
                            if (product is IDiscountable discount)
                            {
                                discount.ApplyDiscount(percent);
                            }
                        }
                        Console.WriteLine("Discount Applied");
                        break;

                    default:
                        Console.WriteLine("The option is Invalid");
                        break;
                }
            }
        }
        static void RunTask4_Hospital()
        {
            Hospital hospital = Hospital.Instance;

            Room r1 = new Room(101, 1);
            Room r2 = new Room(102, 2);
            hospital.Rooms.Add(r1);
            hospital.Rooms.Add(r2);

            Doctor d1 = PersonFactory.CreateDoctor("dr Hamid", 45, "1111111111", "D10", "Cardiology");
            Doctor d2 = PersonFactory.CreateDoctor("dr Sara", 38, "2222222222", "D20", "Neurology");

            hospital.Doctors.Add(d1);
            hospital.Doctors.Add(d1);

            Patient p1 = PersonFactory.CreatePatient("Arash", 15, "3333333333", "P10");
            Patient p2 = PersonFactory.CreatePatient("Mahsa", 22, "4444444444", "P20");

            hospital.AdmitPatient(p1);
            hospital.AdmitPatient(p2);

            d1.Diagnose(p1);
            d2.Diagnose(p2);

            Console.WriteLine(p1.GetDetails());
            Console.WriteLine(p2.GetDetails());


        }
    }
}