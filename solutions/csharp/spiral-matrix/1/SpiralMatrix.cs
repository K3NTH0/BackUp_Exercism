public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] matrice = new int[size, size];

        // Les 4 directions possible dans l'ordre : droite, bas, gauche, haut
        // Chaque direction est un décalage (deltaLigne, deltaColonne)
        int[] deltaLigne = { 0, 1, 0, -1 };
        int[] deltaColonne = { 1, 0, -1, 0 };

        int ligneActuelle = 0;
        int colonneActuelle = 0;
        int directionActuelle = 0; // index dans les tableaux delta : 0=droite, 1=bas, 2=gauche, 3=haut

        for (int valeur = 1; valeur <= size * size; valeur++)
        {
            // On place la valeur courante dans la case actuelle
            matrice[ligneActuelle, colonneActuelle] = valeur;

            // On calcule la position de la prochaine case si on continue tout droit
            int prochaineLigne = ligneActuelle + deltaLigne[directionActuelle];
            int prochaineColonne = colonneActuelle + deltaColonne[directionActuelle];

            // On vérifie si cette prochaine case est valide :
            // soit elle sort de la grille, soit elle est déjà remplie
            bool horsLimites = prochaineLigne < 0 || prochaineLigne >= size
                                                  || prochaineColonne < 0 || prochaineColonne >= size;

            bool dejaOccupee = !horsLimites && matrice[prochaineLigne, prochaineColonne] != 0;

            if (horsLimites || dejaOccupee)
            {
                // La case suivante n'est pas valide : on tourne à la prochaine direction
                // (droite -> bas -> gauche -> haut -> droite ...)
                directionActuelle = (directionActuelle + 1) % 4;

                // On recalcule la prochaine position avec la nouvelle direction
                prochaineLigne = ligneActuelle + deltaLigne[directionActuelle];
                prochaineColonne = colonneActuelle + deltaColonne[directionActuelle];
            }

            // On avance à la nouvelle position pour la prochaine itération
            ligneActuelle = prochaineLigne;
            colonneActuelle = prochaineColonne;
        }

        return matrice;
    }
}
