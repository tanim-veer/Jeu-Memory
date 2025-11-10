Module ModuleScoreUtils

    Public Function ExtraireNom(scoreLigne As String) As String
        Try
            Dim parts = scoreLigne.Split(New String() {" - "}, StringSplitOptions.None)
            Return parts(0).Trim()
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ' Une fonction utilitaire qui extrait le temps utilisé depuis une ligne de score.
    Public Function ExtraireTemps(scoreLigne As String) As Integer
        Try
            Dim parts = scoreLigne.Split(New String() {" - "}, StringSplitOptions.None)
            Dim tempsStr = parts(3).Split(":"c)(1).Trim().Replace("s", "")
            Return Integer.Parse(tempsStr)
        Catch ex As Exception
            Return -1
        End Try
    End Function

    ' Une fonction utilitaire qui vérifie si une ligne de score est valide.
    Public Function LigneScoreValide(scoreLigne As String) As Boolean
        Return scoreLigne.Contains("Paires trouvées") AndAlso scoreLigne.Contains("Temps utilisé") AndAlso scoreLigne.Contains("Durée")
    End Function

End Module
