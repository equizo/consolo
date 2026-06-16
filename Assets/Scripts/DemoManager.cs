using UnityEngine;
using UnityEngine.UI;

namespace consolo
{
  public class DemoManager : MonoBehaviour
  {
    [SerializeField] private Button telemetryButton;
    [SerializeField] private Button shopButton;
    [SerializeField] private Button metaButton;
    [SerializeField] private Button aiButton;
    [SerializeField] private Button gameplayButton;

    private TelemetrySource telemetrySource;
    private ShopSource shopSource;
    private MetaSource metaSource;
    private AiSource aisSource;
    private GameplaySource gameplaySource;

    private void Start()
    {
      StaticData.Init();

      telemetrySource = new TelemetrySource();
      shopSource = new ShopSource();
      metaSource = new MetaSource();
      aisSource = new AiSource();
      gameplaySource = new GameplaySource();

      telemetryButton.onClick.AddListener(OnTelemetry);
      shopButton.onClick.AddListener(OnShop);
      metaButton.onClick.AddListener(OnMeta);
      aiButton.onClick.AddListener(OnAi);
      gameplayButton.onClick.AddListener(OnGameplay);
    }

    private void OnTelemetry()
    {
      telemetrySource.DoTelemetryMethod();
    }

    private void OnShop()
    {
      shopSource.DoShopMethod();
    }

    private void OnMeta()
    {
      metaSource.DoMetaMethod();
    }

    private void OnAi()
    {
      aisSource.DoAiMethod();
    }

    private void OnGameplay()
    {
      gameplaySource.DoGameplayMethod();
    }

    private void OnDestroy()
    {
      telemetryButton.onClick.RemoveListener(OnTelemetry);
      shopButton.onClick.RemoveListener(OnShop);
    }
  }
}