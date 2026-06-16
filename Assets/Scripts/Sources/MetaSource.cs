using static consolo.StaticsFacade;

namespace consolo
{
  public class MetaSource
  {
    public void DoMetaMethod()
    {
      Log("Meta message");
    }

    private void Log(string message)
    {
      StaticDebug.Meta.Print<MetaSource>(message);
    }
  }
}