/*****************
* 프로그램명 : CameraController.cs

* 작성자 : 천은정 ( 권순규, 김성수, 유병주, 전승원 )

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : player를 선택 카메라가 오브젝트와 일정간격 떨어져 함께 이동하는 코드이다.

***********************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;       // player
    private Vector3 offset;


    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void LateUpdate()
    {
       transform.position = player.transform.position + offset;
    }
}
