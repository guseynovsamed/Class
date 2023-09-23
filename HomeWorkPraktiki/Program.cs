




//static string ReverseStr(string str)
//{
//    string result = string.Empty;


//    for(var  i = str.Length - 1; i >= 0;i--)
//    {
//        result += str[i];
//    }
//    return result;
//}

//Console.WriteLine(ReverseStr("Semed"));


//static string UpperStringFirstChar(string str)
//{
//    string name = char.ToUpper(str[0]) + str.Substring(1);
//    return name;
//}

//Console.WriteLine(UpperStringFirstChar("semed"));



//static string FirstElementToUpper(string str)
//{
//    char[] charArray = str.ToCharArray();

//    string firstChar = charArray[0].ToString().ToUpper();

//    charArray[0] = Convert.ToChar(firstChar);

//    string result = string.Empty;


//    foreach (char item in charArray)
//    {
//        result += item;
//    }


//    return result;
//}


//Console.WriteLine(FirstElementToUpper("semed"));



//static string FirsElementToUpper(string name)
//{
//    char[] name1= name.ToCharArray();

//    string firstChar = name1[0].ToString().ToUpper();
//    string secondChar = name1[name1.Length-1].ToString().ToUpper();

//    name1[0]= Convert.ToChar(firstChar);

//    name1[name.Length-1]= Convert.ToChar(secondChar);


//    string result = string.Empty;

//    foreach (char item in name1)
//    {
//        result += item; 
//    }

//    return result;


//}


//Console.WriteLine(FirsElementToUpper("zaur"));



//using System.Text;

//StringBuilder stringBuilder = new StringBuilder("Qara");

//stringBuilder.Append("bag");

//Console.WriteLine(stringBuilder);


//int[] ages = { 12, 13, 55 };*/

//int[] ages2 = new int[5];

//int[] ints = new int[5] {1,2,3,4,5,};


using HomeWorkPraktiki;
using System;
using System.Globalization;



//Console.WriteLine(nums.Length);

//foreach (int item in nums)
//{
//    Console.WriteLine(item);
//}


//var result = nums.Sum(x=> x);

//Console.WriteLine(result);

//var result = nums.Rank;

//Console.WriteLine(result);

//Array.Sort(nums);

//Array.Reverse(nums);

//var newArr = nums.Clone() as int[];

//int[] nums = { 10, 2, 3, 4, 5, 6 };

//int[] newArr = { 1, 2, 3 } ;

//int arrayCount = newArr.Length;

//Array.Resize(ref newArr, nums.Length+ newArr.Length);

//nums.CopyTo(newArr , arrayCount );

//foreach (int item in newArr)
//{
//    Console.WriteLine(item);
//}


//static int[] CopyToArray(int[] destination , int[] source)
//{
//    int destinationLength = destination.Length;
//    Array.Resize(ref destination, destination.Length + source.Length);
//    source.CopyTo(destination, destinationLength);
//    return destination;
//}


//int[] arr1 = {2,3,4,5,6};
//int[] arr2 = {4,5,6,7,8};


//var result = CopyToArray(arr1, arr2);

//foreach (int item in result)
//{
//    Console.WriteLine(item);
//}





//ar result  = Array.Exists(number,x => x == 1);

//var result =Array.Find(number, x => x == 1);

//var result = Array.FindAll(number, x => x == 1);

//var result = Array.FindIndex(number, x => x == 1);

//int[] arr = new int[2];

//Array.Fill(arr , 2);

//foreach (int item in arr)

//Console.WriteLine(item);



//int[] number = { 2, 3, 4, 5, 6, 7 };

//var result = number.OrderBy(x => x);

//var result = number.OrderByDescending(x => x);

//var result = number.FirstOrDefault(x => x == 3);

//var result = number.FirstOrDefault(x => x >3);


//var result = number.Contains(5);

//var result = number.Max();

//var result = number.Min();

//var result = number.Where(x => x % 2 == 0).Sum(m=>m);


//var result = number.Where(x => x % 2 == 0).ToArray();

//foreach (var item in result)
//{
//    Console.WriteLine(result);
//}

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//string name1 = "Tunzale";
//string surname1 = "Memmedova";
//string email = "tunzale@gmail.com";


//string name2 = "Arzu";
//string surname2 = "Kerimova";
//string email2 = "arzu@gmail.com";



//string name3 = "Ilham";
//string surname3 = "Abasli";
//string email3 = "Ilham@gmail.com";


//var stu1 = new
//{
//    name = "Tunzale",
//    surname = "Memmedova",
//    email = "tunzale@gmail.com"
//};

//var stu2 = new
//{
//    name = "Arzu",
//    Surname = "Kerimova",
//    Emil = "arzu@gmail.com"
//};


//var stu3 = new
//{
//    name = "Ilham",
//    surname = "Abasli",
//    email = "Abasli@gmail.com"
//};

//Console.WriteLine(stu3.name);


//Student stu1 = new Student();

//stu1.name = "Tofiq";
//stu1.surname = "Nesibli";
//stu1.email = "tofiq@gmail.com";
//stu1.age = 30;



//Student stu2 = new Student();

//stu2.name = "Omer";
//stu2.surname = "Elesgerli";
//stu2.email = "omer@gmail.com";
//stu2.age = 20;

//stu1.GetFullName();
//stu1.GetFullData();

//stu2.GetFullData();
//stu2.GetFullName();








//Student stu2 = new Student();

//stu2.name = "Rufet";

//Console.WriteLine(stu2.name);
