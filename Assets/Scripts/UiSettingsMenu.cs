using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiSettingsMenu : MonoBehaviour
{
    [SerializeField] private GameObject PlayerOne;
    [SerializeField] private GameObject PlayerTwo;
    [SerializeField] private Button exit;
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject settingsMenuPanel;
    [SerializeField] private Slider speedSliderP1;
    [SerializeField] private Slider speedSliderP2;
    [SerializeField] private Slider sizeSliderP1;
    [SerializeField] private Slider sizeSliderP2;
    [SerializeField] private Slider colorSliderRedP1;
    [SerializeField] private Slider colorSliderGreenP1;
    [SerializeField] private Slider colorSliderBlueP1;
    [SerializeField] private Slider colorSliderRedP2;
    [SerializeField] private Slider colorSliderGreenP2;
    [SerializeField] private Slider colorSliderBlueP2;
    [SerializeField] private TMP_Text speedNumberP1;
    [SerializeField] private TMP_Text speedNumberP2;
    [SerializeField] private TMP_Text sizeNumberP1;
    [SerializeField] private TMP_Text sizeNumberP2;
    [SerializeField] private TMP_Text colorNumberRedP1;
    [SerializeField] private TMP_Text colorNumberGreenP1;
    [SerializeField] private TMP_Text colorNumberBlueP1;
    [SerializeField] private TMP_Text colorNumberRedP2;
    [SerializeField] private TMP_Text colorNumberGreenP2;
    [SerializeField] private TMP_Text colorNumberBlueP2;
    private SpriteRenderer playerOneSprite;
    private SpriteRenderer playerTwoSprite;
    private void Awake()
    {
        exit.onClick.AddListener(OnExitButtonClicked);
        speedSliderP1.onValueChanged.AddListener(OnSpeedSliderP1Changed);
        speedSliderP2.onValueChanged.AddListener(OnSpeedSliderP2Changed);
        sizeSliderP1.onValueChanged.AddListener(OnSizeSliderP1Changed);
        sizeSliderP2.onValueChanged.AddListener(OnSizeSliderP2Changed);
        colorSliderRedP1.onValueChanged.AddListener(OnColorSliderRedP1Changed);
        colorSliderGreenP1.onValueChanged.AddListener(OnColorSliderGreenP1Changed);
        colorSliderBlueP1.onValueChanged.AddListener(OnColorSliderBlueP1Changed);
        colorSliderRedP2.onValueChanged.AddListener(OnColorSliderRedP2Changed);
        colorSliderGreenP2.onValueChanged.AddListener(OnColorSliderGreenP2Changed);
        colorSliderBlueP2.onValueChanged.AddListener(OnColorSliderBlueP2Changed);
        playerOneSprite = PlayerOne.GetComponent<SpriteRenderer>();
        playerTwoSprite = PlayerTwo.GetComponent<SpriteRenderer>();
    }

    private void OnDestroy()
    {
        exit.onClick.RemoveListener(OnExitButtonClicked);
        speedSliderP1.onValueChanged.RemoveListener(OnSpeedSliderP1Changed);
        speedSliderP2.onValueChanged.RemoveListener(OnSpeedSliderP2Changed);
        sizeSliderP1.onValueChanged.RemoveListener(OnSizeSliderP1Changed);
        sizeSliderP2.onValueChanged.RemoveListener(OnSizeSliderP2Changed);
        colorSliderRedP1.onValueChanged.RemoveListener(OnColorSliderRedP1Changed);
        colorSliderGreenP1.onValueChanged.RemoveListener(OnColorSliderGreenP1Changed);
        colorSliderBlueP1.onValueChanged.RemoveListener(OnColorSliderBlueP1Changed);
        colorSliderRedP2.onValueChanged.RemoveListener(OnColorSliderRedP2Changed);
        colorSliderGreenP2.onValueChanged.RemoveListener(OnColorSliderGreenP2Changed);
        colorSliderBlueP2.onValueChanged.RemoveListener(OnColorSliderBlueP2Changed);
    }

    private void OnExitButtonClicked()
    {
        settingsMenuPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    private void OnSpeedSliderP1Changed(float value)
    {
        speedNumberP1.text = value.ToString("f2");
        PlayerOne.GetComponent<PlayerSpeed>().SetMoveSpeed(value);
    }

    private void OnSpeedSliderP2Changed(float value)
    {
        speedNumberP2.text = value.ToString("f2");
        PlayerTwo.GetComponent<PlayerTwoMovement>().SetMoveSpeed(value);

    }

    private void OnSizeSliderP1Changed(float value)
    {
        sizeNumberP1.text = value.ToString("f2");
        PlayerOne.transform.localScale = new Vector3(value,0.3f, 0f);
    }

    private void OnSizeSliderP2Changed(float value)
    {
        sizeNumberP2.text = value.ToString("f2");
        PlayerTwo.transform.localScale = new Vector3(value,0.3f, 0f);
    }

    private void OnColorSliderRedP1Changed(float value)
    {
        colorNumberRedP1.text = value.ToString("f0");
        float r = value / 255f;
        float g = colorSliderGreenP1.value / 255f;
        float b = colorSliderBlueP1.value / 255f;
        playerOneSprite.color = new Color(r, g, b, 1f);
    }
    private void OnColorSliderGreenP1Changed(float value)
    {
        colorNumberGreenP1.text = value.ToString("f0");
        float r = colorSliderRedP1.value / 255f;
        float g = value / 255f;
        float b = colorSliderBlueP1.value / 255f;
        playerOneSprite.color = new Color(r, g, b, 1f);
    }
    private void OnColorSliderBlueP1Changed(float value)
    {
        colorNumberBlueP1.text = value.ToString("f0");
        float r = colorSliderRedP1.value / 255f;
        float g = colorSliderGreenP1.value / 255f;
        float b = value / 255f;
        playerOneSprite.color = new Color(r, g, b, 1f);
    }

    private void OnColorSliderRedP2Changed(float value)
    {
        colorNumberRedP2.text = value.ToString("f0");
        float r = value / 255f;
        float g = colorSliderGreenP2.value / 255f;
        float b = colorSliderBlueP2.value / 255f;
        playerTwoSprite .color = new Color(r, g, b, 1f);
    }
    private void OnColorSliderGreenP2Changed(float value)
    {
        colorNumberGreenP2.text = value.ToString("f0");
        float r = colorSliderRedP2.value / 255f;
        float g = value / 255f;
        float b = colorSliderBlueP2.value / 255f;
        playerTwoSprite.color = new Color(r, g, b, 1f);
    }
    private void OnColorSliderBlueP2Changed(float value)
    {
        colorNumberBlueP2.text = value.ToString("f0");
        float r = colorSliderRedP2.value / 255f;
        float g = colorSliderGreenP2.value / 255f;
        float b = value / 255f;
        playerTwoSprite.color = new Color(r, g, b, 1f);
    }
}
