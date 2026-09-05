
namespace LaVieDeBob
{
    public static class Utilitaires
    {
        // "Utiliraires" est une classe servant à avancer le temps.
        public static DateTime PasserLeTemps(DateTime temps, int heures)
        {
            /// Fontion qui fait avancer le temps en heures.
            /// Param "temps": l'heure actuelle en temps réel.
            /// Param "heures": Nombres d'heures à avancer.
            /// Return : Le temps avancé avec les heures.
            return temps.AddHours(heures);
        }
    }
}