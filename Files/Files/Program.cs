using System;
using System.IO;

namespace Files
{
    class Program
    {

        static void Main(string[] args)
        {
            // создание файла
            using (StreamWriter sw = new StreamWriter("Directory.txt", true))
            {

            }
            // 
            bool onOffProgram = true;

            // счётчик работников, используется в FileWriter(тут)
            int count = 1;

            while (onOffProgram)
            {
                Console.WriteLine("Введите число 1, чтобы увидеть список сотрудников или введите число 2, чтобы вписать нового сотрудника. 3 - закрыть программу.");
                int interfaceNum = int.Parse(Console.ReadLine());

                if (interfaceNum == 1)
                {
                    FileReader();
                }
                else if (interfaceNum == 2)
                {
                    FileWriter(count);
                    count += 1;
                }
                else if (interfaceNum == 3)
                {
                    onOffProgram = false;
                }
                else
                {
                    Console.WriteLine("Неверное значение.");
                }
            }
           
        }

        static void FileReader()
        {

            using (StreamReader sr = new StreamReader("Directory.txt"))
            {
                string line;
                line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
        }

        static void FileWriter(int numberID)
        {
            
            int age = 0;
            int height = 0;

            DateTime data = DateTime.Now;

            string timestring = data.ToString("dd/MM/yyyy HH:mm");
            string name;
            string bornPlace;
            string employee = string.Empty;
  

            using (StreamWriter sw = new StreamWriter("Directory.txt", true))
            {
               
                Console.WriteLine("Введите ФИО сотрудника: ");
                name = Console.ReadLine();
                employee += ($"{numberID}. {timestring} {name} ");

                Console.WriteLine("Введите возраст сотрудника: ");
                age = int.Parse(Console.ReadLine());
                employee += ($"{age} ");

                Console.WriteLine("Введите рост сотрудника: ");
                height = int.Parse(Console.ReadLine());
                employee += ($"{height} ");

                Console.WriteLine("Введите дату рождения сотрудника в отдельных строках. Год, месяц, день: ");
                DateTime birthDay = new DateTime(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                string timeBirthDayString = birthDay.ToString("dd/MM/yyyy");
                employee += ($"{timeBirthDayString} ");

                Console.WriteLine("Введите место рождения сотрудника: ");
                bornPlace = Console.ReadLine();
                employee += ($"город {bornPlace}.");
             
                sw.WriteLine(employee);
                

            }

            
        }
    }
}
