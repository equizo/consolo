using static consolo.StaticsFacade;

namespace consolo
{
  public class TelemetrySource
  {
    public void DoTelemetryMethod()
    {
      Log("telemetry message");
    }

    private void Log(string message)
    {
      StaticDebug.Telemetry.Print<TelemetrySource>(message);
    }
  }
}