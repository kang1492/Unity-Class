<<<<<<< HEAD:Class/Library/PackageCache/com.unity.collab-proxy@1.15.18/Tests/Editor/PlasticSCM/UI/TextureLoadTests.cs
﻿using NUnit.Framework;

using UnityEngine;
using UnityEngine.Profiling;

using Unity.PlasticSCM.Editor.UI;

namespace Unity.PlasticSCM.Tests.Editor.UI
{
    [TestFixture]
    internal class TextureLoadTests
    {
        // NOTE(rafa): thes are no real test just use cases to verify in the profiler what happens when load more than once the same texture.

        [Test]
        public void OneLoad_Reference()
        {
            Profiler.BeginSample("TextureLoadTest - One load");

            var icon = Images.GetPlasticIcon();

            Profiler.EndSample();

            Assert.NotNull(icon);
        }

        [Test]
        public void OneHundredLoads_Reference()
        {
            var icons = new Texture[100];

            Profiler.BeginSample("TextureLoadTest - One hundred loads");

            for (int i = 0; i < 100; i++)
                icons[i] = Images.GetPlasticIcon();

            Profiler.EndSample();

            CollectionAssert.AllItemsAreNotNull(icons);
        }
    }
}
=======
>>>>>>> 11145a567cd862dce8ffefbb92a80a75add52640:Class/Library/PackageCache/com.unity.collab-proxy@1.15.16/Tests/Editor/PlasticSCM/UI/TextureLoadTests.cs
