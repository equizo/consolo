using System.Linq;

namespace consolo
{
  // [Serializable]
  public class ConsoleLine
  {
    public bool IsPrinting;
    public string Color;

    // Serialization-free project
    public ConsoleLine(bool isPrinting, string color)
    {
      IsPrinting = isPrinting;
      Color = color;
    }

    public virtual void Print<T>(string text, string prefix = "")
    {
      if (IsPrinting) {
        UnityEngine.Debug.Log($"{prefix} <color={Color}>{typeof(T).ToString().Split('.').Last()}</color> {text}"
          .Trim());
      }
    }
  }
}