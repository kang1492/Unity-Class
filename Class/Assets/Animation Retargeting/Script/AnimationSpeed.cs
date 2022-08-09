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
        // ���̺� ������ ȣ�� : ����� ���ϸ��̼� �ӵ�

        for(int i = 0; i < animator.Length; i++)
        {
            // ���ϸ��̼� �ӵ� 10% �� ������Ű�� ���� / 10
            // �⺻ 1 -> 2 = 2�� �ӵ�
            animator[i].speed = data.speed / 10;
        }

    }
}
