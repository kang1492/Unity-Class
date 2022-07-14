using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] // 외부에서 보임

// C# 에서는
public class Data
{
    // 변수
    // 기본 접근 지정자는 private입니다.
    //public int coin;

    public int price;
    public string name; // 문자 쓰기
    public Sprite sprite;

    // 기본 생성자
    // 생성자를 선언하지 않으면 자동으로 기본 생성자를 생성시켜줍니다.

    /*
    public Data(int data)
    {
        coin = data;
    }
    
    public void Save() // 동적할당
    {
        Debug.Log("Data Class"); // 출력하기
    }
    */
}

public class LifeCycle : MonoBehaviour
{

    //public int health = 0; // 외부에서 값을 조절할수 잇음
    //public int [] health; // 배열의 크기는 (?)

    public Data [] data;

    public Text[] priceUI;
    public Text[] nameUI;
    public Image[] spriteUI;

    // 유니티에서는 소멸자가 존재하지 않습니다.

    /*
    //public Data data = new Data(); // 데이터 만들기 , 매개변수 넣어줘야 됨.
    //List<int> list = new List<int>(); // 리스트에 데이터 넣기

    //Stack<int> stack = new Stack<int>();
    // c# 에서 스택만들기
    */

    private void Awake() // <-1번째
    {
        for(int i = 0; i < data.Length; i++)
        {
            // 0 <----- 0
           priceUI[i].text = data[i].price.ToString();
            //  접근    글자 출력             형태가 맞지 않아 변환
            nameUI[i].text = data[i].name; // 형태 변환 필요 없음
            spriteUI[i].sprite = data[i].sprite;
        }


        // int size 해서 구했음.

        //Debug.Log(health.Length);
        // health.Length << 유니티에서는 자동으로 구해줌.

        /*
        data.coin = 0; // 코인을 초기화 할수 있다.
        data.Save(); // 호출 하기
        list.Add(1); // 추가 하기
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Remove(4); 
        */
    }

    void Start()
    {
        Debug.Log("Tiger Start");
    }

    private void OnEnable()
    {
        Debug.Log("Tiger OnEnable");
    }

    private void FixedUpdate()
    {
        Debug.Log("Tiger FixedUpdate");
    }

    private void Update()
    {
        /*
        health++;
         
        if(health >= 100)
        {
            health = 0;
        }
        */
    }

    //헬스가 100을 넘거 가면 다시 0으로 만들어 주세요

    // 7.14일
    // 게임 오브젝트가 비활성화될 때마다 호출되는 함수입니다.
    private void OnDisable()
    {
        Debug.Log("Tiger OnDisable");
    }
    
    // 게임 오브젝트가 파괴되는 순간 호출되는 함수입니다.
    private void OnDestroy()
    {

    }
}
