using System;
using System.Text.RegularExpressions;
using UR_UC2;


public class User
{
    public string LastName
    {
        get;
        set;
    }
    public User(string lastname)
    {
        this.LastName = @"^[A-Z][a-zA-Z]{3,20}$";
    }
    public void printLastName()
    {
        Console.WriteLine("LastName is :{0}", this.LastName);
    }
}