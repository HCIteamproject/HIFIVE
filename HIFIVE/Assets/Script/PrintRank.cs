//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using System.IO;

//public class DataOfMemberCompare : IComparer, IComparer<DataOfMember>
//{
//    public int Compare(DataOfMember x, DataOfMember y)
//    {
//        return x.score.CompareTo(y.score);
//    }

//    public int Compare(object x, object y)
//    {
//        return Compare((DataOfMember)x, (DataOfMember)y);
//    }
//}
//public struct DataOfMember
//{
//    public float score { get; set; }
//    public string name { get; set; }

//    public void Print()
//    {
//        Debug.Log(name + score.ToString());
//    }
//}

//public class Rank : MonoBehaviour
//{
//    public InputField inputField_Name;
//    public string[] namedata = new string[100];       // 이름 저장 배열
//    public float[] scoredata = new float[100];           // 점수 저장 배열
//    public int num = 0;
//    public string strFilePath;   // 파일 경로
//    ArrayList Arr;

//    // Start is called before the first frame update
//    void Start()
//    {
//        strFilePath = "Assets/data.txt";
//        Arr = new ArrayList();
//        ReadData();
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    public void WriteData(string strData)       // txt 파일 쓰기
//    {
//        FileStream f = new FileStream(strFilePath, FileMode.Append);
//        StreamWriter writer = new StreamWriter(f);
//        writer.WriteLine(strData);
//        writer.WriteLine(Timer.time);
//        writer.Close();
//        f.Close();

//        ReadData();
//    }

//    public void ReadData()          // txt 파일 읽기
//    {
//        string readstr;
//        FileStream f = new FileStream(strFilePath, FileMode.Open);
//        StreamReader read = new StreamReader(f);
//        string check = "name";
//        int i = 0;
//        float scorebuf;
//        string namebuf;
//        while ((readstr = read.ReadLine()) != null)     // text 파일 읽어서 배열에 저장
//        {
//            namebuf = readstr;
//            readstr = read.ReadLine();
//            scorebuf = float.Parse(readstr);
//            Arr.Add(new DataOfMember() { score = scorebuf, name = namebuf });
//        }
//        Arr.Sort(new DataOfMemberCompare());        // 정렬

//        Debug.Log((DataOfMember)Arr[0]);

//        Arr.Reverse();

//        read.Close();
//        f.Close();


//    }

//    public void Save()      // 변경된 모든 키 값을 물리적인 저장 공간에 저장
//    {
//        PlayerPrefs.SetString("Name", inputField_Name.text);
//        name = PlayerPrefs.GetString("Name");
//        WriteData(name);
//    }


//}
