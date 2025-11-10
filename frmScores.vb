Imports System.IO
Public Class frmScores
    Private Shared scores As New List(Of String)
    Private Const fichierScores As String = "scores.txt"

    Private Class ScoreInfo
        Public Property Nom As String
        Public Property Temps As Integer
        Public Property Duree As Integer
    End Class

    Private Sub ChargerScores()
        scores.Clear()
        If File.Exists(fichierScores) Then
            scores.AddRange(File.ReadAllLines(fichierScores))
        End If
    End Sub

    Private Sub SauvegarderScores()
        File.WriteAllLines(fichierScores, scores)
    End Sub

    Public Sub AjouterScore(nom As String, paires As Integer, tempsUtilise As Integer, dureeTotale As Integer)
        Dim partiesJoueur = scores.Where(Function(s) s.StartsWith(nom & " - Partie")).Count()
        Dim numeroPartie = partiesJoueur + 1
        Dim nouveauScore As String = $"{nom} - Partie {numeroPartie} - Paires trouvées : {paires} - Temps utilisé : {tempsUtilise}s - Durée : {dureeTotale}s"
        scores.Add(nouveauScore)
        lstScores.Items.Add(nouveauScore)
        SauvegarderScores()
        AfficherMeilleurTemps()
    End Sub

    Private Function ParserScore(ligne As String) As ScoreInfo
        Try
            Dim parts = ligne.Split(New String() {" - "}, StringSplitOptions.None)
            Dim nom = parts(0).Trim()
            Dim tempsStr = parts(3).Split(":"c)(1).Trim().Replace("s", "")
            Dim dureeStr = parts(4).Split(":"c)(1).Trim().Replace("s", "")
            Return New ScoreInfo With {
                .Nom = nom,
                .Temps = Integer.Parse(tempsStr),
                .Duree = Integer.Parse(dureeStr)
            }
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Sub AfficherMeilleurTemps()
        Dim scoresInfo = New List(Of ScoreInfo)
        Dim groupes = scoresInfo.GroupBy(Function(si) si.Nom & " a choisi : " & si.Duree & "s")

        For Each ligne In scores
            Dim info = ParserScore(ligne)
            If info IsNot Nothing Then
                scoresInfo.Add(info)
            End If
        Next

        scoresInfo = scoresInfo.OrderBy(Function(si) si.Nom).ToList()
        lstMeilleurScore.Items.Clear()

        For Each groupe In groupes
            Dim nom = groupe.Key
            Dim meilleurTemps = groupe.Min(Function(si) si.Temps)
            lstMeilleurScore.Items.Add($" {nom} / Meilleur Temps : {meilleurTemps}s")
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        scores.Clear()
        lstScores.Items.Clear()
        lstMeilleurScore.Items.Clear()
    End Sub

    Private Sub frmScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cheminImage As String = IO.Path.Combine(Application.StartupPath, "Images\cinema5.jpg")

        ChargerScores()
        lstScores.Items.Clear()
        scores.Sort()

        For Each s In scores
            lstScores.Items.Add(s)
        Next
        AfficherMeilleurTemps()

        Me.BackgroundImage = Image.FromFile(cheminImage)
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub frmScores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SauvegarderScores()
    End Sub

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub
End Class
