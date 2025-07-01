using System.Linq;

using System;
class Program
{
    static void Main()


    {

        // Console.WriteLine("Please Enter Your Age:");
        //int.TryParse(Console.ReadLine(), out int Age);  //لو القيمه  سترينج هتكون القيمه false ولمنا يحولها انتجر  هتمون  بصفر
        // لو القيمه  رقم  هيرجع  ا=فاليديج  ا الرقم الي  دخلته  

    
          #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

           Console.WriteLine("Enter a number: ");

           if(int.TryParse(Console.ReadLine(),out int number))
           {
                for (int i = 1; i <= number; i++)
                     {
                         Console.WriteLine(i);
                     }

           }
           else
           {
               Console.WriteLine("input  a valid input");
           }

           #endregion

          
# region 2- Write a program that allows the user to insert an integer then  print a multiplication table up to 12.

        Console.WriteLine("Enter a number: ");

        if (int.TryParse(Console.ReadLine(), out int number1))
        {
            for (int i = 1; i <= 12; i++)
            {

                Console.WriteLine(i * number1);
            }

        }
        else
        {
            Console.WriteLine("input  a valid input");
        }


#endregion
      
           #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
               Console.WriteLine("Enter a number: ");

                if(int.TryParse(Console.ReadLine(),out int number2))
                {
                     for (int i = 0; i <=number2; i+=2)
                          {

                              Console.WriteLine(i);
                          }

                }
                else
                {
                    Console.WriteLine("input  a valid input");
                }

           #endregion
    
        #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.

        Console.WriteLine("Enter  your  string : ");
        string str = Console.ReadLine();
        char[] chars = str.ToCharArray(); //[d,y,t]
                                          // Console.WriteLine("char array : "+ chars);
        Array.Reverse(chars); //[t,y,d]
        string newStr = new string(chars); //'tyd'
        Console.WriteLine("your  string  after  reverse =>  " + newStr);



        #endregion

       
             #region 7- Write a program to allow the user to enter int and print the REVERSED of it.
             
                    
            Console.WriteLine("Enter  your  int : ");
            
            int intNum = int.Parse(Console.ReadLine());  //ادخله  انتجر 
            string  numToString  = intNum.ToString(); //احوله لاسترينج 
            char[] ch = numToString.ToCharArray(); //بعد كده  هاخد الاسترينج ده واحوله لاراي  من الحروف
            Array.Reverse(ch);  //اعكس  الاراي 
            string reverssNum = new string(ch); //جمع 
            Console.WriteLine("your  number  after  reverse =>  " + reverssNum); //اطبع 
          

              #endregion
              
    
        #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.
        // عدد اولي   يعني  اكبر من واحد  ومش بيقبل القسمه الا  على نفسه 
        Console.Write("Input starting number of range: ");
        int.TryParse(Console.ReadLine(), out int start);


        Console.Write("Input ending number of range: ");
        int.TryParse(Console.ReadLine(), out int end);


        Console.WriteLine("The prime numbers between " + start + " and " + end + " are => ");

        for (int i = start; i <= end; i++)
        {
            bool isPrime = true;  //افترض  فالول  انه   عدد اولي 

            if (i <= 1) //ويكون اكبر من الواحد
            {
                isPrime = false;
            }

            else
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.Write(i + " ");
            }
        }


        #endregion

   
          #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
           // عشان احول  من    رقم عشر  لبينري  انا بقسم على اتنين واخد الباق ي ولو ما  فيش  باقي  بحط صفر 
            Console.Write("Enter your  decimal number :  ");
              int.TryParse(Console.ReadLine(), out int decnum ); 

              string binaryNum =" "; //هعمل  استرينج   فاضي  اخزن فيه  باقي  القسمه الي  بيطلعلي

              if (decnum==0)
             {
                 binaryNum ="0";
             }
             else
             {
                   while(decnum>0)
                   {
                       int  mod= decnum%2; //0 or 1
                       binaryNum = mod + binaryNum;
                       decnum /=2;
                       Console.WriteLine("binarynum   ="+ binaryNum);
                   }
             }
             Console.WriteLine("binarynum   ="+ binaryNum);

             #endregion

        
        #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.


        Console.Write("Enter size of  matrix => ");
        int.TryParse(Console.ReadLine(), out int n); //عشان لو  دخل حاجه  غلط   يحط القيمه  بصفر 


        for (int i = 0; i < n; i++)  // ده بيلف على الصفوف 
        {
            for (int j = 0; j < n; j++)  // ده بيلف على الأعمدة 
            {
                if (i == j)  // لو الصف = العمود نحط 1
                    Console.Write("1 ");
                else         // لو مش كده نحط 0
                    Console.Write("0 ");
            }
            Console.WriteLine();  // ننزل سطر جديد بعد كل صف
        }


        #endregion

      
            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.
               int[] arr = { 5, 10, 15, 20 };
               int sum = 0;  //اول  حاجه احط  الفاريابول  الي  هجمع فيه واديه  قيمه صفر

               for (int i = 0; i < arr.Length; i++)  //هيعدي  لحد  اخر  عنصر فالاراي بس  الاراي  بتبدا من صفر  فكده الاراي   هيكون الانديكس  بتاع اخر  عنصر  فيها اللينث   ناقص  واحد
               {
                   sum += arr[i];  // arr[0]+arr[1]+arr[2]+arr[3]+arr[4]
               }

               Console.WriteLine("Sum : " + sum);

             #endregion

        #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.






        int[] arr1 = { 3, 1, 5 }; //length =3
        int[] arr2 = { 4, 2, 6 };  //length =3

        // هعمل  اراي  جديده    بالينث بتاع  اراي واحد واتنين  
        int[] merged = new int[arr1.Length + arr2.Length];

        // هنسخالاراي واحد فالاري ميرج
        for (int i = 0; i < arr1.Length; i++)
        {
            merged[i] = arr1[i]; // يعني الانديكس صفر حط فيه اول قيمه وكمل 
        }

        // 5. ننسخ عناصر arr2 للمصفوفة الجديدة (نكمل من بعد arr1)
        for (int i = 0; i < arr2.Length; i++)
        {
            merged[i + arr1.Length] = arr2[i]; //0+3 =>4 , 1+3 => 2 ,2+3=> 6
        }

        // رتب 
        Array.Sort(merged);

        // 7. نطبع العناصر
        Console.WriteLine(" array after sort :");
        for (int i = 0; i < merged.Length; i++)
        {
            Console.Write(merged[i] + " ");
        }

              #endregion


       #region
        #endregion

#region
#endregion


   #region
    #endregion


#region
#endregion


   #region
    #endregion







}
}