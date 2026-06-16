using static consolo.StaticsFacade;

namespace consolo
{
  public class GameplaySource
  {
    public void DoGameplayMethod()
    {
      Log("Gameplay message");
    }

    private void Log(string message)
    {
      StaticDebug.Gameplay.Print<GameplaySource>(message);
    }

  }
}