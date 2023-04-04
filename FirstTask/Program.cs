#region(While)

//int num = 15;

//Console.WriteLine("Enter Number");
//int num = Convert.ToInt32(Console.ReadLine());

//while (9 < num && num < 21)
//{
//    while (num % 2 == 0)
//    {
//        Console.WriteLine("Cüt ədəddir");
//        break;
//    }
//    Console.WriteLine("Tək ədəddir");
//    break;
//}
//while (9 >= num || num >= 21)
//{
//    Console.WriteLine("Ədəd bura daxil deyil");
//    break;
//}
#endregion

#region(Do/While)
//int num = 16;

//Console.WriteLine("Enter Number")
//int num = Convert.ToInt32(Console.ReadLine());

//do
//{
//	while (9 < num && num < 21)
//	{
//		while (num % 2 == 0)
//		{
//			Console.WriteLine("Cüt ədəddir");
//			break;
//		}
//		while (num % 2 != 0)
//		{
//			Console.WriteLine("Tək ədəddir");
//			break;

//		}
//		break;
//	}

//} while (false);

//while (9 >= num || num >= 21)
//{
//	Console.WriteLine("Ədəd bura daxil deyil");
//}
#endregion

#region(ClassTask)
//Console.WriteLine("Enter Number");
//int num = Convert.ToInt32(Console.ReadLine());
//bool tresault = true;
//bool fresault = false;
//string result = "he";

//do
//{
//	while (fresault)
//	{
//		while (9 >= num || num >= 21)
//		{
//			Console.WriteLine("Ədəd bura daxil deyil");
//			result = Console.ReadLine();
//			continue;
//		}
//	}
//	while (tresault)
//	{
//		while (9 < num && num < 21)
//		{
//			while (num % 2 == 0)
//			{
//				Console.WriteLine("Cüt ədəddir");
//				break;
//			}
//			while (num % 2 != 0)
//			{
//				Console.WriteLine("Tək ədəddir");
//				break;
//			}
//			break;
//		}
//	}
//} while (fresault);
#endregion

#region(For If)
//Console.WriteLine("Enter Number");
//int num = Convert.ToInt32(Console.ReadLine());
//bool flag = true;
//do
//{
//	if (9 < num && num < 21)
//	{
//		if (num % 2 == 0)
//		{
//			flag = false;
//			Console.WriteLine("Eded Cutdur");
//		}
//		else
//		{
//			flag = false;
//			Console.WriteLine("Eded Tekdir");
//		}
//	}
//	else
//	{
//        Console.WriteLine("Eded Sehv Daxil Edilib. Duzgun Ededi Daxil Edin");
//        string answer = Console.ReadLine();


//        if (answer.ToLower() != "yes")

//        {
//            flag = false;
//        }
//    }

//} while (flag);

#endregion

#region(Array)
//string[] employees = new string[0];
//for (int i = 0; i < employees.Length + 1; i++)
//{
//    Console.WriteLine("Enter new employee!");
//    string newEmployee = Console.ReadLine();
//    Array.Resize(ref employees, i + 1);
//    employees[i] = newEmployee;
//    Console.WriteLine("Do you want to continue Yes/No");
//    string answer = Console.ReadLine();
//    if (answer.ToUpper() != "YES") ;
//    {
//        break;
//    }
//}
//for (int i = 0; i < employees.Length; i++)
//{
//    Console.WriteLine(employees[i]);
//}
#endregion