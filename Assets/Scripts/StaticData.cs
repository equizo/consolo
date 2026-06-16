using Debug = consolo.Debug;

namespace consolo
{
  public static class StaticData
  {
    public static Debug Debug;

    public static void Init()
    {
      Debug = new Debug();
      DeserializeDebugConfig();
    }

    // Config with text colors and flags
    private static void DeserializeDebugConfig()
    {
      var shallPrintTelemetryMessages = true;
      Debug.Telemetry = new ConsoleLine(shallPrintTelemetryMessages, "#00FF00");

      var shallPrintShopMessages = true;
      Debug.Shop = new ConsoleLine(shallPrintShopMessages, "#FF1100");

      var shallPrintMetaMessages = true;
      Debug.Meta = new ConsoleLine(shallPrintMetaMessages, "#005133");

      var shallPrintGameplayMessages = true;
      Debug.Gameplay = new ConsoleLine(shallPrintGameplayMessages, "#0003AB");

      var shallPrintAiMessages = true;
      Debug.Ai = new ConsoleLine(shallPrintAiMessages, "#F0AB22");
    }
  }
}