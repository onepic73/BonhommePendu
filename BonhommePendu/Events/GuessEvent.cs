using BonhommePendu.Models;
using System.Runtime.CompilerServices;

namespace BonhommePendu.Events
{
    // Un événement à créer chaque fois qu'un utilisateur essai une "nouvelle" lettre
    public class GuessEvent : GameEvent
    {
        // TODO: Compléter
        public GuessEvent(GameData gameData, char letter) {
            // TODO: Commencez par ICI
            this.Events = new List<GameEvent>();

            var e = new GuessedLetterEvent(gameData, letter);

            this.Events.Add(e);


            bool findLetter = false;
            for (int i = 0; i < gameData.Word.Length - 1; i++)
            {
                bool presentLetter = gameData.HasSameLetterAtIndex(letter, i);
                if (presentLetter)
                {
                    findLetter = true;
                }
            }
            if (!findLetter)
            {
                var w = new WrongGuessEvent(gameData);
                this.Events.Add(w);
            }
        }
    }
}
