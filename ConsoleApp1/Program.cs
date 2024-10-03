int[] num = { 2, 3, 4, 4, 54, 3, 75, 22, 99 };
//foreach (var item in num)
//{
//    if (item % 2 == 0)
//    {
//        Console.WriteLine("even");
//    }
//    else
//    {
//        Console.WriteLine("odd");
//    }

//}

for (int i = 0; i < num.Length; i++)

{
    if (num[i] % 2 == 0)
    {
        Console.WriteLine("even "  + i);      
    }else
        Console.WriteLine("odd " + i);
} 