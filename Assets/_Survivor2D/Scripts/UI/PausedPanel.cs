using UnityEngine;

public class PausedPanel : MonoBehaviour
{
    public void StartAgain() => LoadSceneManager.LoadScene(Scenes.MainScene);
    public void OpenSettingsPanel(){}

    public void TurnToMainMenu() => LoadSceneManager.LoadScene(Scenes.MainMenu);
}
