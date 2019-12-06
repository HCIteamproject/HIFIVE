using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DataOfMemberCompare : IComparer, IComparer<DataOfMember>
{
    public int Compare(DataOfMember x, DataOfMember y)
    {
        return x.score.CompareTo(y.score);
    }

    public int Compare(object x, object y)
    {
        return Compare((DataOfMember)x, (DataOfMember)y);
    }
}
public class DataOfMember
{
    public string name;
    public float score;
    public DataOfMember(string name, float score)
    {
        this.name = name;
        this.score = score;
    }
    public string Print(){
        string rank=name +" " + score.ToString();
        return rank;
    }
}

public class Rank : MonoBehaviour
{
    public InputField inputField_Name;
    public string[] namedata=new string[100];       // 이름 저장 배열
    public float[] scoredata=new float[100];           // 점수 저장 배열
    public int num = 0;
    public string strFilePath;   // 파일 경로
    List<DataOfMember> Arr = new List<DataOfMember>();

    public InputField rank1;
    public InputField rank2;
    public InputField rank3;
    public InputField rank4;
    public InputField rank5;
    public InputField rank6;
    public InputField rank7;
    public InputField rank8;
    public InputField rank9;
    public InputField rank10;


    // Start is called before the first frame update
    void Start()
    {
        strFilePath = "Assets/data.txt";

        ReadData();
        Load();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void WriteData(string strData)       // txt 파일 쓰기
    {
        FileStream f = new FileStream(strFilePath, FileMode.Append);
        StreamWriter writer = new StreamWriter(f);
        writer.WriteLine(strData);
        writer.WriteLine(Timer.time);
        writer.Close();
        f.Close();

        ReadData();
    }

    public void ReadData()          // txt 파일 읽기
    {
        string readstr;
        FileStream f = new FileStream(strFilePath, FileMode.Open);
        StreamReader read = new StreamReader(f);

        int i = 0;
        float scorebuf;
        string namebuf;
        while ((readstr = read.ReadLine()) != null)     // text 파일 읽어서 배열에 저장
        {
            namebuf = readstr;
            readstr = read.ReadLine();
            scorebuf = float.Parse(readstr);
            Arr.Add(new DataOfMember(namebuf,scorebuf));
        }
        Arr.Sort(new DataOfMemberCompare());        // 정렬
        Arr.Reverse();

        read.Close();
        f.Close();

    }

    public void Save()      // 변경된 모든 키 값을 물리적인 저장 공간에 저장
    {
        PlayerPrefs.SetString("Name", inputField_Name.text);
        name = PlayerPrefs.GetString("Name");
        WriteData(name);
    }

    public void Load()
    {
        rank1.text = Arr[0].Print();
        rank2.text = Arr[1].Print();
        rank3.text = Arr[2].Print();
        rank4.text = Arr[3].Print();
        rank5.text = Arr[4].Print();
        rank6.text = Arr[5].Print();
        rank7.text = Arr[6].Print();
        rank8.text = Arr[7].Print();
        rank9.text = Arr[8].Print();
        rank10.text = Arr[9].Print();
    }

}
