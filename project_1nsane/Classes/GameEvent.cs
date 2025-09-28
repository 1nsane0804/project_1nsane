using System;
using System.Security.Cryptography.X509Certificates;

namespace ProjectInsane.Classes
{
  public class GameEvent
  {
    public string Description { get; set; }
    public Action<Player> ApplyEffect { get; set; }

    public static List<GameEvent> GenerateEvents()
    {
      return new List<GameEvent>
      {
        new GameEvent 
        { 
          Description = "You find a small bag of gold!", 
          ApplyEffect = (player) => player.Gold += 50 
        },
        new GameEvent 
        { 
          Description = "You drink a healing potion.", 
          ApplyEffect = (player) => player.Health += 20 
        }
        // Add more events...
    };
        
    }
  }
}