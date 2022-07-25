using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Cloud.Collaborate.UserInterface;
using Unity.Cloud.Collaborate.Utilities;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Unity.Cloud.Collaborate.Components.Menus
{
    [UsedImplicitly]
    internal class FloatingMenu
    {
        public const string ussClassName = "unity-floating-menu";

        // Fields used to display the option list.
        const float k_ItemHeight = 28f;
        re