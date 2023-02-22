using System;
using System.Text.RegularExpressions;
using UR_UC4;


public class User
{
    public string PhoneNumber
    {
        get;
        set;
    }
    public User(string phoneumber)
    {
        this.PhoneNumber = @"^[9]{1}[1]{1}[ ][1-9]{1}[0-9]{9}$";
    }
    public void printPhoneNumber()
    {
        Console.WriteLine("Phone Number is :{0}", this.PhoneNumber);
    }
}