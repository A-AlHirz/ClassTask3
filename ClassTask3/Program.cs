//Task1:
#region AllFunctions
string FullName(string name)
{
    return name;
}
#endregion


#region CallFunctions
Console.WriteLine("Enter Name");
string fname = Console.ReadLine();
Console.WriteLine("Hello " + FullName(fname));

#endregion


//Task2:
#region AllFunctions
double Volume(double L , double W, double H )
{
    double vol = L * W * H;

    return vol;
}
#endregion


#region CallFunctions
Console.WriteLine("----------------");

Console.Write("Length: ");
double L = Convert.ToInt32(Console.ReadLine());

Console.Write("Width: ");
double W = Convert.ToInt32(Console.ReadLine());

Console.Write("Height: ");
double H = Convert.ToInt32(Console.ReadLine());

Console.Write("The volume of the box= "+Volume( L,  W,  H));

#endregion


//Task3:
#region AllFunctions
double Number(double numb)
{
    double num
}

#endregion



#region CallFunctions
Console.WriteLine("----------------");

Console.Write("Length: ");
double L = Convert.ToInt32(Console.ReadLine());


#endregion
