using static consolo.StaticsFacade;

namespace consolo
{
  public class ShopSource
  {
    public void DoShopMethod()
    {
      Log("shop message");
    }

    private void Log(string message)
    {
      StaticDebug.Shop.Print<ShopSource>(message);
    }
  }
}