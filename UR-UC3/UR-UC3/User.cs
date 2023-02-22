using System;
using System.Text.RegularExpressions;
using UR_UC3;


public class User
{
    public string Email
    {
        get;
        set;
    }
    public User(string email)
    {
        this.Email = @"^[a-z|a-z.a-z]@[a-z|a-z.a-z]|[.a-z]$";
    }
    public void printEmail()
    {
        Console.WriteLine("Email is :{0}", this.Email);
    }
}