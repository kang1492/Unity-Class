using System.Collections;

using UnityEngine;
using UnityEngine.UI;

public class Various : MonoBehaviour
{
    private float timer;
    public Image stateImage;
    public Sprite[] stateIcon;

    void Start()
    {
        //InvokeRepeating : 특정한 함수를 1초 뒤에 3초마다 반복적으로 실행시키는 합수입니다.엡데이트 함수에 안씀. 쉬게
        InvokeRepeating("Position", 1, 3);

        StartCoroutine(Paint()); // 3초 마다 반복
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 5.0f)
        {
            Invoke("ChangeSprite", 0); // 몇초뒤에 3.5f 플로트 값

            timer = 0.0f;
        }
    }

    public void ChangeSprite()
    {
        switch (Random.Range(0, 3))
        {
            case 0 : stateImage.sprite = stateIcon[0];
                break;
            case 1:  stateImage.sprite = stateIcon[1];
                break;
            case 2:  stateImage.sprite = stateIcon[2];
                break;
        }
    }

    public void Position()
    {
        transform.position = new Vector3
            (
            Random.Range(-2.5f, 2.5f), 0, 
            Random.Range(-2.5f, 2.5f)
            );
    }

    IEnumerator Paint()
    {


        while (true)
        {
            yield return new WaitForSeconds(3);// 3초동안 양보
            gameObject.GetComponent<Renderer>().material.color =
                new Color
                (
                Random.Range(0, 2),
                Random.Range(0, 2),
                Random.Range(0, 2)
                );
        }
    }

}
