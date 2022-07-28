<<<<<<< HEAD:Class/Library/PackageCache/com.unity.collab-proxy@1.15.18/Editor/PlasticSCM/UI/Message/DrawDialogIcon.cs
﻿using UnityEditor;
using UnityEngine;

using Codice.Client.Common;

namespace Unity.PlasticSCM.Editor.UI.Message
{
    internal static class DrawDialogIcon
    {
        internal static void ForMessage(GuiMessage.GuiMessageType alertType)
        {
            using (new EditorGUILayout.VerticalScope(GUILayout.Width(80)))
            {
                Rect iconRect = GUILayoutUtility.GetRect(
                    GUIContent.none, EditorStyles.label,
                    GUILayout.Width(60), GUILayout.Height(60));

                GUI.DrawTexture(
                    iconRect,
                    Images.GetPlasticIcon(),
                    ScaleMode.ScaleToFit);

                Rect overlayIconRect = new Rect(
                    iconRect.xMax - 30, iconRect.yMax - 24, 32, 32);

                GUI.DrawTexture(
                    overlayIconRect,
                    GetHelpIcon(alertType),
                    ScaleMode.ScaleToFit);
            }
        }

        static Texture GetHelpIcon(GuiMessage.GuiMessageType alertType)
        {
            switch (alertType)
            {
                case GuiMessage.GuiMessageType.Critical:
                    return Images.GetErrorDialogIcon();
                case GuiMessage.GuiMessageType.Warning:
                    return Images.GetWarnDialogIcon();
                default:
                    return Images.GetInfoDialogIcon();
            }
        }
    }
}
=======
>>>>>>> 11145a567cd862dce8ffefbb92a80a75add52640:Class/Library/PackageCache/com.unity.collab-proxy@1.15.16/Editor/PlasticSCM/UI/Message/DrawDialogIcon.cs
