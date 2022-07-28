<<<<<<< HEAD:Class/Library/PackageCache/com.unity.collab-proxy@1.15.18/Editor/PlasticSCM/UI/Avatar/GetAvatar.cs
﻿using System;

using UnityEngine;

using PlasticGui;

namespace Unity.PlasticSCM.Editor.UI.Avatar
{
    internal static class GetAvatar
    {
        internal static Texture2D ForEmail(
            string email,
            Action avatarLoadedAction)
        {
            if (string.IsNullOrEmpty(email))
                return Images.GetEmptyGravatar();

            if (AvatarImages.HasGravatar(email))
                return AvatarImages.GetAvatar(email);

            Texture2D defaultImage =
                Images.GetEmptyGravatar();

            AvatarImages.AddGravatar(email, defaultImage);

            LoadAvatar.ForEmail(
                email, avatarLoadedAction,
                AfterDownloadSucceed);

            return defaultImage;
        }

        static void AfterDownloadSucceed(
            string email,
            byte[] avatarBytes,
            Action avatarLoadedAction)
        {
            AvatarImages.UpdateGravatar(email, avatarBytes);

            avatarLoadedAction();
        }
    }
}
=======
>>>>>>> 11145a567cd862dce8ffefbb92a80a75add52640:Class/Library/PackageCache/com.unity.collab-proxy@1.15.16/Editor/PlasticSCM/UI/Avatar/GetAvatar.cs
