using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class question
{
    public string q;
    public string But1;
    public string But2;
    public string But3;
    public string check;
    public bool isComeout;

    public question(string q, string But1, string But2, string But3, string check)
    {
        this.q = q;
        this.But1 = But1;
        this.But2 = But2;
        this.But3 = But3;
        this.check = check;
        this.isComeout = false;
    }
}