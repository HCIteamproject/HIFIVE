/*****************
* 프로그램명 : commonquestion.cs

* 작성자 : 권순규 ( 천은정, 김성수, 유병주, 전승원 )

* 작성일 : 2019년 11월 30일

* 프로그램 설명 : 해당 주제의 문제와 선택지를 랜덤으로 패널과 버튼에 출력한다.

***********************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;


public class historyquestion : MonoBehaviour
{
    // Start is called before the first frame update
    public Text question = null;
    public Text but1 = null;
    public Text but2 = null;
    public Text but3 = null;
    public question[] Q;
    public static string check = null;
    public static int num = 0;

    void Start()
    {
        Q = new question[30];
        Q[0] = new question("제주도의 옛이름은 무엇일까요?", "탐라", "우산국", "최남", "1");
        Q[1] = new question("조선 중기 임진왜란 때 의병장으로 주로 말을 타고 왜적을 무찔렀으며, 홍의장군이라고도 불린 이 인물은 누구일까요?", "전봉준", "곽재우", "이순신", "2");
        Q[2] = new question("신라 문무왕 14년에 축조된 신라의 궁원지이며 현재 경북 경주시 인교동에 있는 연못인 이곳은 어디일까요?", "석촌호", "팔당호", "안압지", "3");
        Q[3] = new question("영국, 네덜란드, 프랑스가 동양 무역을 용이하게 하기 위해 설립한 이 회사의 이름은 무엇일까요?", "동인도 회사", "유령회사", "몬스터 주식회사", "1");
        Q[4] = new question(" 조선 중기에 지었다고 하는 고전소설인 '홍길동전'의 저자는?", "이광수", "허균", "이상", "2");
        Q[5] = new question("사전적으로는 야만스러운 종족이라는 뜻으로, 침략자를 업신여겨 이르던 말은?(여진족을 이르던말)", "왜놈", "오랑캐", "양놈", "2");
        Q[6] = new question("조선시대에서는 왕의 얼굴을 '용안'. 입을 '구순'이라고 불렀습니다. 그럼 '왕의 변'은 무엇일까요?", "옹변", "변화", "매화", "3");
        Q[7] = new question("1907년 전후 일제가 보안법 등의 악법을 만든것에 독립운동가들이 국권 회복 운동을 위해 설립한 비밀단체는?", "신민회", "신민아", "대한청년단", "1");
        Q[8] = new question("조선시대 서울에 설치했던 최고의 교육기관은?", "서당", "학당", "성균관", "3");
        Q[9] = new question("을미사변 이후 일본군의 공격에 신변 위협을 느낀 고종이 러시아 대사관으로 피한 이 사건은?", "아관파천", "을미파천", "노관용동", "1");
        Q[10] = new question("1919년 11월 만주 지린성에서 조직된 항일 무력독립운동 단체. 주로 일본 고관 암살과 관공서 폭파등의 활동을 했던 단체의 이름은?", "신민단", "의열단", "조선애국당", "2");
        Q[11] = new question("태종 이성계가 정치적 대립이 있던 정도정등을 죽이며 일으킨 난의 이름은?", "2차 왕자의 난", "위화도 회군", "1차 왕자의 난", "3");
        Q[12] = new question("다음중 알에서 태어나지 않은 사람은 누구일까여?", "온조왕", "박혁거세", "동명왕", "1");
        Q[13] = new question("살수대첩에서 수나라의 30만대군에 맞서 싸워 고구려를 지킨 장수의 이름은 무엇일까요?", "양만춘", "연개소문", "을지문덕", "3");
        Q[14] = new question("6.25 전쟁이 일어난 해는?", "1949년", "1950년", "1951년", "2");
        Q[15] = new question("한국인 최초의 미국시민권자이자 독립신문을 발간한 독립운동가의 이름은?", "서재필", "박용만", "윤병구", "1");
        Q[16] = new question("영국과의 100년 전쟁을 끝낸 프랑스의 영웅이자 15세 소녀의 이름은?", "나폴레옹", "잔다르크", "아일린", "2");
        Q[17] = new question("신이아닌 인간을 중심으로하는 사고방식이 널리퍼지며 예술계에 큰발전을 가지고 온 이 시기의 이름은?", "바로크", "신고전주의", "르네상스", "3");
        Q[18] = new question("중세에 성지 예루살렘을 차지하기 위해 그리스도교가 일으킨 종교 전쟁을부르는 이름은?", "탈환군", "장미군", "십자군", "3");
        Q[19] = new question("세계에 '코레아'를 알린 고려시대 최고의 항구이자 세계 무역의 중심지였던 곳은?", "강화도", "벽란도", "제주도", "2");
        Q[20] = new question("고려 숙종시절 윤관의 건의로 만들어진 특수부대로  여진족을 상대로 큰공을 세운 부대의 이름은?", "별무반", "삼별초", "신기군", "1");
        Q[21] = new question("‘두 강 사이의 땅’이라는 뜻으로 쐐기문자를 발명해 낸 인류 최초의 문명이 탄생한 곳은 어디일까요?", "바빌론", "메소포타미아", "잉카", "2");
        Q[22] = new question("홍범도장군이 이끄는 부대가 1920년 일본군을 상대로 큰승리를 거둔 전투로 영화화된 전투의 이름은?", "청산리 대첩", "한산도 대첩", "봉오동 전투", "3");
        Q[23] = new question("인류최초의 문학작품으로 메소포타미아 지역 우르크의 왕의 이름을 가진 작품은 무엇일까?", "길가메쉬 서사시", "바빌로니아 연대기", "그리스 로마신화", "1");
        Q[24] = new question("'무정' 이라는 소설로 큰 인기를 얻었지만, 훗날 친일파가 된 소설가는?", "유재석", "이광수", "김종국", "2");
        Q[25] = new question("고구려 동명성왕의 이름으로 '활을 잘쏘는 사람'을 뜻하는 이름은?", "유리", "해모수", "주몽", "3");
        Q[26] = new question("신라시대의 신분제로 기본적으로 진골, 성골,6두품으로 나뉘는 제도의 이름은?", "골품제도", "아찬제", "진성제도", "1");
        Q[27] = new question("백제 말기의 장군으로 나당연합군을 상대로 활약한 백제의 3충신 중 한명의 이름은?", "관창", "계백", "흥수", "2");
        Q[28] = new question("신라의 청소년 수련 조직으로 진흥왕 때 국가조직이된 조직의 이름은?", "별무반", "아람단", "화랑", "3");
        Q[29] = new question("안창호 의사의 호는?", "도산", "백범", "단재", "1");


        num = Random.Range(0, 30);
    }

    // Update is called once per frame
    void Update()
    {
        Q[num].isComeout = true;
        question.text = Q[num].q;
        but1.text = Q[num].But1;
        but2.text = Q[num].But2;
        but3.text = Q[num].But3;
        check = Q[num].check;
    }

    public void QuestionChange()
    {
        do
        {
            num = Random.Range(0, 30);

        } while (!Q[num].isComeout);
        question.text = Q[num].q;
        but1.text = Q[num].But1;
        but2.text = Q[num].But2;
        but3.text = Q[num].But3;
        check = Q[num].check;
    }

    public static void setnum(int n)    // 문제 랜덤
    {
        num = n;
    }
}