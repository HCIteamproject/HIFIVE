using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Run : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 pos;    // 현재위치
    float delta = 2.5f; // 좌우 이동가능한 최대값
    public float speed = 1.0f;    // 이동속도
    private int num = 0;
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * speed;     // 앞으로 자동 이동

        if (Input.GetKeyDown(KeyCode.LeftArrow))        // 왼쪽 버튼 클릭 시
        {
            transform.position += Vector3.left * delta;       // 왼쪽 이동
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))       // 오른쪽 버튼 클릭 시
        {
            transform.position += Vector3.right * delta;    // 오른쪽 이동
        }

    }
private void OnCollisionEnter(Collision collision)    // 부딪힐 시 뒤로 물러남
{
    if (collision.transform.tag == "enemy")
    {
        this.transform.Translate(Vector3.back * speed);
        PlayerStats.Instance.TakeDamage();      // 생명이 하나 사라진다.

        if (PlayerStats.Instance.Health == 0)       // 생명이 0이 되면 게임이 끝난다.
        {
            speed = 0;      // 움직임 멈추기
            GameObject.Find("GameScreen").transform.FindChild("Timer").gameObject.SetActive(false);     // 오브젝트 비활성화
            GameObject.Find("GameScreen").transform.FindChild("Panel").gameObject.SetActive(false);     // 오브젝트 비활성화
            GameObject.Find("GameScreen").transform.FindChild("BackGround").gameObject.SetActive(true);     // 오브젝트 활성화

        }
    }
    if (collision.transform.tag == "question")
    {
        GameObject.Find("GameScreen").transform.FindChild("Panel").gameObject.SetActive(true);
    }

    if (collision.transform.tag == "finish")
    {
        GameObject.Find("GameScreen").transform.FindChild("Panel").gameObject.SetActive(false);
    }
    if (collision.transform.tag == "o")
    {
        GameObject.Find("GameScreen").transform.FindChild("o").gameObject.SetActive(false);
        GameObject.Find("GameScreen").transform.FindChild("x").gameObject.SetActive(false);
    }
}
}
