Public NotInheritable Class Splash
    Private Sub mlpSplash_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles mlpSplash.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        frmInicio.Show()
        Timer1.Enabled = False
    End Sub
End Class
