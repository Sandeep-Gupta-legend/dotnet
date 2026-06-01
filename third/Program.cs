List<string> Employees = new List<string>();
Employees.Add("Sandeep");
Employees.Add("Rohit");
Employees.Add("Rahul");
Console.WriteLine("Employees in the company:");
foreach(string employee in Employees)
{
    Console.WriteLine(employee);
}

Dictionary<int,string> Employe = new Dictionary<int,string>();
Employe.Add(1,"power");
Employe.Add(2,"energy");
Employe.Add(3,"strength");
Console.WriteLine("Employee details:");
foreach(KeyValuePair<int,string> emp in Employe)
{
    Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value}");
}