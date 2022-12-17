Imports DevExpress.Xpf.Core
Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Controls

Namespace WpfApplication102

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim customers As ObservableCollection(Of Customer) = New ObservableCollection(Of Customer)()
            For i As Integer = 1 To 30 - 1
                customers.Add(New Customer() With {.ID = i, .Name = "Name" & i})
            Next

            Me.gridControl1.ItemsSource = customers
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim workspaceManager As WorkspaceManager = TryCast(DevExpress.Xpf.Core.WorkspaceManager.GetWorkspaceManager(Me.dockLayoutManager), WorkspaceManager)
            workspaceManager.CaptureWorkspace("workspace1")
            workspaceManager.SaveWorkspace("workspace1", "layout.xml")
        End Sub

        Private Sub Button_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim workspaceManager As WorkspaceManager = TryCast(DevExpress.Xpf.Core.WorkspaceManager.GetWorkspaceManager(Me.dockLayoutManager), WorkspaceManager)
            workspaceManager.LoadWorkspace("workspace1", "layout.xml")
            workspaceManager.ApplyWorkspace("workspace1")
        End Sub
    End Class

    Public Class Customer

        Public Property ID As Integer

        Public Property Name As String
    End Class
End Namespace
