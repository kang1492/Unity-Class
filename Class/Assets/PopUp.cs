using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    private Animator animator;
    public GameObject window;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 에니메이터 컨트롤러에서 현재 애니메이터 상태의 이름이 "Close" 라면
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            // 현재 애니메이션의 진행도가 1보다 크거나 같다면 window 오브젝트를 비활성합니다.
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1) // 1보다 크면 게임이 끝났다
            {
                window.SetActive(false);
            }
        }
    }

    // 버튼은 public 으로 해줘야 됨
    public void Close()
    {
        animator.SetTrigger("Close");
    }

    public void PopUpOpen()
    {
        // 게임 오브젝트를 활성화 상태로 만들겠다
        window.SetActive(true);
    }
}
