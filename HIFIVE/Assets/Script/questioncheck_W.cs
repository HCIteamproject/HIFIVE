/*****************
* 프로그램명 : questioncheck_W.cs

* 작성자 : 권순규, 천은정 ( 김성수, 유병주, 전승원 )

* 작성일 : 2019년 12월 7일

* 프로그램 설명 : winter맵의 아이트래커와 키넥트를 이용해 퀴즈의 정답을 체크하는 코드입니다.

***********************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questioncheck_W : MonoBehaviour
{
    public string check1 = "1";
    public string check2 = "2";
    public string check3 = "3";
    private bool checkin;
    public GameObject o;
    public GameObject x;
    public GameObject Panel;

    private void Update()
    {
        
   
        if (BodySourceView.rxh < 3)
        {
            checkin = true;
        }

        if (checkin)
        {
            if (PrintGazePosition.xCoord1 < 820 && PrintGazePosition.yCoord1 < 800 && PrintGazePosition.yCoord1 > 600 && PrintGazePosition.xCoord1 > 400 && BodySourceView.rxh > 4.5)
            {
                if (sciencequestion.Q[sciencequestion.num].check.Equals(check1))
                {
                    Run_Winter.check = 1;
                    GameObject.Find("GameScreen").transform.Find("o").gameObject.SetActive(true);
                    GameObject.Find("GameScreen").transform.Find("Panel").gameObject.SetActive(false);
                    int num = Random.Range(0, 30);
                    sciencequestion.setnum(num);
                    checkin = false;
                }
                else
                {
                    Run_Winter.check = 1;
                    PlayerStats.Instance.TakeDamage();
                    GameObject.Find("GameScreen").transform.Find("x").gameObject.SetActive(true);
                    GameObject.Find("GameScreen").transform.Find("Panel").gameObject.SetActive(false);
                    int num = Random.Range(0, 30);
                    sciencequestion.setnum(num);
                    checkin = false;
                }
            }

        }
        if (checkin)
        {
            if (PrintGazePosition.xCoord1 < 1469 && PrintGazePosition.xCoord1 > 820 && PrintGazePosition.yCoord1 < 800 && PrintGazePosition.yCoord1 > 600 && BodySourceView.rxh > 4.5)
            {
                if (sciencequestion.Q[sciencequestion.num].check.Equals(check2))
                {
                    Run_Winter.check = 1;
                    GameObject.Find("GameScreen").transform.Find("o").gameObject.SetActive(true);
                    GameObject.Find("GameScreen").transform.Find("Panel").gameObject.SetActive(false);
                    int num = Random.Range(0, 30);
                    sciencequestion.setnum(num);
                    checkin = false;
                }
                else
                {
                    Run_Winter.check = 1;
                    PlayerStats.Instance.TakeDamage();
                    GameObject.Find("GameScreen").transform.Find("x").gameObject.SetActive(true);
                    GameObject.Find("GameScreen").transform.Find("Panel").gameObject.SetActive(false);
                    int num = Random.Range(0, 30);
                    sciencequestion.setnum(num);
                    checkin = false;
                }
            }

        }
        if (checkin)
        {
            if (PrintGazePosition.xCoord1 < 1980 && PrintGazePosition.xCoord1 > 1469 && PrintGazePosition.yCoord1 < 800 && PrintGazePosition.yCoord1 > 600 && BodySourceView.rxh > 4.5)
            {
                if (sciencequestion.Q[sciencequestion.num].check.Equals(check3))
                {
                    Run_Winter.check = 1;
                    GameObject.Find("GameScreen").transform.Find("o").gameObject.SetActive(true);
                    GameObject.Find("GameScreen").transform.Find("Panel").gameObject.SetActive(false);
                    int num = Random.Range(0, 30);
                    sciencequestion.setnum(num);
                    checkin = false;
                }
                else
                {
                    Run_Winter.check = 1;
                    PlayerStats.Instance.TakeDamage();
                    GameObject.Find("GameScreen").transform.Find("x").gameObject.SetActive(true);
                    GameObject.Find("GameScreen").transform.Find("Panel").gameObject.SetActive(false);
                    int num = Random.Range(0, 30);
                    sciencequestion.setnum(num);
                    checkin = false;
                }
            }
        }
    }
}