using ConsoleApp15;

//try
//{
//    Console.WriteLine("Input first number:");
//    int first_num = int.Parse(Console.ReadLine());

//    Console.WriteLine("Input second number:");
//    int second_num = int.Parse(Console.ReadLine());
//    int result = first_num / second_num;
//    Console.WriteLine("Result division: " + result);
//}
//catch (DivideByZeroException )
//{
//    Console.WriteLine("No no mr.Fish");
//    //Console.WriteLine(ex.StackTrace);
//}
//catch (FormatException)
//{
//    Console.WriteLine("Not number");
//}
//catch (Exception)
//{
//    Console.WriteLine("NOT KNOW EXCEPTION");
//
//
MobilePhone phone = new MobilePhone("Samsung S3", 0, true);
try
{
    phone.Call("+3807554540");
}
catch(LowBatteryException ex)
{
    Console.WriteLine("Your phone " + ex.ExcceptionTarget.Name  + " haven't energy");
}
catch (ArgumentException)
{
    Console.WriteLine("Your phone haven't sim card");
}
catch (FormatException)
{
    Console.WriteLine("Incorrect phone number");
}



