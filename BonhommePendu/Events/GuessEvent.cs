using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer chaque fois qu'un utilisateur essai une "nouvelle" lettre
    public class GuessEvent : GameEvent
    {
        public override string EventType { get { return "Guess"; } }

        // TODO: Compléter
        public GuessEvent(GameData gameData, char letter)
        {
            // TODO: Commencez par ICI
            var guessedLetterEvent = new GuessedLetterEvent(gameData, letter);
            var wrongGuessEvent = new WrongGuessEvent(gameData);
            var winEvent = new WinEvent(gameData);
            var lostEvent = new LoseEvent(gameData);

            var mot = gameData.Word;

            //Guess
            this.Events.Add(guessedLetterEvent);

            //wrongGuess
            if (!gameData.Word.Contains(letter))
            {
                this.Events.Add(wrongGuessEvent);
            }


            //GoodGuess
            for (int i = 0; i < gameData.Word.Length; i++)
            {
                if (gameData.Word[i] == letter)
                {
                    var revealLetterEvent = new RevealLetterEvent(gameData, letter, i);
                    this.Events.Add(revealLetterEvent);
                };
            }

            //if (gameData.Won)
            //{
            //    this.Events.Add(winEvent);
            //}

            //if (gameData.Lost)
            //{
            //    this.Events.Add(lostEvent);
            //}

        }
    }
}
