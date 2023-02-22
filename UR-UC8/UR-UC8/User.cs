using System;
using System.Text.RegularExpressions;
using UR_UC8;

public class User
{
    public string PwdRule4
    {
        get;
        set;
    }
    public User(string pwdrule4)
    {
        this.PwdRule4 = @"^[A-Z]{1,7}[a-z]{6,20}[0-9]{1,7}[-\@\#\$\.\%\&\*]?$";
    }
    public void printPwdRule4()
    {
        Console.WriteLine("Password is :{0}", this.PwdRule4);
    }
}