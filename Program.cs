namespace ConsoleApp1608
{
    internal class Program
    {
        static void Main(string[] args)

        {
         
            Worker[] workers = new Worker[5];
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = new Worker();
                try
                {
                    Console.WriteLine("Enter age");
                    workers[i].Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter date");
                    workers[i].Date = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter wage");
                    workers[i].Wage = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter lastname");
                    workers[i].Lastname =(Console.ReadLine());
                    Console.WriteLine("Enter surname");
                    workers[i].Surname =(Console.ReadLine());
                    Console.WriteLine("Enter firstname");
                    workers[i].Firstname =(Console.ReadLine()); }
                catch (Exception ex) {

                    Console.WriteLine(ex.Message);
                    
                }
               
            }
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].Print();
            }
        }
    }

    class Worker
    {
        private int age;
        public void Print()
        {
            Console.WriteLine(age);
            Console.WriteLine(wage);
            Console.WriteLine(Lastname);
            Console.WriteLine(Surname);
            Console.WriteLine(Firstname);
            Console.WriteLine(date);
        }
        public int Age
        {
            get { return age; }
            set {
                if (value > 18) {
                    age = value;
                }
                else
                {
                    throw new Exception("Incorrect age");
                }
            }

        }

        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
       
        private int wage;
        

        public int Wage
        {
            get { return wage; }
            set {
                if (value > 0)
                {
                    wage = value;
                }
                else
                {
                    throw new Exception("Incorrect wage");
                }

            }
        }

        private DateTime date;
       

        public DateTime Date
        {
            get { return date ; }
            set {
                if (value >= DateTime.Now)
                {
                    date = value;
                }
                else
                {
                    throw new Exception("incorrect date");
                }
            
            }
        }





    }
}