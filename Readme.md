<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128642575/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T191939)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication102/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication102/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication102/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication102/MainWindow.xaml.vb))
<!-- default file list end -->
# How to use WorkspaceManager to save layout of multiple controls

[WorkspaceManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.WorkspaceManager) can be used to save a layout of multiple controls in one container. Only controls that support [DXSerializer](https://docs.devexpress.com/WPF/7409/common-concepts/saving-and-restoring-layouts/saving-and-restoring-layout-basics) can be serialized by `WorkspaceManager`.

To enable `WorkspaceManager`, set the [WorkspaceManager.IsEnabled](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.WorkspaceManager.IsEnabled) attached property to `true`. To save the layout, call the `CaptureWorkspace` and `SaveWorkspace` methods.

To correctly save and restore the layout of controls, ensure that all [dock items](https://docs.devexpress.com/WPF/7209/controls-and-libraries/layout-management/dock-windows/dock-items) and [layout items](https://docs.devexpress.com/WPF/7223/controls-and-libraries/layout-management/dock-windows/layout-items) have the `Name` properties specified or the [BaseLayoutItem.BindableName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.BaseLayoutItem.BindableName) property bound. If two or more managers are [linked](https://docs.devexpress.com/WPF/400980/controls-and-libraries/layout-management/dock-windows/miscellaneous/move-layout-panels-between-dock-layout-managers), item names must be unique across these managers.
