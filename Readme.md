<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication102/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication102/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication102/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/WpfApplication102/MainWindow.xaml))
<!-- default file list end -->
# How to use WorkspaceManager to save layout of multiple controls


<p>WorkspaceManager can be used to save a layout of multiple controls in one container. Only controls that support DXSerializer can be serialized by WorkspaceManager. These controls are: GridControl, TreeListControl, DockLayoutManager, BarManager, RibbonControl.</p>
<p>To enable WorkspaceManager, set the WorkspaceManager.IsEnabled attached property to "True". To save the layout, call the CaptureWorkspace and SaveWorkspace methods.</p>

<br/>


