<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication102/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication102/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication102/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication102/MainWindow.xaml.vb))
<!-- default file list end -->
# How to use WorkspaceManager to save layout of multiple controls

WorkspaceManager can be used to save a layout of multiple controls in one container. Only controls that support DXSerializer can be serialized by WorkspaceManager. These controls are: GridControl, TreeListControl, DockLayoutManager, BarManager, RibbonControl.

To enable WorkspaceManager, set the WorkspaceManager.IsEnabled attached property to "True". To save the layout, call the CaptureWorkspace and SaveWorkspace methods.

To correctly save and restore the layout of controls, ensure that all [dock items](https://docs.devexpress.com/WPF/7209/controls-and-libraries/layout-management/dock-windows/dock-items) and [layout items](https://docs.devexpress.com/WPF/7223/controls-and-libraries/layout-management/dock-windows/layout-items) have the **Name** properties specified or the [BaseLayoutItem.BindableName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.BaseLayoutItem.BindableName) property bound. If two or more managers are [linked](https://docs.devexpress.com/WPF/400980/controls-and-libraries/layout-management/dock-windows/miscellaneous/move-layout-panels-between-dock-layout-managers), item names must be unique across these managers.
