''Thibault ANIN                                                 2019                                               -- Dedi Orsay TP2E --

Public Class Moteur
    Private minMort As Integer
    Private maxMort As Integer
    Private minNaissance As Integer
    Private maxNaissance As Integer
    Private largeurGrille As Integer
    Private hauteurGrille As Integer
    Private cellules(,) As Cellule
    Private mur As Boolean

    Sub setRegle(ByRef minMort As Integer, ByRef maxMort As Integer, ByRef minNaissance As Integer, ByRef maxNaissance As Integer)
        Me.minMort = minMort
        Me.maxMort = maxMort
        Me.minNaissance = minNaissance
        Me.maxNaissance = maxNaissance
    End Sub

    Sub setTailleGrille(ByRef n As Integer, ByRef m As Integer)
        Me.largeurGrille = n
        Me.hauteurGrille = m
        ReDim cellules(largeurGrille, hauteurGrille)

        'remplissage du tableau de cellules à deux dimensions
        For i = 0 To largeurGrille
            For j = 0 To hauteurGrille
                cellules(i, j) = New Cellule
                With cellules(i, j)
                    .Vivante = False
                    .VivanteSuivante = False
                End With
            Next
        Next
    End Sub

    Sub getTailleGrille(ByVal n As Integer, ByVal m As Integer)

    End Sub

    Sub setEtatCellule(ByRef i As Integer, ByRef j As Integer, ByRef etat As Boolean)
        cellules(i, j).Vivante = etat
    End Sub

    Function getEtatCellule(ByVal i As Integer, ByVal j As Integer) As Boolean
        Return cellules(i, j).Vivante
    End Function

    Sub etatSuivant()
        verifMort()
        verifVie()
        'Mise a jour du tableau de cellule avec les nouveaux états et remise à l'etat initial de "VivanteSuivante" (False)
        For largeur = 0 To largeurGrille
            For hauteur = 0 To hauteurGrille
                cellules(largeur, hauteur).Vivante = cellules(largeur, hauteur).VivanteSuivante
                cellules(largeur, hauteur).VivanteSuivante = False
            Next
        Next
    End Sub

    Sub verifMort()
        Dim cpt = 0, ligne, colonne As Integer
        'Incrementation d'un compteur pour connaitre le nombre de cellule vivante qui entour la cellule testée
        For largeur = 0 To largeurGrille
            For hauteur = 0 To hauteurGrille
                cpt = 0
                If cellules(largeur, hauteur).Vivante = False Then
                    For k = largeur - 1 To largeur + 1
                        ligne = k
                        'Si la ligne est negative, on repasse soit de l'autre coté de la fenetre (ligne coté opposé),
                        'si l'option "Mur" est désactivé, sinon (si otion "Mur" coché) la cellule est arreté.
                        If ligne = -1 Then
                            If mur = False Then
                                ligne = largeurGrille
                            Else
                                ligne = ligne + 1
                            End If
                        End If
                        'Si la ligne depasse la taille du tableau, on repasse soit de l'autre coté de la fenetre (ligne coté opposé),
                        'si l'option "Mur" est désactivé, sinon (si otion "Mur" coché) la cellule est arreté.
                        If ligne = largeurGrille + 1 Then
                            If mur = False Then
                                ligne = 0
                            Else
                                ligne = ligne - 1
                            End If
                        End If
                        colonne = hauteur - 1
                        'Si la colonne est negative, on repasse soit de l'autre coté de la fenetre (colonne du coté opposé),
                        'si l'option "Mur" est désactivé, sinon (si otion "Mur" coché) la cellule est arreté.
                        If colonne = -1 Then
                            If mur = False Then
                                colonne = hauteurGrille
                            Else
                                colonne = colonne + 1
                            End If
                        End If
                        If cellules(ligne, colonne).Vivante = True Then
                            cpt += 1
                        End If
                        colonne = hauteur + 1
                        'Si la colonne depasse la taille du tableau, on repasse soit de l'autre coté de la fenetre (colonne du coté opposé),
                        'si l'option "Mur" est désactivé, sinon (si otion "Mur" coché) la cellule est arreté.
                        If colonne = hauteurGrille + 1 Then
                            If mur = False Then
                                colonne = 0
                            Else
                                colonne = colonne - 1
                            End If
                        End If
                        If cellules(ligne, colonne).Vivante = True Then
                            cpt += 1
                        End If
                    Next
                    colonne = hauteur
                    ligne = largeur - 1
                    'Si la ligne est negative, on repasse soit de l'autre coté de la fenetre (ligne coté opposé),
                    'si l'option "Mur" est désactivé, sinon (si otion "Mur" coché) la cellule est arreté.
                    If ligne = -1 Then
                        If mur = False Then
                            ligne = largeurGrille
                        Else
                            ligne = ligne + 1
                        End If
                    End If
                    If cellules(ligne, colonne).Vivante = True Then
                        cpt += 1
                    End If
                    'Si la ligne depasse la taille du tableau, on repasse soit de l'autre coté de la fenetre (ligne coté opposé),
                    'si l'option "Mur" est désactivé, sinon (si otion "Mur" coché) la cellule est arreté.
                    ligne = largeur + 1
                    If ligne = largeurGrille + 1 Then
                        If mur = False Then
                            ligne = 0
                        Else
                            ligne = ligne - 1
                        End If
                    End If
                    If cellules(ligne, colonne).Vivante = True Then
                        cpt += 1
                    End If
                    'Utilisation du compteur pour determiner l'etat suivant de la cellule testée selon les règles entrées par l'utilisateur
                    For i = minNaissance To maxNaissance
                        If cpt = i Then
                            cellules(largeur, hauteur).VivanteSuivante = True
                        End If
                    Next
                End If
            Next
        Next
    End Sub

    Sub verifVie()
        Dim cpt = 0, ligne, colonne As Integer
        'Incrementation d'un compteur pour connaitre le nombre de cellule vivante qui entour la cellule testée
        For largeur = 0 To largeurGrille
            For hauteur = 0 To hauteurGrille
                cpt = 0
                If cellules(largeur, hauteur).Vivante = True Then
                    For k = largeur - 1 To largeur + 1
                        ligne = k
                        If ligne = -1 Then
                            If mur = False Then
                                ligne = largeurGrille
                            Else
                                ligne = ligne + 1
                            End If
                        End If
                        'Si la ligne depasse la taille du tableau, on repasse soit de l'autre coté de la fenetre (ligne coté opposé),
                        'si l'option "Mur" est désactivé, sinon (si otion "Mur" coché) la cellule est arreté.
                        If ligne = largeurGrille + 1 Then '
                            If mur = False Then
                                ligne = 0
                            Else
                                ligne = ligne - 1
                            End If
                        End If
                        colonne = hauteur - 1
                        'Si la colonne est negative, on repasse soit de l'autre coté de la fenetre (colonne du coté opposé),
                        'si l'option "Mur" est désactivé, sinon (si otion "Mur" coché) la cellule est arreté.
                        If colonne = -1 Then
                            If mur = False Then
                                colonne = hauteurGrille
                            Else
                                colonne = colonne + 1
                            End If
                        End If
                        If cellules(ligne, colonne).Vivante = True Then
                            cpt += 1
                        End If
                        colonne = hauteur + 1
                        'Si la colonne depasse la taille du tableau, on repasse soit de l'autre coté de la fenetre (colonne du coté opposé),
                        'si l'option "Mur" est désactivé, sinon (si otion "Mur" coché) la cellule est arreté.
                        If colonne = hauteurGrille + 1 Then '
                            If mur = False Then
                                colonne = 0
                            Else
                                colonne = colonne - 1
                            End If
                        End If
                        If cellules(ligne, colonne).Vivante = True Then
                            cpt += 1
                        End If
                    Next
                    colonne = hauteur
                    ligne = largeur - 1
                    'Si la ligne est negative, on repasse soit de l'autre coté de la fenetre (ligne coté opposé),
                    'si l'option "Mur" est désactivé, sinon (si otion "Mur" coché) la cellule est arreté.
                    If ligne = -1 Then
                        If mur = False Then
                            ligne = largeurGrille
                        Else
                            ligne = ligne + 1
                        End If
                    End If
                    If cellules(ligne, colonne).Vivante = True Then
                        cpt += 1
                    End If
                    ligne = largeur + 1
                    'Si la ligne depasse la taille du tableau, on repasse soit de l'autre coté de la fenetre (ligne coté opposé),
                    'si l'option "Mur" est désactivé, sinon (si otion "Mur" coché) la cellule est arreté.
                    If ligne = largeurGrille + 1 Then '
                        If mur = False Then
                            ligne = 0
                        Else
                            ligne = ligne - 1
                        End If
                    End If
                    colonne = hauteur
                    If cellules(ligne, colonne).Vivante = True Then
                        cpt += 1
                    End If
                    'Utilisation du compteur pour determiner l'etat suivant de la cellule testée selon les règles entrées par l'utilisateur
                    If minMort = maxMort Then
                        If cpt = maxNaissance Then cellules(largeur, hauteur).VivanteSuivante = True
                    Else
                        If cpt < minMort Then cellules(largeur, hauteur).VivanteSuivante = False
                        If cpt = minMort Then cellules(largeur, hauteur).VivanteSuivante = True
                        If cpt = maxMort Then cellules(largeur, hauteur).VivanteSuivante = True
                        If cpt > maxMort Then cellules(largeur, hauteur).VivanteSuivante = False
                    End If
                End If
            Next
        Next
    End Sub

    'fonctionnalité uniquement disponible avec mon Interface

    Public Sub setMur(ByVal mur As Boolean)
        Me.mur = mur
    End Sub

End Class

Public Class Cellule
    'creation d'une class "Cellule" pour faciliter la manipulation des états d'une cellule
    Public Property Vivante As Boolean
    Public Property VivanteSuivante As Boolean
    Public Property VivantePrecedante As Boolean
End Class