List<string> list = new List<string>();
for(int i=0; i<3; i++)
{
    Console.WriteLine("enter the name:");
    
    list.Add(Console.ReadLine());


}
foreach(string name in list)
{
    Console.WriteLine(name);
}


Dictionary<int,string> dict = new Dictionary<int,string>();
for(int i=0; i<3; i++)
{
    Console.WriteLine("enter the id:");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("enter the name:");
    string name = Console.ReadLine();
    dict.Add(id,name);
}
foreach(KeyValuePair<int,string> item in dict)
{
    Console.WriteLine($"ID: {item.Key}, Name: {item.Value}");
}