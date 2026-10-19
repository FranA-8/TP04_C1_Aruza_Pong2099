using System;
using Unity.VectorGraphics;
// Error: `using UnityEditor.Rendering;` en un script de runtime rompe el Build. Acá no se usa nada de ese namespace.
// Borrá la línea. Con esto y las otras dos el proyecto vuelve a poder buildearse, que para el TP04 es obligatorio porque hay que publicar en Itch.io.
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiMainMenu : MonoBehaviour
{
    [SerializeField] private Button play;
    [SerializeField] private Button settings;
    [SerializeField] private Button credits;
    [SerializeField] private Button exit;
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject settingsMenuPanel;
    [SerializeField] private GameObject creditsMenuPanel;



    void Awake()
    {
        play.onClick.AddListener(OnPlayClicked);
        settings.onClick.AddListener(OnSettingsClicked);
        credits.onClick.AddListener(OnCreditsClicked);
        exit.onClick.AddListener(OnExitClicked);
    }
    private void OnDestroy()
    {
        play.onClick.RemoveListener(OnPlayClicked);
        settings.onClick.RemoveListener(OnSettingsClicked);
        credits.onClick.RemoveListener(OnCreditsClicked);
        exit.onClick.RemoveListener(OnExitClicked);
    }

    private void OnPlayClicked()
    {
        // Warning: "Gameplay" escrito a mano acá y "MainMenu" en GoalZP1.cs:53, GoalZP2.cs:55 y UiPauseMenu.cs:87. Si renombrás una escena el proyecto compila igual y falla recién en runtime.
        // Declaralos como const string en una clase compartida.
        SceneManager.LoadScene("Gameplay");
    }

    private void OnSettingsClicked()
    {
      mainMenuPanel.SetActive(false);
      settingsMenuPanel.SetActive(true);
    }

    private void OnCreditsClicked()
    {
      mainMenuPanel.SetActive(false);
      creditsMenuPanel.SetActive(true);
    }

    private void OnExitClicked()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
}
