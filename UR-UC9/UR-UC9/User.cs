using System;
using System.Text.RegularExpressions;
using UR_UC9;

public class User
{
    public string SampleEmail
    {
        get;
        set;
    }
    public User(string sampleemail)
    {
        this.SampleEmail = @"^[a-z|a-z.a-z]@[a-z|a-z.a-z]|[.a-z]$";
    }
    public void printSampleEmail()
    {
        Console.WriteLine("Email is :{0}", this.SampleEmail);
    }
}