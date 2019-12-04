/*****************
* 프로그램명 : TimerPrint.cs

* 작성자 : 천은정 ( 권순규, 김성수, 유병주, 전승원 )

* 작성일 : 2019년 11월 30일

* 프로그램 설명 : 게임 종료 시 타이머의 시간을 출력하는 코드이다.

***********************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerPrint : MonoBehaviour
{
    public float overtime;
    public Text Timer_text;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerStats.Instance.Health == 0)
        {
            overtime = Timer.time;
            Timer_text.text = string.Format("{00:00:00}", overtime);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
