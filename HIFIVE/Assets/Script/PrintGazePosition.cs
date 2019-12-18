/*****************
* 프로그램명 : PrintGazePosition.cs

* 작성자 : 권순규,전승원 ( 천은정, 김성수, 유병주 )

* 작성일 : 2019년 12월 7일

* 프로그램 설명 : tobii sdk를 사용하여 눈이 보고있는 좌표를 가져온다.

***********************************/
using UnityEngine;
using UnityEngine.UI;
using Tobii.Gaming;

/// <summary>
/// Writes the position of the eye gaze point into a UI Text view
/// </summary>
/// <remarks>
/// Referenced by the Data View in the Eye Tracking Data example scene.
/// </remarks>
public class PrintGazePosition : MonoBehaviour
{
    public Text xCoord;
    public Text yCoord;
    public static float xCoord1;
    public static float yCoord1;

    public GameObject GazePoint;

    private float _pauseTimer;
    private Outline _xOutline;
    private Outline _yOutline;

    void Start()
    {   /*
		_xOutline = xCoord.GetComponent<Outline>();
		_yOutline = yCoord.GetComponent<Outline>();
        */
    }

    void Update()
    {
        if (_pauseTimer > 0)
        {
            _pauseTimer -= Time.deltaTime;
            return;
        }

        //GazePoint.SetActive(true);
        /*
		_xOutline.enabled = false;
		_yOutline.enabled = false;
        */
        GazePoint gazePoint = TobiiAPI.GetGazePoint();
        yCoord.color = xCoord.color = new Color(0 / 255f, 190 / 255f, 255 / 255f);
        if (gazePoint.IsValid)
        {
            Vector2 gazePosition = gazePoint.Screen;
            yCoord.color = xCoord.color = Color.red;
            Vector2 roundedSampleInput = new Vector2(Mathf.RoundToInt(gazePosition.x), Mathf.RoundToInt(gazePosition.y));
           // xCoord.text = "x (in px): " + roundedSampleInput.x;
            //yCoord.text = "y (in px): " + roundedSampleInput.y;
            xCoord1 = roundedSampleInput.x;
            yCoord1 = roundedSampleInput.y;
        }

        if (Input.GetKeyDown(KeyCode.Space) && gazePoint.IsRecent())
        {
            _pauseTimer = 3f;
            GazePoint.transform.localPosition = (gazePoint.Screen - new Vector2(Screen.width, Screen.height) / 2f) / GetComponentInParent<Canvas>().scaleFactor;
            yCoord.color = xCoord.color = new Color(0 / 255f, 190 / 255f, 255 / 255f);
            GazePoint.SetActive(true);
            _xOutline.enabled = true;
            _yOutline.enabled = true;
        }
    }
}
