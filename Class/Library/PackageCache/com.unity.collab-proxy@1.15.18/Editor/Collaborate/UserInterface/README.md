# Collaborate User Interface
This directory contains the logic to present the collaborate UI.

## Overview
This is the structure of the directory:
```none
<root>
  ├── TestWindows/
  ├── Bootstrap.cs
  ├── CollaborateWindow.cs
  ├── ToolbarButton.cs
  └── WindowCache.cs
```
The `TestWindows/` directory contains testing windows and is not present in release builds.

`Bootstrap.cs` provides the code to initialize the toolbar button on start up.

`CollaborateWindow.cs` is the entr