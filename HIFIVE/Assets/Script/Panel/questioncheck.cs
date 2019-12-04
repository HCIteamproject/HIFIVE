using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questioncheck : MonoBehaviour
{
    public string check1 = "1";
    public string check2 = "2";
    public string check3 = "3";
    public void questionCheck1()
    {
        if (commonquestion.check.Equals(check1))
        {
            GameObject.Find("GameScreen").transform.FindChild("o").gameObject.SetActive(true);
            GameObject.Find("GameScreen").transform.FindChild("Panel").gameObject.SetActive(false);
            int num = Random.Range(0, 30);
            commonquestion.setnum(num);
        }
        else
        {
            PlayerStats.Instance.TakeDamage();
            GameObject.Find("GameScreen").transform.FindChild("x").gameObject.SetActive(true);
            GameObject.Find("GameScreen").transform.FindChild("Panel").gameObject.SetActive(false);
            int num = Random.Range(0, 30);
            commonquestion.setnum(num);

        }
    }

    public void questionCheck2()
    {
        if (commonquestion.check.Equals(check2))
        {
            GameObject.Find("GameScreen").transform.FindChild("o").gameObject.SetActive(true);
            GameObject.Find("GameScreen").transform.FindChild("Panel").gameObject.SetActive(false);
            int num = Random.Range(0, 30);
            commonquestion.setnum(num);
        }
        else
        {
            PlayerStats.Instance.TakeDamage();
            GameObject.Find("GameScreen").transform.FindChild("x").gameObject.SetActive(true);
            GameObject.Find("GameScreen").transform.FindChild("Panel").gameObject.SetActive(false);
            int num = Random.Range(0, 30);
            commonquestion.setnum(num);

        }
    }

    public void questionCheck3()
    {
        if (commonquestion.check.Equals(check3))
        {
            GameObject.Find("GameScreen").transform.FindChild("o").gameObject.SetActive(true);
            GameObject.Find("GameScreen").transform.FindChild("Panel").gameObject.SetActive(false);
            int num = Random.Range(0, 30);
            commonquestion.setnum(num);

        }
        else
        {
            PlayerStats.Instance.TakeDamage();
            GameObject.Find("GameScreen").transform.FindChild("x").gameObject.SetActive(true);
            GameObject.Find("GameScreen").transform.FindChild("Panel").gameObject.SetActive(false);
            int num = Random.Range(0, 30);
            commonquestion.setnum(num);

        }
    }
}