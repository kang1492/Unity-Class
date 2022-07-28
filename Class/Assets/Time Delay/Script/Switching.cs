using UnityEngine;
using UnityEngine.UI;

public class Switching : MonoBehaviour
{
    public Image buttonImage;
    public Sprite[] buttonSprite;

    public bool state; // 간단하게 버튼

    public void Behaviout()
    {
        // false <- ture 
        state = !state;

        if(state)
        {
            Time.timeScale = 0; // 시간흐름 기본 1
            buttonImage.sprite = buttonSprite[0];
        }

        else
        {
            Time.timeScale = 1; // 시간흐름 기본 1
            buttonImage.sprite = buttonSprite[1];
        }
    }
}
