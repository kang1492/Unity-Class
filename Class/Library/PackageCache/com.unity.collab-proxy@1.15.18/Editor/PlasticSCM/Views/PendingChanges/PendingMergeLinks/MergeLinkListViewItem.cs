<<<<<<< HEAD:Class/Library/PackageCache/com.unity.collab-proxy@1.15.18/Editor/PlasticSCM/Views/PendingChanges/PendingMergeLinks/MergeLinkListViewItem.cs
﻿using UnityEditor.IMGUI.Controls;

using PlasticGui.WorkspaceWindow.PendingChanges;
using Unity.PlasticSCM.Editor.UI;

namespace Unity.PlasticSCM.Editor.Views.PendingChanges.PendingMergeLinks
{
    internal class MergeLinkListViewItem : TreeViewItem
    {
        internal MountPendingMergeLink MergeLink { get; private set; }

        internal MergeLinkListViewItem(int id, MountPendingMergeLink mergeLink)
            : base(id, 0)
        {
            MergeLink = mergeLink;

            displayName = mergeLink.GetPendingMergeLinkText();
            icon = Images.GetMergeLinkIcon();
        }
    }
}

=======
>>>>>>> 11145a567cd862dce8ffefbb92a80a75add52640:Class/Library/PackageCache/com.unity.collab-proxy@1.15.16/Editor/PlasticSCM/Views/PendingChanges/PendingMergeLinks/MergeLinkListViewItem.cs
