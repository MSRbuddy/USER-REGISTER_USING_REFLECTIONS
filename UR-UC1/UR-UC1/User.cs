using System;
using System.Text.RegularExpressions;
using UR_UC1;


public class User
{
    public string FirstName
    {
        get;
        set;
    }
    public User(string firstname)
    {
        this.FirstName = @"^[A-Z][a-zA-Z]{3,20}$";
    }
    public void printFirstName()
    {
        Console.WriteLine("FirstName is :{0}", this.FirstName);
    }
}