using System;
using UnityEngine;
using UnityEditor;

public class Capture : MonoBehaviour
{
    public void ScreenShot()
    {
        ScreenCapture.CaptureScreenshot
            (
            "Assets/Mouse Drag Function/Textures"+
            DateTime.Now.Second +
            DateTime.Now.Millisecond +
            ".png"
             );

        EditorApplication.ExecuteMenuItem("Assets/Refresh");
        // ������ ���� ���� ��ħ
    }
}
