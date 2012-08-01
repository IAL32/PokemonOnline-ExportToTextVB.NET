Public Class Form1
    Dim MFBool As String
    Dim i, HP, Atk, Def, SAtk, SDef, Spd As Short
    Private Sub lst_Pokemon_Scroll()
        'Uso questa sub per far si che il numero sia uguale
        'edequivalente al Numero Pokémon corrispondente.
        lst_Numbers.TopIndex = lst_Pokemon.TopIndex
    End Sub
    Private Sub lst_Numbers_Scroll()
        'Uso questa sub per far si che il numero sia uguale
        'edequivalente al Numero Pokémon corrispondente.
        lst_Pokemon.TopIndex = lst_Numbers.TopIndex
    End Sub
    Private Sub lst_Pokemon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_Pokemon.SelectedIndexChanged
        cmb_Forms_Filler()
        'Ho aggiunto la gestione degli errori "Try", perché non tutti
        'i Pokémon sono diversi nella loro parte femmina, quindi
        'ogniqualvoltail programma non troverà il corrispondente
        'di immagine femmina in sprites\female, non farà niente, ma si
        'limiterà a mettere "Male" come sesso pre-impostato.
        lst_Numbers.SelectedIndex = lst_Pokemon.SelectedIndex
        Select Case rd_Male.Checked
            Case True
                'Se Maschio
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & ".png")
            Case False
                'Se Femmina
                Try
                    btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\female\" & lst_Pokemon.SelectedIndex & ".png")
                Catch FNF As System.IO.FileNotFoundException
                    rd_Male.Checked = True
                End Try
        End Select
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Con questo ciclo For...Next, genero una lista da 0 a 649
        '(il numero dei pokémon)che poi va a riempire la lista dei numeri.
        Dim lst(649) As String
        For i As Short = 0 To 649
            lst(i) = i
            lst_Numbers.Items.Add(i)
        Next
        lst_Pokemon.SelectedIndex = 0
        cmb_Forms.SelectedIndex = 0
        cmb_Nature.SelectedIndex = 0
        cmb_Items.SelectedIndex = 0
        cmb_Move1.SelectedIndex = 0
        cmb_Move2.SelectedIndex = 0
        cmb_Move3.SelectedIndex = 0
        cmb_Move4.SelectedIndex = 0
        cmb_Trait.SelectedIndex = 0
    End Sub
    Private Sub rd_Female_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_Female.CheckedChanged
        'Ho aggiunto la gestione degli errori "Try", perché non tutti
        'i Pokémon sono diversi nella loro parte femmina, quindi
        'ogniqualvoltail programma non troverà il corrispondente
        'di immagine femmina in sprites\female, non farà niente, ma si
        'limiterà a mettere "Male" come sesso pre-impostato.
        Select Case rd_Female.Checked
            Case True
                Try
                    MFBool = "F"
                    btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\female\" & lst_Pokemon.SelectedIndex & ".png")
                Catch FNFExc As IO.FileNotFoundException
                    rd_Male.Checked = True
                End Try
            Case False
                MFBool = "M"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & ".png")
        End Select
    End Sub
    Private Sub rd_Male_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd_Male.CheckedChanged
        'Indica se il Pokémon è maschio
        Select Case rd_Male.Checked
            Case True
                MFBool = "M"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & ".png")
            Case False
                'Ho aggiunto la gestione degli errori "Try", perché non tutti
                'i Pokémon sono diversi nella loro parte femmina, quindi
                'ogniqualvoltail programma non troverà il corrispondente
                'di immagine femmina in sprites\female, non farà niente, ma si
                'limiterà a mettere "Male" come sesso pre-impostato.
                MFBool = "F"
                Try
                    btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\female\" & lst_Pokemon.SelectedIndex & ".png")
                Catch FNFExc As IO.FileNotFoundException
                    rd_Male.Checked = True
                End Try
        End Select
    End Sub
    Public Sub cmb_Forms_Filler()
        'La sub indica al programma come comportarsi a seconda del
        'Pokémon scelto,aggiungendo per ciascuno la sua lista di forme
        'disponibili. Se il pokémon non ha forme alternative, allora il
        'programma darà solo come opzione "Nothing".
        cmb_Forms.Items.Clear()
        Select Case lst_Pokemon.SelectedItem
            Case "Unown"
                cmb_Forms.Items.Add("A")
                cmb_Forms.Items.Add("B")
                cmb_Forms.Items.Add("C")
                cmb_Forms.Items.Add("D")
                cmb_Forms.Items.Add("E")
                cmb_Forms.Items.Add("F")
                cmb_Forms.Items.Add("G")
                cmb_Forms.Items.Add("H")
                cmb_Forms.Items.Add("I")
                cmb_Forms.Items.Add("J")
                cmb_Forms.Items.Add("K")
                cmb_Forms.Items.Add("L")
                cmb_Forms.Items.Add("M")
                cmb_Forms.Items.Add("N")
                cmb_Forms.Items.Add("O")
                cmb_Forms.Items.Add("P")
                cmb_Forms.Items.Add("Q")
                cmb_Forms.Items.Add("R")
                cmb_Forms.Items.Add("S")
                cmb_Forms.Items.Add("T")
                cmb_Forms.Items.Add("U")
                cmb_Forms.Items.Add("V")
                cmb_Forms.Items.Add("W")
                cmb_Forms.Items.Add("X")
                cmb_Forms.Items.Add("Y")
                cmb_Forms.Items.Add("Z")
                cmb_Forms.Items.Add("?")
                cmb_Forms.Items.Add("!")
            Case "Deoxys"
                cmb_Forms.Items.Add("Normal")
                cmb_Forms.Items.Add("Attack")
                cmb_Forms.Items.Add("Defense")
                cmb_Forms.Items.Add("Speed")

            Case "Shellos"
                cmb_Forms.Items.Add("West")
                cmb_Forms.Items.Add("East")
            Case "Rotom"
                cmb_Forms.Items.Add("Normal")
                cmb_Forms.Items.Add("Heat")
                cmb_Forms.Items.Add("Wash")
                cmb_Forms.Items.Add("Frost")
                cmb_Forms.Items.Add("Fan")
                cmb_Forms.Items.Add("Cut")
            Case "493 - Arceus"
                cmb_Forms.Items.Add("Normal")
                cmb_Forms.Items.Add("Fist")
                cmb_Forms.Items.Add("Sky")
                cmb_Forms.Items.Add("Toxic")
                cmb_Forms.Items.Add("Earth")
                cmb_Forms.Items.Add("Stone")
                cmb_Forms.Items.Add("Insect")
                cmb_Forms.Items.Add("Spooky")
                cmb_Forms.Items.Add("Iron")
                cmb_Forms.Items.Add("Flame")
                cmb_Forms.Items.Add("Splash")
                cmb_Forms.Items.Add("Meadow")
                cmb_Forms.Items.Add("Zap")
                cmb_Forms.Items.Add("Mind")
                cmb_Forms.Items.Add("Icicle")
                cmb_Forms.Items.Add("Draco")
                cmb_Forms.Items.Add("Dread")
                cmb_Forms.Items.Add("Curse")
            Case "Basculin"
                cmb_Forms.Items.Add("Red-Striped")
                cmb_Forms.Items.Add("Blue-Striped")
            Case "Darmanitan"
                cmb_Forms.Items.Add("Normal")
                cmb_Forms.Items.Add("Zen")
            Case "Kyurem"
                cmb_Forms.Items.Add("Normal")
                cmb_Forms.Items.Add("Black")
                cmb_Forms.Items.Add("White")
            Case "Keldeo"
                cmb_Forms.Items.Add("Ordinary")
                cmb_Forms.Items.Add("Resolute")
            Case "Meloetta"
                cmb_Forms.Items.Add("Aria")
                cmb_Forms.Items.Add("Pirouette")
            Case Else
                cmb_Forms.Items.Clear()
                cmb_Forms.Items.Add("Nothing")
        End Select
        cmb_Forms.SelectedIndex = 0
    End Sub
    Public Sub btn_Image_Adapter()
        'La sub indica al programma come comportarsi a seconda della
        'forma del pokémon scelta.
        Select Case cmb_Forms.SelectedItem
            '201 - Unown
            Case "A"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "" & ".png")
            Case "B"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-1" & ".png")
            Case "C"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-2" & ".png")
            Case "D"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-3" & ".png")
            Case "E"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-4" & ".png")
            Case "F"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-5" & ".png")
            Case "G"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-6" & ".png")
            Case "H"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-7" & ".png")
            Case "I"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-8" & ".png")
            Case "J"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-9" & ".png")
            Case "K"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-10" & ".png")
            Case "L"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-11" & ".png")
            Case "M"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-12" & ".png")
            Case "N"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-13" & ".png")
            Case "O"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-14" & ".png")
            Case "P"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-15" & ".png")
            Case "Q"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-16" & ".png")
            Case "R"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-17" & ".png")
            Case "S"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-18" & ".png")
            Case "T"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-19" & ".png")
            Case "U"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-20" & ".png")
            Case "V"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-21" & ".png")
            Case "W"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-22" & ".png")
            Case "X"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-23" & ".png")
            Case "Y"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-24" & ".png")
            Case "Z"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-25" & ".png")
            Case "!"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-26" & ".png")
            Case "?"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-27" & ".png")

                '386 - Deoxys
            Case "Normal"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "" & ".png")
            Case "Attack"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-1" & ".png")
            Case "Speed"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-2" & ".png")
            Case "Defense"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-3" & ".png")

                '422 - Shellos
            Case "West"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "" & ".png")
            Case "East"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-1" & ".png")

                '493 - Arceus
            Case "Normal"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "" & ".png")
            Case "Fist"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-1" & ".png")
            Case "Sky"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-2" & ".png")
            Case "Toxic"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-3" & ".png")
            Case "Earth"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-4" & ".png")
            Case "Stone"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-5" & ".png")
            Case "Insect"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-6" & ".png")
            Case "Spooky"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-7" & ".png")
            Case "Iron"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-8" & ".png")
            Case "Flame"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-9" & ".png")
            Case "Splash"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-10" & ".png")
            Case "Meadow"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-11" & ".png")
            Case "Zap"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-12" & ".png")
            Case "Mind"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-13" & ".png")
            Case "Icicle"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-14" & ".png")
            Case "Draco"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-15" & ".png")
            Case "Dread"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-16" & ".png")
            Case "Curse"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-17" & ".png")

                '550 - Basculin
            Case "Red-Striped"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "" & ".png")
            Case "Blue-Striped"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-1" & ".png")

                '555 - Darmanitan
            Case "Normal"
                If lst_Pokemon.SelectedIndex = 555 Then
                    btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "" & ".png")
                End If
            Case "Zen"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-1" & ".png")

                '646 - Kyurem
            Case "Normal"
                If lst_Pokemon.SelectedIndex = 646 Then
                    btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "" & ".png")
                End If
            Case "Black"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-1" & ".png")
            Case "White"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-2" & ".png")

                '647 - Keldeo
            Case "Ordinary"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "" & ".png")
            Case "Resolute"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-1" & ".png")

                '648 - Meloetta
            Case "Aria"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "" & ".png")
            Case "Pirouette"
                btn_Pokemon.Image = Image.FromFile(Application.StartupPath & "\sprites\" & lst_Pokemon.SelectedIndex & "-1" & ".png")

            Case "Nothing"
        End Select
    End Sub
    Private Sub cmb_Forms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Forms.SelectedIndexChanged
        btn_Image_Adapter()
        i = cmb_Forms.SelectedIndex
    End Sub
    Private Sub txt_SearchText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_SearchText.TextChanged
        Dim index As Integer = lst_Pokemon.FindString(txt_SearchText.Text)
        If 0 <= index Then
            lst_Pokemon.SelectedIndex = index
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lst_Pokemon_Scroll()
    End Sub
    Private Sub lst_Numbers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_Numbers.SelectedIndexChanged
        lst_Pokemon.SelectedIndex = lst_Numbers.SelectedIndex
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.youtube.com/IAL32")
    End Sub
    Private Sub btn_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Export.Click
        Preview.TextBox1.AppendText(lst_Pokemon.SelectedItem & " (" & MFBool & ") " & "@" & cmb_Items.SelectedItem _
                                    & vbCrLf & "Trait:  " & cmb_Trait.SelectedItem _
                                    & vbCrLf & "EVs: " & nup_EVHP.Value & " HP / " & nup_EVAtk.Value & " Atk / " & nup_EVDef.Value & " Def / " & nup_EVSAtk.Value & " SAtk / " & nup_EVSDef.Value & " SDef / " & nup_EVSpd.Value & " Spd" _
                                    & vbCrLf & cmb_Nature.SelectedItem & "(Nature)" _
                                    & vbCrLf & "- " & cmb_Move1.SelectedItem _
                                    & vbCrLf & "- " & cmb_Move2.SelectedItem _
                                    & vbCrLf & "- " & cmb_Move3.SelectedItem _
                                    & vbCrLf & "- " & cmb_Move4.SelectedItem _
                                    & vbCrLf)
        Preview.ShowDialog()
    End Sub
#Region "Ev's Numeric Up-Down""
    Private Sub nup_EVHP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nup_EVHP.ValueChanged
        Select Case nup_EVHP.Value
            Case 252 To 255
                nup_EVHP.ForeColor = Color.Red
            Case 0 To 251
                nup_EVHP.ForeColor = Color.Green
        End Select
        TabPage2.Text = "EVs | Sum: " & nup_EVHP.Value + nup_EVAtk.Value + nup_EVDef.Value + nup_EVSpd.Value + nup_EVSAtk.Value + nup_EVSDef.Value
    End Sub
    Private Sub nup_EVAtk_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nup_EVAtk.ValueChanged
        Select Case nup_EVAtk.Value
            Case 252 To 255
                nup_EVAtk.ForeColor = Color.Red
            Case 0 To 251
                nup_EVAtk.ForeColor = Color.Green
        End Select
        TabPage2.Text = "EVs | Sum: " & nup_EVHP.Value + nup_EVAtk.Value + nup_EVDef.Value + nup_EVSpd.Value + nup_EVSAtk.Value + nup_EVSDef.Value
    End Sub
    Private Sub nup_EVDef_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nup_EVDef.ValueChanged
        Select Case nup_EVDef.Value
            Case 252 To 255
                nup_EVDef.ForeColor = Color.Red
            Case 0 To 251
                nup_EVDef.ForeColor = Color.Green
        End Select
        TabPage2.Text = "EVs | Sum: " & nup_EVHP.Value + nup_EVAtk.Value + nup_EVDef.Value + nup_EVSpd.Value + nup_EVSAtk.Value + nup_EVSDef.Value
    End Sub
    Private Sub nup_EVSAtk_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nup_EVSAtk.ValueChanged
        Select Case nup_EVSAtk.Value
            Case 252 To 255
                nup_EVSAtk.ForeColor = Color.Red
            Case 0 To 251
                nup_EVSAtk.ForeColor = Color.Green
        End Select
        TabPage2.Text = "EVs | Sum: " & nup_EVHP.Value + nup_EVAtk.Value + nup_EVDef.Value + nup_EVSpd.Value + nup_EVSAtk.Value + nup_EVSDef.Value
    End Sub
    Private Sub nup_EVSDef_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nup_EVSDef.ValueChanged
        Select Case nup_EVSDef.Value
            Case 252 To 255
                nup_EVSDef.ForeColor = Color.Red
            Case 0 To 251
                nup_EVSDef.ForeColor = Color.Green
        End Select
        TabPage2.Text = "EVs | Sum: " & nup_EVHP.Value + nup_EVAtk.Value + nup_EVDef.Value + nup_EVSpd.Value + nup_EVSAtk.Value + nup_EVSDef.Value
    End Sub
    Private Sub nup_EVSpd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nup_EVSpd.ValueChanged
        Select Case nup_EVSpd.Value
            Case 252 To 255
                nup_EVSpd.ForeColor = Color.Red
            Case 0 To 251
                nup_EVSpd.ForeColor = Color.Green
        End Select
        TabPage2.Text = "EVs | Sum: " & nup_EVHP.Value + nup_EVAtk.Value + nup_EVDef.Value + nup_EVSpd.Value + nup_EVSAtk.Value + nup_EVSDef.Value
    End Sub
#End Region
End Class
