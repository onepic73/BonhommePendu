using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer chaque fois que la lettre n'est pas dans le mot
    public class WrongGuessEvent : GameEvent
    {
        // TODO: Compléter
        public WrongGuessEvent(GameData gameData) {
            gameData.NbWrongGuesses++;
        }
    }
}
