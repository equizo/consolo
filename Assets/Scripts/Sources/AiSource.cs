using static consolo.StaticsFacade;

namespace consolo
{
  public class AiSource
  {
    public void DoAiMethod()
    {
      Log("ai message");
    }

    private void Log(string message)
    {
      StaticDebug.Ai.Print<AiSource>(message);
    }
  }
}