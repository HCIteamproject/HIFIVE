/*****************
* 프로그램명 : Ship.cs

* 작성자 : 천은정 ( 권순규, 김성수, 유병주, 전승원 )

* 작성일 : 2019년 10월 28일

* 프로그램 설명 : 게임 시작 시 배경화면의 배 오브젝트를 앞으로 자동움직임을 넣은 코드이다.

***********************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime);
    }
}
