using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button startButton;
    [SerializeField] private Button settingsButton;

    [Header("Panels")]
    [SerializeField] private GameObject settingsPanel;

    [Header("Scene")]
    [SerializeField] private string gameSceneName = "Game";

    private void Awake()
    {
        startButton.onClick.AddListener(OnStartClicked);
        settingsButton.onClick.AddListener(OnSettingsClicked);

        if (settingsPanel != null)
            settingsPanel.SetActive(false);
    }

    private void OnDestroy()
    {
        if (startButton != null) startButton.onClick.RemoveListener(OnStartClicked);
        if (settingsButton != null) settingsButton.onClick.RemoveListener(OnSettingsClicked);
    }

    private void OnStartClicked()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    private void OnSettingsClicked()
    {
        if (settingsPanel != null)
            settingsPanel.SetActive(!settingsPanel.activeSelf);
        else
            Debug.Log("Settings clicked — no settings panel assigned yet.");
    }

    public void OnQuitClicked()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
