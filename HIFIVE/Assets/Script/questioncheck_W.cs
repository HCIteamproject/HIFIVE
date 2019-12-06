using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questioncheck_W : MonoBehaviour
{
    public string check1 = "1";
    public string check2 = "2";
    public string check3 = "3";

    public GameObject o;
    public GameObject x;
    public GameObject Panel;

    public void questionCheck1()
    {
        if (sciencequestion.check.Equals(check1))
        {
            o.gameObject.SetActive(true);
            Panel.gameObject.SetActive(false);
            int num = Random.Range(0, 30);
            sciencequestion.setnum(num);
        }
        else
        {
            x.gameObject.SetActive(true);
            Panel.gameObject.SetActive(false);
            PlayerStats.Instance.TakeDamage();
            int num = Random.Range(0, 30);
            sciencequestion.setnum(num);

        }
    }

    public void questionCheck2()
    {
        if (sciencequestion.check.Equals(check2))
        {
            o.gameObject.SetActive(true);
            Panel.gameObject.SetActive(false);
            int num = Random.Range(0, 30);
            sciencequestion.setnum(num);
        }
        else
        {
            x.gameObject.SetActive(true);
            Panel.gameObject.SetActive(false);
            PlayerStats.Instance.TakeDamage();
            int num = Random.Range(0, 30);
            sciencequestion.setnum(num);

        }
    }

    public void questionCheck3()
    {
        if (sciencequestion.check.Equals(check3))
        {
            o.gameObject.SetActive(true);
            Panel.gameObject.SetActive(false);
            int num = Random.Range(0, 30);
            sciencequestion.setnum(num);

        }
        else
        {
            x.gameObject.SetActive(true);
            Panel.gameObject.SetActive(false);
            PlayerStats.Instance.TakeDamage();
            int num = Random.Range(0, 30);
            sciencequestion.setnum(num);

        }
    }
}