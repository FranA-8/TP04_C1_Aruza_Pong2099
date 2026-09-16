using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiPauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuPanel;
    [SerializeField] private GameObject settingsMenuPanel;
    [SerializeField] private GameObject creditsMenuPanel;

    [SerializeField] private Button continueButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button backSettingsButton;
    [SerializeField] private Button backCreditsButton;
    bool isPaused = false;

    private void Awake()
    {
        continueButton.onClick.AddListener(OnContinueButtonClicked);
        exitButton.onClick.AddListener(OnExitButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        creditsButton.onClick.AddListener(OnCreditsButtonClicked);
        backSettingsButton.onClick.AddListener(OnBackSettingsButtonClicked);
        backCreditsButton.onClick.AddListener(OnBackCreditsButtonClicked);
    }

    private void OnDestroy()
    {
        continueButton.onClick.RemoveListener(OnContinueButtonClicked);
        exitButton.onClick.RemoveListener(OnExitButtonClicked);
        settingsButton.onClick.RemoveListener(OnSettingsButtonClicked);
        creditsButton.onClick.RemoveListener(OnCreditsButtonClicked);
        backSettingsButton.onClick.RemoveListener(OnBackSettingsButtonClicked);
        backCreditsButton.onClick.RemoveListener(OnBackCreditsButtonClicked);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            pauseMenuPanel.SetActive(isPaused);
            if (isPaused)
                Time.timeScale = 0f;
            else 
                Time.timeScale = 1f;
        }
    }

    private void OnContinueButtonClicked()
    {
        pauseMenuPanel.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }
    private void OnSettingsButtonClicked()
    {
        pauseMenuPanel.SetActive(false);
        settingsMenuPanel.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
    }
    private void OnBackSettingsButtonClicked()
    {
        settingsMenuPanel.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }

    private void OnCreditsButtonClicked()
    {
        pauseMenuPanel.SetActive(false);
        creditsMenuPanel.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
    }
    private void OnBackCreditsButtonClicked()
    {
        creditsMenuPanel.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }

    private void OnExitButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
