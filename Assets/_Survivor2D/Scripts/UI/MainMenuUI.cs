using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public void StartGame() => LoadSceneManager.LoadScene(Scenes.MainScene);
    public void OpenSettingsPanel(){}
    public void QuitGame() => Application.Quit();

}
