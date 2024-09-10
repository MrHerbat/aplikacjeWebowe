﻿namespace cw3;

public class Person
{
    private string firstname;

    private string lastname;

    public Person(string firstname, string lastname)
    {
        this.firstname = firstname;
        this.lastname = lastname;
    }

    public Person()
    {
        firstname = "";
        lastname = "";
    }

    public override string ToString()
    {
        return Firstname + " " +Lastname;
    }
    public string Firstname
    {
        get { return firstname.ToUpper(); }
        set { firstname = value; } 
    }
    public string Lastname
    {
        get { return lastname.ToUpper(); }
        set { lastname = value; } 
    }
}