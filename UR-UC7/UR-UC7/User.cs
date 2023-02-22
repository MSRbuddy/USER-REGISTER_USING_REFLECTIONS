using System;
using System.Text.RegularExpressions;
using UR_UC7;

public class User
{
    public string PwdRule3
    {
        get;
        set;
    }
    public User(string pwdrule3)
    {
        this.PwdRule3 = @"^[A-Z]{1,7}[a-z]{6,20}[0-9]{1,7}$";
    }
    public void printPwdRule3()
    {
        Console.WriteLine("Password is :{0}", this.PwdRule3);
    }
}