using System.Collections.Generic;
using System.IO;

using Codice.Client.Commands.Mount;
using Codice.Client.Commands.WkTree;
using Codice.Client.Common;
using Codice.Client.Common.GameUI;
using Codice.CM.Common;
using Codice.CM.WorkspaceServer.DataStore.Configuration;

namespace Unity.PlasticSCM.Editor.Configuration
{
    internal static class ConfigurePartialWorkspace
    {
        internal static void AsFullyChecked(WorkspaceInfo wkInfo)
        {
            string rootPath = WorkspacePath.GetWorkspac