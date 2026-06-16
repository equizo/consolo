namespace consolo
{
  // [Serializable]
  public class Debug
  {
    public ConsoleLine Telemetry;
    public ConsoleLine Shop;
    public ConsoleLine Meta;
    public ConsoleLine Gameplay;
    public ConsoleLine Ai;
    
    // Could be interesting to explore nested types to filter logs within single category
    // public ConsoleLine Meta.Screens; 
    // public ConsoleLine MetaScreens;
  }
}