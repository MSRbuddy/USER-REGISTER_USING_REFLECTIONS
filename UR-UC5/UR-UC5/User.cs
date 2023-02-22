using System;
using System.Text.RegularExpressions;
using UR_UC5;

public class User
{
    public string PwdRule1
    {
        get;
        set;
    } 
    public User(string pwdrule1)
    {
        this.PwdRule1 = @"^[A-Za-z]{8,20}$";
    }
    public void printPwdRule1()
    {
        Console.WriteLine("Password is :{0}", this.PwdRule1);
    }
}