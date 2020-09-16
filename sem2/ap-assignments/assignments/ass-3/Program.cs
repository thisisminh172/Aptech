using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_3
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            Console.ReadKey();
        }
        int max = 5;
        int cnt = 0;
        StudentPremium[] stList;

        public Program()
        {
            stList = new StudentPremium[max];
        }
        void add()
        {
            if(cnt == max)
            {
                Console.WriteLine("Number of students is maximum");
                return;
            }
            var st = new StudentPremium();
            st.accept();
            stList[cnt] = st;
            cnt++;
        }

        void display()
        {
            if(cnt == 0)
            {
                Console.WriteLine("There is no student in this class");
                return;
            }
            for(int i = 0; i < cnt; i++)
            {
                stList[i].print();
            }
        }

        void display(string id)
        {
            if (cnt == 0)
            {
                Console.WriteLine("There is no student in this class");
                return;
            }

            for (int i = 0; i < cnt; i++)
            {
                if (stList[i].id.Equals(id))
                {
                    stList[i].print();
                }
            }

        }

        void display(int avg)
        {
            if (cnt == 0)
            {
                Console.WriteLine("There is no student in this class");
                return;
            }

            for (int i = 0; i < cnt; i++)
            {
                if ((stList[i].pMarkOfObj + stList[i].pMarkOfPrac)/2 >= avg )
                {
                    stList[i].print();
                }
            }
        }

        static void menu()
        {
            Program p = new Program();
            string op = "";
            while (true)
            {
                Console.WriteLine("---MENU---");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. display all studnets");
                Console.WriteLine("3. Display student by id");
                Console.WriteLine("4. Display studnet by avg");
                Console.WriteLine("5. exit");
                Console.Write("Enter your choice --->");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        p.add();
                        break;
                    case "2":
                        p.display();
                        break;
                    case "3":
                        string id = Console.ReadLine().Trim();
                        p.display(id);
                        break;
                    case "4":
                        int avg = int.Parse(Console.ReadLine().Trim());
                        p.display(avg);
                        break;
                    case "5":
                        Console.WriteLine("##### Exit Program ######");
                        return;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
        }
    }
}
