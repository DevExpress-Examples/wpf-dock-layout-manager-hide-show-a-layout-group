Imports System.Windows
Imports System.Windows.Controls

Namespace CreateLayoutGroups

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.RootGroup.Items.Remove(Me.LayoutGroup3)
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.RootGroup.Items.Add(Me.LayoutGroup3)
        End Sub
    End Class
End Namespace
