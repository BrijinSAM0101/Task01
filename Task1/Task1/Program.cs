using System.Diagnostics;
using System.Transactions;

namespace Task1
{
    internal class Program
    {

        static string Filename = "RainbowSchool.txt";
        static string FilePath = "C:\\Users\\BRIJINSAM\\source\\repos\\Task1\\Task1\\bin\\Debug\\net6.0\\RainbowSchool.txt";
        public static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Enter your choice :");
             Console.WriteLine(" 1.Write data \n 2.Read data \n 3.Delete File \n 4.Exit");
             int a = int.Parse(Console.ReadLine());
             

            
                switch (a)
                {
                    case 1:
                        Write_Data();
                        Console.WriteLine("Data Uploaded successfully..");
                        flag = true;
                        break;
                    case 2:
                        Read_Data();
                        Console.WriteLine("Data Retrived successfully..");
                        flag= true;
                        break;
                    case 3:
                        if (File.Exists(Filename))
                        {
                            File.Delete(Filename);
                            Console.WriteLine("File Deleted..");
                            break;
                        }
                        flag = true;
                     break;
                    case 4: Console.WriteLine("Exiting....");
                        flag = false;    
                    break;
                    default:
                        Console.WriteLine("Inavlid Choice !!!");
                        flag = false;
                        break;

                }

            } while (flag == true);      
        }
           
        
        
        static void Write_Data()
        {
            
                StreamWriter sw = new StreamWriter(Filename);

                Console.WriteLine("Enter the id of student:");
                string id=Console.ReadLine();
                sw.WriteLine(id);
                Console.WriteLine("Enter the Name of student:");
                string Name = Console.ReadLine();
                sw.WriteLine(Name);
                Console.WriteLine("Enter the Class of student:");
                string Class= Console.ReadLine();
                sw.WriteLine(Class);
                Console.WriteLine("Enter the Section of student:");
                string Section = Console.ReadLine();
                sw.WriteLine(Section);

                sw.WriteLine("==========================");
                sw.Close();
            
           
        }
        static void Read_Data(){
            try
            {
                StreamReader sr = new StreamReader(FilePath);
                string data= sr.ReadLine();
                while (data != null)
                {
                    Console.WriteLine(data);
                    data = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.Message);   
            }
           

        }
    }
}
