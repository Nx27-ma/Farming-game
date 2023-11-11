using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    //MainMenu
    public void MainMenuStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenuSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void MainMenuQuit()
    {
        //Application.Quit();
        Debug.Log("Player Quit the game!");
    }

    //Settings
    public void SettingsReturn()
    {
        SceneManager.LoadScene("MainMenu");
    }
}