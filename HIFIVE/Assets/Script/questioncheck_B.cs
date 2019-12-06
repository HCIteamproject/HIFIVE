using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questioncheck_B : MonoBehaviour
{
    public string check1 = "1";
    public string check2 = "2";
    public string check3 = "3";

    public GameObject o;
    public GameObject x;
    public GameObject Panel;

    public void questionCheck1()
    {
        if (commonquestion.check.Equals(check1))
        {
            o.gameObject.SetActive(true);
            Panel.gameObject.SetActive(false);
            int num = Random.Range(0, 30);
            commonquestion.setnum(num);
        }
        else
        {
            x.gameObject.SetActive(true);
            Panel.gameObject.SetActive(false);
            PlayerStats.Instance.TakeDamage();
            int num = Random.Range(0, 30);
            commonquestion.setnum(num);

        }
    }

    public void questionCheck2()
    {
        if (commonquestion.check.Equals(check2))
        {
            o.gameObject.SetActive(true);
            Panel.gameObject.SetActive(false);
            int num = Random.Range(0, 30);
            commonquestion.setnum(num);
        }
        else
        {
            x.gameObject.SetActive(true);
            Panel.gameObject.SetActive(false);
            PlayerStats.Instance.TakeDamage();
            int num = Random.Range(0, 30);
            commonquestion.setnum(num);

        }
    }

    public void questionCheck3()
    {
        if (commonquestion.check.Equals(check3))
        {
            o.gameObject.SetActive(true);
            Panel.gameObject.SetActive(false);
            int num = Random.Range(0, 30);
            commonquestion.setnum(num);

        }
        else
        {
            x.gameObject.SetActive(true);
            Panel.gameObject.SetActive(false);
            PlayerStats.Instance.TakeDamage();
            int num = Random.Range(0, 30);
            commonquestion.setnum(num);

        }
    }
}