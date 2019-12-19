/*****************
* 프로그램명 : Timer.cs

* 작성자 : 천은정 ( 권순규, 김성수, 유병주, 전승원 )

* 작성일 : 2019년 11월 15일

* 프로그램 설명 : 게임 시작 시 타이머가 작동되는 코드이다.

***********************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time;
    public Text Timer_text;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerStats.Instance.Health != 0)       // 생명이 0이 되면 타이머 종료
        {
            time += Time.deltaTime;
            Timer_text.text = string.Format("{00:00:00}", time);

        }

    }

}
