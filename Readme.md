# How to use WorkspaceManager to save layout of multiple controls


<p>WorkspaceManager can be used to save a layout of multiple controls in one container. Only controls that support DXSerializer can be serialized by WorkspaceManager. These controls are: GridControl, TreeListControl, DockLayoutManager, BarManager, RibbonControl.</p>
<p>To enable WorkspaceManager, set the WorkspaceManager.IsEnabled attached property to "True". To save the layout, call the CaptureWorkspace and SaveWorkspace methods.</p>

<br/>


