namespace kitchen;//refrence from another class
class libraryuser
{
    public static void Main()
    {
        veg v=new veg();
        var ans=v.food();
      var ans1= v.phonenumber();
        Console.WriteLine(ans+" "+ans1);
    }

}
