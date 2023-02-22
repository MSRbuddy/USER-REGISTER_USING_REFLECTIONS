using System;
using System.Text.RegularExpressions;
using UR_UC6;

public class User
{
    public string PwdRule2
    {
        get;
        set;
    }
    public User(string pwdrule2)
    {
        this.PwdRule2 = @"^[A-Z]{1,7}[a-z]{7,20}$";
    }
    public void printPwdRule2()
    {
        Console.WriteLine("Password is :{0}", this.PwdRule2);
    }
}