using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                /*
                    Console.WriteLine("Hello World"); // γραφει και αλλαζει γραμμη
                    Console.Write("my name is Akis"); // γραφει χωρις να αλλαζει γραμμη
                    Console.WriteLine("");
                    Console.WriteLine(2 + 5);
                    Console.WriteLine("2" + 5);
                    Console.WriteLine(2.0 / 5);
                */
            }


            // variables
            {
                /*
                // integer
                int x; // definition
                       //Console.WriteLine(x); // Error: Use of unassigned local variable
                x = 5;// initiallize
                Console.WriteLine(x);
                int y = 15; // define % init
                Console.WriteLine(y);
                int z;
                z = 4;
                z = z + y; // 4 + 15 --> z = 19
                Console.WriteLine(z);
                */
            }

            //string
            {
                /*
            string str;
            str = "hello!!";
            Console.WriteLine(str);
            str = "15";
            Console.WriteLine(str + 4); // δεν κανει πραξη με string variable
            str = str + 4; // ενωνει concat
            Console.WriteLine(str); // 154 string
            // string 1str; //Name cannot start with number
            // string s+t; // cannot contain symbols (except _)
            string str1 = "akis";
            Console.WriteLine("my name is : " + str1); // ειναι κακο να χρησιμοποιειται
            Console.WriteLine("my name is : {0}", str1);
            Console.WriteLine("my name is : {0} and my age is : {1}", str1, z);

            str = "Pavlos" + z; // ok
            // Error : z = 10 +str; cannot add string to int and save it in int variable

            Console.WriteLine("Please give your name!!");
            string user_name = Console.ReadLine();

            Console.WriteLine("Please give your age!!");
            string user_age = Console.ReadLine();
            //int user_age = Console.ReadLine(); // Γενικα το input απο τον χρηστη ειναι παντα string
            
            // μετατρεπει το string σε integer
            //used more as command
            int int_age = Convert.ToInt32(user_age);       
            // same
            int_age = Int32.Parse(user_age);
            Console.WriteLine("Name : {0}, Age : {1}", user_name, user_age);
            */
            }
            {
                /*
            //boolean
            bool check_something;
            check_something = true; // boolean can gave only 2 values  true/false
            Console.WriteLine("bool value is : {0}", check_something);
            //Error we can only assign value
            //check_something = 1 + checksomething;
            string str = check_something + "akis";
            Console.WriteLine("my string value is : {0}", str);
            //error cannot join integer with boolean
            //int x = 10 + check_something;
                */
            }
            //Practise
            /*
            //Console.WriteLine("Please give a number");
            //int x = Convert.ToInt32(Console.ReadLine());
            // read 2 numbers and i want to find +. -, *, /.
            Console.WriteLine("Please give 2 numbers");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the numbers is: " + (y + z));
            Console.WriteLine("The subtraction of the numbers is: " + (y - z));
            Console.WriteLine("The multiplication of the numbers is: " + (y * z));
            Console.WriteLine("The division of the numbers is: " + (y / z));
            */
            //Practise 2
            /*
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            bool adult = age >= 18;
            Console.WriteLine("I can sell alcohol to you = {0}", adult);
            */
            /*
            int age_for_alcohol = 18;
            Console.WriteLine("Tell me your age");
            int age = Convert.ToInt32(Console.ReadLine());
            bool allow = age >= age_for_alcohol;
            Console.WriteLine("Ok {0}", allow);
            */
            /*
            Console.WriteLine("How old are you?");
            int x = Convert.ToInt32(Console.ReadLine());
            bool y = x >= 18;
            Console.WriteLine("You are {0} can you buy alcohol? {1} ", x, y);
            */

            { /*
            int x = 3;int z = 5;
            bool res = (z != x) && true; // && = and λογικη πραξη
            Console.WriteLine("Result is {0}",res);
                */
            }
            /*
            Console.WriteLine("Please type two integers, the application will swap them!");
            Console.WriteLine("Please put an integer to variable A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A = {0}", A);
            Console.WriteLine("Please put an integer to variable B:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B = {0}", B);
            int tempA = A;
            int tempB = B;
            A = tempB;
            B = tempA;
            Console.WriteLine("Swaping!...");
            Console.WriteLine("A = {0}", A);
            Console.WriteLine("B = {0}", B);
            
            Console.WriteLine("lets do some number swapping!");
            Console.WriteLine("please type 2 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your numbers are: {0} and {1}", a, b);
            int swapA = a;
            int swapB = b;
            a = swapB;
            b = swapA;
            Console.WriteLine("your swapped numbers are {0} and {1}", a, b);
            
            Console.WriteLine("Give us 3 numbers and we'll multiply them!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The multiplication result is:" + (a*b*c));
            

            float x = 10 + 3; //int data in float variable
                              //int y = 2.5; Error int cannot accept decilam values
                              //float y = 10.3 + 3; ErrorEventArgs float cannot accept double vallues
            x = 10.2f + 3;
            Console.WriteLine(x);

            string str = "akis" + x;
            Console.WriteLine(str);
            

            //true false
            Console.WriteLine(12 > 3);
            Console.WriteLine(3 < 3);
            Console.WriteLine(3 <= 3);
            Console.WriteLine(3 != 3);
            

            //logical operator
            //&& = and operator
            bool x = 12 > 3 && 4 != 5; //true
            Console.WriteLine(x);
            x = 12 > 3 && 4 > 5; //false
            Console.WriteLine(x);
            x = 12 < 3.0 && 4 < 5;
            Console.WriteLine(x);
            x = "akis" != "3";
           


            //  || = or operator
            bool x = 12 > 3 || 4 != 5; //true
            Console.WriteLine(x);
            x = 12 > 3 || 4 > 5; //true
            Console.WriteLine(x);
            x = 12 < 3.0 || 4 < 5; //true
            Console.WriteLine(x);
            x = 12 < 3.0 || 4 > 5;//false
            Console.WriteLine(x);
            

            // ! = not operator
            x = !true; //false
            Console.WriteLine(x);
            x = !(12 > 3);//false
            Console.WriteLine(x);
            x = !(4 > 5);//true
            Console.WriteLine(x);
            

            //Combine  bool operators
            bool x = !(12 > 3 || 4 != 5);
            x = !(4 > 5) && 7 / 2 > 1;
            x = (4 > 5 && 3 < 7) || 3 > 1;
            x = (4 > 5 && 3 < 7) || 3 > 1;
            x = (12 / 3 > 2 || 5 - 4 == 7) && 6 - 2 * 3 > 10;
          Console.WriteLine(x);
            */

            /*
            //Arrays
            int[] arr; //definition of the array
            arr = new int[5];
            arr[0] = 1; // 1st array position
            arr[1] = 10;
            arr[2] = -3;
            arr[3] = 0;
            arr[4] = 9;
            Console.WriteLine(arr[3]);

            string[] ar = new string[3];
            ar[0] = "5";
            ar[1] = "akis";
            ar[2] = "3";
            */
            //float array [4] and find the sum
            /*
            float[] fl;
            fl = new float[4];
            Console.WriteLine("please enter 4 numbers");
            fl[0] = float.Parse(Console.ReadLine());
            fl[1] = float.Parse(Console.ReadLine());
            fl[2] = float.Parse(Console.ReadLine());
            fl[3] = float.Parse(Console.ReadLine());
            Console.WriteLine(fl[0] + fl[1] + fl[2] + fl[3]);
            */
            /*
            bool[] bl;

            bl = new bool[4];
            Console.WriteLine("please enter 4 numbers");
            bl[0] = float.Parse(Console.ReadLine()) > 5;
            bl[1] = float.Parse(Console.ReadLine()) > 5;
            bl[2] = float.Parse(Console.ReadLine()) > 5;
            bl[3] = float.Parse(Console.ReadLine()) > 5;

            Console.WriteLine("{0} {1} {2} {3}", bl[0], bl[1], bl[2], bl[3]);
            

            string[] str;
            str = new string[5];
            str[0] = "*";
            str[1] = "**";
            str[2] = "***";
            str[3] = "****";
            str[4] = "*****";

            Console.WriteLine(str[0]);
            Console.WriteLine(str[1]);
            Console.WriteLine(str[2]);
            Console.WriteLine(str[3]);
            Console.WriteLine(str[4]);
            */

            // [2,5,7,9] [5.2,4.5,32,0.1,3.2]
            /*

            int[] ar1;
            double[] ar2;
            double[] ar3;
            ar1 = new int[4];
            ar2 = new double[5];
            ar3 = new double[5];

            ar1[0] = 2;
            ar1[1] = 5;
            ar1[2] = 7;
            ar1[3] = 9;

            ar2[0] = 5.2;
            ar2[1] = 4.5;
            ar2[2] = 32;
            ar2[3] = 0.1;
            ar2[4] = 3.2;

            ar3[0] = ar1[0] + ar2[0];
            ar3[1] = ar1[1] + ar2[1];
            ar3[2] = ar1[2] + ar2[2];
            ar3[3] = ar1[3] + ar2[3];
            ar3[4] = ar2[4];
            */
            /*
            //Lists 
            
            List<int> myList = new List<int>();
            myList.Add(5);
            myList.Add(4);
            myList.Add(7);
            myList.Add(2);
            Console.WriteLine(myList[1]);

            List<bool> list = new List<bool>();
            list.Add(float.Parse(Console.ReadLine()) > 5);
            list.Add(float.Parse(Console.ReadLine()) > 5);
            list.Add(float.Parse(Console.ReadLine()) > 5);
            list.Add(float.Parse(Console.ReadLine()) > 5);

 

            Console.WriteLine("List:[{0}],[{1}],[{2}],[{3}]", list[0], list[1], list[2], list[3]);
            
            
            List<string> myList = new List<string>();
            myList.Add("orange");
            myList.Add("blue");
            myList.Add("green");
            Console.WriteLine(myList[1]);
            Console.WriteLine(myList.Count());

            
            //sort list
            //myList.Sort();
            //Console.WriteLine("after sort {0}", myList[1]);

            //reverse
            //myList.Reverse();
            //Console.WriteLine("after reverse {0}", myList[0]);

            //Remove delete an element
            //myList.Remove("blue");
            //Console.WriteLine("after remove {0}", myList[1]);
            //Console.WriteLine(myList.Count());

            //Search element
            //int x = myList.IndexOf("blue");
            //Console.WriteLine(x);
            //x = myList.IndexOf("pink");
            //Console.WriteLine(x);

            //Insert at position
            myList.Insert(1, "red");
            Console.WriteLine("after remove {0},{1},{2},{3}", myList[0], myList[1], myList[2], myList[3]);
            
            //my excersise
            Console.WriteLine("Please enter your birthyear");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int currentYear = 2020;
            int Age = (currentYear - birthYear);
            Console.WriteLine(Age);

            */
            //If statements
            /*
            Console.WriteLine("Please show me your ID.");
            int clientAge = Convert.ToInt32(Console.ReadLine());
            // if (clientAge > 18)
            // {
            //      Console.WriteLine("what kind of booze would you like?");
            // }
            //same
            //if (clientAge > 18)
            //    Console.WriteLine("what kind of booze woul44d you like?");
            // Console.WriteLine("wsadasd fasf?");

            if (clientAge > 18)
            {
                Console.WriteLine("what kind of booze would you like?");
                string booze = Console.ReadLine();
                Console.WriteLine("you ordered {0}", booze);
            }
            else
            {
                Console.WriteLine("have some milk, would you?");
            }

            */


            //Μodulo Εμφανιζει το υπολοιπο μιας διαιρεσης
            // Console.WriteLine(13 % 5); 3

            //year 
            /*
            Console.WriteLine("Please enter a year to test if its double");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("That year is double");
                
            }
            else
            {
                Console.WriteLine("That year is not double");
            }
            */
            /*
            Console.WriteLine("Please enter temperature");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp <= 0)
            {
                Console.WriteLine("freezing");
            }
            if (0 < temp && temp < 11)
            {
                Console.WriteLine("cold");
            }
            if (10 < temp && temp < 19)
            {
                Console.WriteLine("cool");
            }
            if (18 < temp && temp < 31)
            {
                Console.WriteLine("warm");
            }
            if (temp >= 31)
            {
                Console.WriteLine("hot");
            }
            */

            //read 3 numbers and calculate average 50
            /*
            Console.WriteLine("please enter 3 scores");
            int score1 = Convert.ToInt32(Console.ReadLine());
            int score2 = Convert.ToInt32(Console.ReadLine());
            int score3 = Convert.ToInt32(Console.ReadLine());

            float average = (score1 + score2 + score3) / 3.0f;

            if (average >= 50)
            {
                Console.WriteLine("you pass");

            }
            else
            {
                Console.WriteLine("you fail");

            }
            */

            //else if
            /*
            Console.WriteLine("Please enter temperature");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp <= 0)

                Console.WriteLine("freezing");

            else if (temp <= 10)

                Console.WriteLine("cold");

            else if (temp < 18)

                Console.WriteLine("cool");
            else if (temp < 30)
                Console.WriteLine("warm");
            else
                Console.WriteLine("hot");
            */

            //Calculator + / i will read 2 numbers and 1 operator
            /*
            Console.WriteLine("Please give the operator: ");
            string calcType = Console.ReadLine();
            Console.WriteLine("Please enter a number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int seconNum = Convert.ToInt32(Console.ReadLine());

            if (calcType == "+")
            {
                int sum = firstNum + seconNum;
                Console.WriteLine("Sum = {0}", sum);
            }
            else if (calcType == "/")
            {
                if (seconNum != 0)
                {     

                float div = firstNum / (seconNum / 1.0f);
                Console.WriteLine("Div = {0}", div);
                }
                else
                    Console.WriteLine("Cannot divide with zero");

            }
            else
                Console.WriteLine("wrong operator");
            */
            // read speed and show fine 
            // 60 - 100 f = 80
            // 101 - 140 f = 160
            // 141 ++ f 250
            /*
            Console.WriteLine("please enter the speed");
            int speed = Convert.ToInt32(Console.ReadLine());

            if (speed >= 60 && speed <= 100)
            {
                Console.WriteLine("your fine is 80 euro");
            }
            else if (speed >= 101 && speed <= 140)
            {
                Console.WriteLine("your fine is 160 euro");
            }
            else if (speed >= 141)
            {
                Console.WriteLine("your fine is 250 euro");
            }
            */

            // read kwh 
            // 1000 - 2000 2euro
            // 2001 - 5000 3euro
            // 5001 - 10000 4euro

            /*

            Console.WriteLine("please show your KWH");
            int power = Convert.ToInt32(Console.ReadLine());
            if (power >= 1000 && power <= 10000)
            {
                if (power > 5000)
                    Console.WriteLine((power - 1000) * 4);
                else if (power > 2000)
                    Console.WriteLine((power - 1000) * 3);
                else
                    Console.WriteLine((power - 1000) * 2);
            }
            */


            //Loops and more
            /*
            for (int i =1; i<=20; i++)
            {
                Console.WriteLine(i);
            }
            //same
            //for (int i = 1; i <= 20; i++)
            //    Console.WriteLine(i);
            //same2
            for (int i = 0; i < 20; i++)
                Console.WriteLine(i);
            */

            /*
            float[] arr = new float[5] { 3, 6, 4, 9, 2 };

            float max = arr[0];
            for (int i =1; i <=4; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            Console.WriteLine(max);
            */
            /*
            Console.WriteLine("please enter 5 numbers");
            int[] arr = new int[5];
            for (int i = 1; i <= 5; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            arr[i]
       //...... to be continued
            */


            //while loop

            /*
            float[] arr = new float[5] { 3, 6, 4, 9, 2 };

            float max = arr[0];
            //for (int i = 1; i <= 4; i++)
            int i = 1;
            while(i<5)
            {
                if (max < arr[i])
                    max = arr[i];
                i++;
            }
            Console.WriteLine(max);

            int z= 1;
            while (z <= 20)
            {
                Console.WriteLine(z);
                z++;
            }
            
            List<float> floatList = new List<float>();
            float a = float.Parse(Console.ReadLine());

            while (a>=0)
            {
                floatList.Add(a);
                Console.WriteLine(a);
                 a = float.Parse(Console.ReadLine());
            }

            for (int i = 0; i < floatList.Count(); i++)
                Console.WriteLine(floatList[i]);
            */

            //calling Method



            //christmassTree();
            //aSeries();

            string z = "*";
            for (int i = 0; i < 4; i++)
            {
                z = z + "*";
                Console.WriteLine(z);
            }








        }
        //method for finding sum of 5 numbers
        public static void sumMethod()
        {
            double sum = 0;
            for (int i = 10; i < 15; i++)
            {
                double numb = Convert.ToDouble(Console.ReadLine());
                sum = sum + numb;
            }
            Console.WriteLine("sum:{0}", sum);
        }
        public static void christmassTree()
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                { 
                    Console.Write("1");
                }         
            Console.WriteLine();

            }
        }
        public static void aSeries()
        {
            for (int i = 1; i < 5; i++)
                Console.WriteLine(i);
        }

        public static void arrayMethod()
        {
            int arrayLength = Convert.ToInt32(Console)
        }

        public static int SumMethod()
        {
            Console.WriteLine("please enter 2 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            return sum;


        }
    }
}
