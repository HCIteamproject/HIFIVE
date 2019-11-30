/*****************
* 프로그램명 : NextScene_B.cs

* 작성자 : 천은정 ( 권순규, 김성수, 유병주, 전승원 )

* 작성일 : 2019년 11월 15일

* 프로그램 설명 : 버튼을 눌렀을 때 Beach road 씬으로 변환하는 함수를 가진 코드이다.

***********************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene_B : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeGameScene()
    {
        SceneManager.LoadScene("Beach Road");
    }

}
