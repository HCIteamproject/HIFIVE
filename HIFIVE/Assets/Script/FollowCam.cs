/*****************
* 프로그램명 : FollowCam.cs

* 작성자 : 전승원 ( 천은정, 권순규, 유병주, 김성수 )

* 작성일 : 2019년 11월 28일

* 프로그램 설명 : 캐릭터와 일정거리를 유지한테 카메라가 캐릭터를 따라가게 하는 코드이다.

***********************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public GameObject player;
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
