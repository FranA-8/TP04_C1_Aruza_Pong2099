using UnityEngine;
using UnityEngine.UI;

public class UiCreditsMenu : MonoBehaviour
{
    [SerializeField] private Button exit;
    [SerializeField] private GameObject creditsMenuPanel;
    [SerializeField] private GameObject mainMenuPanel;

    private void Awake()
    {
        exit.onClick.AddListener(OnExitButtonClicked);
    }

    private void OnDestroy()
    {
        exit.onClick.RemoveListener(OnExitButtonClicked);
    }

    private void OnExitButtonClicked()
    {
        creditsMenuPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}
