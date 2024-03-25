Imports WeifenLuo.WinFormsUI
Imports WeifenLuo.WinFormsUI.Docking

Public Class Form1
    Dim dockPanel As WeifenLuo.WinFormsUI.Docking.DockPanel
    Sub New()
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Me.dockPanel = New WeifenLuo.WinFormsUI.Docking.DockPanel()
        Me.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dockPanel.Theme = New VS2015BlueTheme()
        Me.Controls.Add(Me.dockPanel)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Form2.Show(Me)
        Dim dockContent As New WeifenLuo.WinFormsUI.Docking.DockContent
        dockContent.Show(dockPanel, dockState:=Docking.DockState.Document)
    End Sub
End Class
