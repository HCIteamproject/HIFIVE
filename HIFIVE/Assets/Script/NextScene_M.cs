/*****************
* 프로그램명 : NextScene_M.cs

* 작성자 : 천은정 ( 권순규, 김성수, 유병주, 전승원 )

* 작성일 : 2019년 12월 06일

* 프로그램 설명 : 버튼을 눌렀을 때 Main Menu 씬으로 변환하는 함수를 가진 코드이다.

***********************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene_M : MonoBehaviour
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
        SceneManager.LoadScene("MainMenu");
    }
}
