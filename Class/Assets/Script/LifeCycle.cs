using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] // �ܺο��� ����

// C# ������
public class Data
{
    // ����
    // �⺻ ���� �����ڴ� private�Դϴ�.
    //public int coin;

    public int price;
    public string name; // ���� ����
    public Sprite sprite;

    // �⺻ ������
    // �����ڸ� �������� ������ �ڵ����� �⺻ �����ڸ� ���������ݴϴ�.

    /*
    public Data(int data)
    {
        coin = data;
    }
    
    public void Save() // �����Ҵ�
    {
        Debug.Log("Data Class"); // ����ϱ�
    }
    */
}

public class LifeCycle : MonoBehaviour
{

    //public int health = 0; // �ܺο��� ���� �����Ҽ� ����
    //public int [] health; // �迭�� ũ��� (?)

    public Data [] data;

    public Text[] priceUI;
    public Text[] nameUI;
    public Image[] spriteUI;

    // ����Ƽ������ �Ҹ��ڰ� �������� �ʽ��ϴ�.

    /*
    //public Data data = new Data(); // ������ ����� , �Ű����� �־���� ��.
    //List<int> list = new List<int>(); // ����Ʈ�� ������ �ֱ�

    //Stack<int> stack = new Stack<int>();
    // c# ���� ���ø����
    */

    private void Awake() // <-1��°
    {
        for(int i = 0; i < data.Length; i++)
        {
            // 0 <----- 0
           priceUI[i].text = data[i].price.ToString();
            //  ����    ���� ���             ���°� ���� �ʾ� ��ȯ
            nameUI[i].text = data[i].name; // ���� ��ȯ �ʿ� ����
            spriteUI[i].sprite = data[i].sprite;
        }


        // int size �ؼ� ������.

        //Debug.Log(health.Length);
        // health.Length << ����Ƽ������ �ڵ����� ������.

        /*
        data.coin = 0; // ������ �ʱ�ȭ �Ҽ� �ִ�.
        data.Save(); // ȣ�� �ϱ�
        list.Add(1); // �߰� �ϱ�
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

    //�ｺ�� 100�� �Ѱ� ���� �ٽ� 0���� ����� �ּ���

    // 7.14��
    // ���� ������Ʈ�� ��Ȱ��ȭ�� ������ ȣ��Ǵ� �Լ��Դϴ�.
    private void OnDisable()
    {
        Debug.Log("Tiger OnDisable");
    }
    
    // ���� ������Ʈ�� �ı��Ǵ� ���� ȣ��Ǵ� �Լ��Դϴ�.
    private void OnDestroy()
    {

    }
}
