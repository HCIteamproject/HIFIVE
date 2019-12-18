/*****************
* 프로그램명 : commonquestion.cs

* 작성자 : 권순규 ( 천은정, 김성수, 유병주, 전승원 )

* 작성일 : 2019년 11월 30일

* 프로그램 설명 : 문제와 보기,정답을 초기화 시켜주고 랜덤으로 문제를 설정하여 버튼과 패널에 출력해준다.

***********************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class commonquestion : MonoBehaviour
{
    public Text question;
    public Text but1;
    public Text but2;
    public Text but3;
    public static question[] Q;
    public static string check;
    public static int num;

    // Start is called before the first frame update
    void Start()
    {
        Q = new question[30];
        Q[0] = new question("세상에서 가장 매운 고추는?", "부트 졸로키아", "캘로라이나 리퍼", "레드 사바나 하바네로", "2");
        Q[1] = new question("세상에서 가장 섬이 많은 나라는?", "필리핀", "파푸아뉴기니", "인도네시아", "3");
        Q[2] = new question("유엔에 속한 전문기구가 아닌것은?", "유니세프", "세계보건기구", "그린피스", "3");
        Q[3] = new question("전화기를 최초로 발명한 사람은", "그렐이엄 벨", "엘리샤 그레이", "안토니오 메우치", "3");
        Q[4] = new question("의학적으로 얼굴과 머리를 구분하는 기준은", "이마", "눈썹", "귀", "3");
        Q[5] = new question("심청이 아버지의 이름은", "심학규", "심한길", "심봉사", "1");
        Q[6] = new question("겨울잠을 자는 동물이 아닌 것은?", "토끼", "뱀", "고슴도치", "1");
        Q[7] = new question("낙타의 혹 속에 들어있는것은?", "지방", "물", "뼈", "2");
        Q[8] = new question("'골치가 아프다'에서 골치가 뜻하는 것은?", "허리", "물", "뼈", "2");
        Q[9] = new question("울릉도는 행정구역상 어디에 속하는가?", "강원도", "경상북도", "전라남도", "2");
        Q[10] = new question("제주도는 돌,바람,여자가 많아서 삼다도라고 불린다 그럼 도둑,공허,뱀이 없어 삼무도라고 불리는 섬은?", "독도", "강화도", "울릉도", "3");
        Q[11] = new question("다섯손가락중 가장 빠르게 자라는 손톱은", "엄지", "검지", "중지", "3");
        Q[12] = new question("다음 중 백합과에 속하는 채소가 아닌것은?", "양파", "무", "마늘", "2");
        Q[13] = new question("소설 홍길동에서 홍길동이 만든 조직 이름은?", "성심당", "성당", "활빈당", "3");
        Q[14] = new question("피로회복제 '박카스' 의 주성분이며 각종 혈관계 질환 예방에 효과가 있다고 알려진 이것은 무엇일까?", "타우린", "아드레날린", "카페인", "1");
        Q[15] = new question("무역풍과 바람의 방향이 정반대인 이것. 아열대의 고압대와 극지방 사이에서 부는 서풍은?", "서풍", "북서풍", "극풍", "3");
        Q[16] = new question("유럽 14세기에 대유행한 페스트균의 감염에 의해 급성으로 일어나는 공포의 전염병 이름은?", "사스", "흑사병", "감기", "2");
        Q[17] = new question("축구장에서 난동을 부리는 무리들을 일컫는 말. 광적인 축구팬을 일컫는 말로도 쓰이는 것은?", "훌리건", "펠리건", "테이저건", "1");
        Q[18] = new question("스파르타의 왕비인 헬레나를 트로이의 왕자 파리스가 납치하면서 시작된 전쟁의 이름은 무엇인가?", "트로이 전쟁", "마라톤 전투", "테르모필레 전투", "1");
        Q[19] = new question("미국 맥도널드사의 햄버거 제품인 '이것'의 가격을 달러로 환산한 후 미국 내 가격과 비교한 지수는?", "상하이 지수", "빅맥 지수", "치즈 지수", "2");
        Q[20] = new question("신라의 제27대 최초의 여왕이며, 신라가 삼국통일을 이룩하는 기틀을 다졌으며, 첨성대를 건립한 이 인물은 누구일까요?", "진덕여왕", "진성여왕", "선덕여왕", "3");
        Q[21] = new question("대한민국의 전통의상은 한복입니다. 일본은 기모노 이구요. 그렇다면 중국의 전통의상은 무엇일까요?", "치파오", "차도르", "후아소", "1");
        Q[22] = new question("로마의 최초 황제 이름은 무엇일까요?", "아우그스투스", "카이사르", "제우스", "1");
        Q[23] = new question("이들 중 올림포스의 신이 아닌 것은?", "므네모시네", "제우스", "헤파이토스", "1");
        Q[24] = new question("뇌의 신경세포 손상으로 손과 팔에 경련이 일어나고, 보행이 어려워지는 손상을 입는 이 질병은 무엇일까요?", "루게릭 병", "파킨스 병", "각기병", "2");
        Q[25] = new question("타인의 기대나 관심으로 인하여 능률이 오르거나 결과가 좋아지는 현상인 이 효과는 무엇일까요?", "플라시보 효과", "나비효과", "피그말리온 효과", "3");
        Q[26] = new question("대한민국에서 면적이 가장 큰 지역은 어디일까요?", "강원도", "전라남도", "경상북도", "3");
        Q[27] = new question("이탈리아 베네치아 시내에 있는 운하를 운항하는 배로, 이탈리아 말로 '흔들리다'라는 뜻의 이것은 무엇일까요?", "카누", "곤돌라", "카약", "2");
        Q[28] = new question("자는 원양. 조조의 맹장이며, 일찍부터 조조를 도와 많은 공을 세웠고, 눈에 화살을 맞았었던 이 인물은 누구일까요?", "하후돈", "하후연", "전위", "1");
        Q[29] = new question("2001년 세계 최초로 안락사를 합법화한 나라는 어디일까요?", "미국", "러시아", "네덜란드", "3");


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

    private void QuestionChange()   //문제 중복 체크
    {
        do
        {
            num = Random.Range(0, 30);

        } while (!Q[num].isComeout);
        question.text = Q[num].q;
        but1.text = Q[num].But1;
        but2.text = Q[num].But2;
        but3.text = Q[num].But3;
    }

    public static void setnum(int n)    // 문제 랜덤
    {
        num = n;
    }
}