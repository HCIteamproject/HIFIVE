using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform target; //추적할 타겟 오브젝트의 Transform
    public float dist = 5.0f;  //카메라와의 일정 거리
    public float height = 3.0f;  //카메라의 높이 설정
    public float smoothRotate = 5.0f;  //부드러운 회전을 위한 변수
    // Start is called before the first frame update

    private Transform tr;  //카메라 자신의 Transform 변수
    void Start()
    {
        tr = GetComponent<Transform>();  
    }

    // Update is called once per frame
    void Update()
    {   //부드러운 회전을위한 Mathf.LerpAngle
        float currYAngle = Mathf.LerpAngle(tr.eulerAngles.y, target.eulerAngles.y,
            smoothRotate * Time.deltaTime);

        //오일러 타입을 쿼터니언으로 바꾸기
        Quaternion rot = Quaternion.Euler(0, currYAngle, 0);

        //카메라 위치를 타겟 회전각도만큼 회전 후 dist만큼 띄우고 높이 올리기
        tr.position = target.position - (rot * Vector3.forward * dist)
            + (Vector3.up * height);

        //타켓을 바라보게 하기
        tr.LookAt(target);
    }
}
