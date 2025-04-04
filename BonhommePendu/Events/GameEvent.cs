using System.Text.Json.Serialization;

namespace BonhommePendu.Events
{
    // Les événements sont tous déjà enregistrés, SAUF Win
    [JsonDerivedType(typeof(GuessEvent))]
    [JsonDerivedType(typeof(WrongGuessEvent))]
    [JsonDerivedType(typeof(RevealLetterEvent))]
    [JsonDerivedType(typeof(LoseEvent))]
    [JsonDerivedType(typeof(GuessedLetterEvent))]
    [JsonDerivedType(typeof(WinEvent))]
    public abstract class GameEvent
    {
        public abstract string EventType { get; }

        //TODO 101 : Pk g du ajouter ca -----------------------------¬
        public List<GameEvent>? Events { get; set; } = new List<GameEvent>();

      
    }
}
