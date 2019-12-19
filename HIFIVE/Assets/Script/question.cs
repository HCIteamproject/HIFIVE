/*****************
* 프로그램명 : questino.cs

* 작성자 : 권순규 ( 천은정, 김성수, 유병주, 전승원 )

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 퀴즈 문제의 생성자이다.

***********************************/

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