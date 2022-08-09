using UnityEngine;
using UnityEngine.UI;

public class AnimationSpeed : MonoBehaviour
{
    [SerializeField] Text speedText;
    [SerializeField] DataSystem data;
    [SerializeField] Animator[] animator;

    public void SpeedSetting()
    {
        if(data.speed++ >= 10)
        {
            data.speed = 1;
        }

        speedText.text = data.speed.ToString();
        data.Save();
        // 세이브 데이터 호출 : 저장된 에니메이션 속도

        for(int i = 0; i < animator.Length; i++)
        {
            // 에니메이션 속도 10% 식 증가시키기 위해 / 10
            // 기본 1 -> 2 = 2배 속도
            animator[i].speed = data.speed / 10;
        }

    }
}
