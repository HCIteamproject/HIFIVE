/*****************
* 프로그램명 : HealthBarController.cs

* 작성자 : 천은정 ( 권순규, 김성수, 유병주, 전승원 )

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 캐릭터의 생명을 체크하고 화면상에 출력하는 코드이다.

***********************************/

using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    private GameObject[] heartContainers;
    private Image[] heartFills;     // 생명 이미지

    public Transform heartsParent;

    public GameObject heartContainerPrefab;

    private void Start()
    {
        heartContainers = new GameObject[(int)PlayerStats.Instance.MaxHealth];
        heartFills = new Image[(int)PlayerStats.Instance.MaxHealth];

        PlayerStats.Instance.onHealthChangedCallback += UpdateHeartsHUD;
        InstantiateHeartContainers();
        UpdateHeartsHUD();
    }

    public void UpdateHeartsHUD()
    {
        SetHeartContainers();
        SetFilledHearts();
    }

    public void Hurt()      // 생명 감소
    {
        PlayerStats.Instance.TakeDamage();
    }

    void SetHeartContainers()
    {
        for (int i = 0; i < heartContainers.Length; i++)
        {
            if (i < PlayerStats.Instance.MaxHealth)
            {
                heartContainers[i].SetActive(true);
            }
            else
            {
                heartContainers[i].SetActive(false);
            }
        }
    }

    void SetFilledHearts()
    {
        for (int i = 0; i < heartFills.Length; i++)
        {
            if (i < PlayerStats.Instance.Health)
            {
                heartFills[i].fillAmount = 1;
            }
            else
            {
                heartFills[i].fillAmount = 0;
            }
        }

        if (PlayerStats.Instance.Health % 1 != 0)
        {
            int lastPos = Mathf.FloorToInt(PlayerStats.Instance.Health);
            heartFills[lastPos].fillAmount = PlayerStats.Instance.Health % 1;
        }
    }

    void InstantiateHeartContainers()
    {
        for (int i = 0; i < PlayerStats.Instance.MaxHealth; i++)
        {
            GameObject temp = Instantiate(heartContainerPrefab);
            temp.transform.SetParent(heartsParent, false);
            heartContainers[i] = temp;
            heartFills[i] = temp.transform.Find("HeartFill").GetComponent<Image>();
        }
    }
}
