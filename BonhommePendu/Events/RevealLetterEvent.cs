using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer pour CHAQUE positon d'une lettre que l'on veut révéler (alors il faut faire plusieurs événements si la lettre est là plusieurs fois!)
    public class RevealLetterEvent : GameEvent
    {
        public override string EventType { get { return "RevealLetter"; } }

        public char Letter { get; set; }
        public int index { get; set; }

        public bool HasGuessed { get; set; }

        public RevealLetterEvent(GameData gameData, char letter, int mIndex)
        {
            // Conseil: Vous pouvez utiliser gameData.RevealLetter mettre à jour gameData
            gameData.RevealLetter(index);

            Letter = letter;
            index = mIndex;
            // Conseil: Vous pouvez utiliser gameData.HasGuessedTheWord pour savoir si c'est une victoire
            HasGuessed = gameData.HasGuessedTheWord;
        }
    }
}
