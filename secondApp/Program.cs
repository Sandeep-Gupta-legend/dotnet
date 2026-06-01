String[] names = {"sandeep","rishi","shivam"};
foreach(String name in names)
{
    Console.WriteLine(name);

}

Console.WriteLine("enter the number:");
int number= int.Parse(Console.ReadLine());
Console.WriteLine($"the multiplication table of {number} is:");
for(int i=1;i<=10;i++)
{
    int b=i*number;
    Console.WriteLine(b);
}