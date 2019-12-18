/*****************
* 프로그램명 : sciencequestion.cs

* 작성자 : 권순규 ( 천은정, 김성수, 유병주, 전승원 )

* 작성일 : 2019년 12월 7일

* 프로그램 설명 : 문제와 보기,정답을 초기화 시켜주고 랜덤으로 문제를 설정하여 버튼과 패널에 출력해준다.

***********************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;


public class sciencequestion : MonoBehaviour
{
    // Start is called before the first frame update
    public Text question = null;
    public Text but1 = null;
    public Text but2 = null;
    public Text but3 = null;
    public static question[] Q;
    public static string check = null;
    public static int num = 0;

    void Start()
    {
        Q = new question[30];
        Q[0] = new question("다음 중 가장 밝게 보이는 천체는 어느 것인가?", "금성", "목성", "리겔", "2");
        Q[1] = new question("은하수를 우리말로는 미리내라고 한다. 내는 강물을 뜻하고 미리는 이 동물을 뜻한다고한다. 이 동물은?", "거북", "용", "봉황", "1");
        Q[2] = new question("다음 중 실내공기의 오염지표로 쓰이는 것은?", "이산화 탄소", "일산화 탄소", "질소", "1");
        Q[3] = new question("미국항공우주국 NASA는 미국의 ( ) 주에 있다. ( )에 들어갈 알맞은 단어는?", "버지니아", "워싱턴", "플로리다", "2");
        Q[4] = new question("매년 전 세계에서 유행하는 독감을 분석해 백신을 만들어야하는 바이러스를 결정하는 기관은?", "세계보건기구", "유엔", "유니세프", "1");
        Q[5] = new question("식물의 호흡이 가장 왕성한 때는", "증산작용할 때", "종자가 싹틀 때", "광합성이 활봘할 때", "2");
        Q[6] = new question("다음 중 식물의 씨가 퍼지는 방법이 다른 하나는?", "민들레", "봉숭아", "소나무", "2");
        Q[7] = new question("수은의 원소 기호는 무엇일까요?", "Ag", "Mg", "Hg", "3");
        Q[8] = new question("오징어와 문어의 표면에 붙은 흰 가루로서 피로 회복에 도움을 주는 물질은?", "구연산", "과리나", "타우린", "3");
        Q[9] = new question("다음 중 유전을 결정하는 것이 세포핵 속에 들어 있는 염색체라는 것을 처음으로 알아낸 독일의 발생학자는 누구인가?", "그레고어 멘델", "아우구스트 바이스만", "리오넬 메시", "2");
        Q[10] = new question("다이아몬드, 벤젠, 연필심에서 공통으로 발견된 원소는?", "납", "탄소", "마그네슘", "2");
        Q[11] = new question("포도당은 어느 과일에 가장 많을까요?", "바나나", "망고", "포도", "3");
        Q[12] = new question("육지에 존재하는 물 중에서 가장 많은 것은?", "빙하", "강", "지하수", "1");
        Q[13] = new question("생식세포를 관찰하기 좋은 세포가 아닌 것은?", "양파의 뿌리", "개구리의 정소", "완두의 화분", "1");
        Q[14] = new question("돼지의 몸의 털을 쭈뻣하게 세우게 하는 근육의 이름은 무엇일까요?", "승모근", "대퇴사두근", "털세움근", "1");
        Q[15] = new question("방사성물질 가운데 핵실험을 판단하는 중요한 근거로 쓰이는 것은?", "메르세데스", "제논", "아란", "1");
        Q[16] = new question("중심부 또는 주위에 있는 고온 별의 강력한 복사에 의해 빛을 내는 가스 성운을 일컷는 단어는?", "암흑성운", "방출성운", "반사성운", "2");
        Q[17] = new question("다음 중 자연상태에는 존재하지 않고 화학 반응을 통하여 화학 결합물로부터 추출해 낼 수 있는 금속은?", "주석", "납", "알루미늄", "3");
        Q[18] = new question("씨없는 수박을 최초로 발명한 나라는?", "한국", "미국", "일본", "3");
        Q[19] = new question("생명체 세포의 소기관 중에 핵과 더불어 유전인자인 DNA를 가자고 있는 것은?", "라이소좀", "미토콘드리아", "골지체", "2");
        Q[20] = new question("강한 바람이 다양한 지형지물과 부딪힌 뒤 하나로 섞이는 과정에서 만들어진 소용돌이 바람의 이름은 무엇인가?", "와류", "소용돌이", "윈드시어", "3");
        Q[21] = new question("멜라닌 색소의 결핍으로 온몸이 흰빛으로 되는 선천성 유전질환은?", "알비노", "피부암", "혈우병", "1");
        Q[22] = new question("다음 중에서 가장 피부의 두께가 얇은 부위는?", "윗 배", "얼굴(뺨)", "등", "2");
        Q[23] = new question("지구의 자전축의 기울기가 옳은 것을 고르시오", "3도", "30도", "15도", "2");
        Q[24] = new question("질량보존의 법칙을 발견한 사람은 누구일까요?", "뉴턴", "보일", "라부아지에", "3");
        Q[25] = new question("질긴 인공섬유로 스타킹과 낙하산 등의 재료로 인기를 끌었던 것은 무엇일까요?", "나일론", "폴리아세틸렌", "폴리염화비닐", "1");
        Q[26] = new question("갑자기 땅이 푹 꺼져 구멍이 뚫리는 현상을 무엇이라고 할까요?", "피오르드", "지진", "싱크홀", "3");
        Q[27] = new question("세포가 바이러스에 감염되었을 때 그 세포를 직접 공격하는 세포는 무엇인가?", "유미의 세포", "킬러T세포", "적혈구", "2");
        Q[28] = new question(" 신체 척도의 일부로 손끝부터 다른 손끝까지를 무엇이라고 하는가?", "한 발", "한 뼘", "한 보", "1");
        Q[29] = new question("지구의 태풍과 같은 구름의 소용돌이인 대적반이 처음 관측된 이래로 300년이 지나도록 사라지지 않고 관측되는 행성은?", "천왕성", "목성", "화성", "2");
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

    private void QuestionChange()//문제 중복 체크
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