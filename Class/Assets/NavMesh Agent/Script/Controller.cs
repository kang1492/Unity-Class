using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    public float speed = 5.0f;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); // 시작하자마다 컴포넌트를 가져오겠다.
        //transform.position = new Vector3(0, 1, 0) * Time.deltaTime;
        // 포지션           새로만들기 new 백터            델타값(똑같은 시간 맞추기)
    }

    void Update()
    {
        //Move(new Vector3(1,1,1));
        // 유니티에서는 좌표값 필요

        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            // RaycastHit hit: 광선과 충돌한 오브젝트의 물체에 대한 정보를 저장합니다.

            // 카메라로부터 스크린 공간의 마우스 포인터를 통해 위치 정보를 저장합니다.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // 광선    메인 카메라에서                   입력   마우스 포지션

            //                   out 매개변수를 읽기 전용으로
            // out 은 출력용 매개변수. 읽기전용 매개변수
            //                              발사  무한
            if(Physics.Raycast(ray, out hit,Mathf.Infinity)) // 충돌
            {
                // 충돌한 물체
                Move(hit.point);
            }
        }
    }

    public void Move(Vector3 Position) // 이동 함수
    {
        agent.speed = speed;
        // 컴포턴트 안에 있는 스피드 참조
        agent.SetDestination(Position);
            // 고착점 위치 정보를 잡아 달라
    }
}
