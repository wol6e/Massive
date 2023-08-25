
string[] AB;
string[] AB2;
int count;
count = 0;
string s;
AB = new string[count];
Console.WriteLine("Элементы будут вводиться в массив до ввода пустой строки. Введите строки: ");

do
{
s = Console.ReadLine();
   if(s!= "") 
   {
      count ++;
      AB2 = new string[count];   
      AB2[count-1] = s; 
      for(int i = 0; i < AB2.Length - 1; i ++)
        AB2[i] = AB[i];
        AB = AB2;
    }
} while(s!= "");  

Console.Write("[");
Console.Write(string.Join(" ," , AB));
Console.Write("] -> [");

for( int i = 0; i < AB.Length - 1; i++)
{
    if(AB[i].Length <= 3)
    { 
        Console.Write(AB[i] + ", ");
    }
    else
    {
        Console.Write(" ");
    }
}
    Console.Write("]");

