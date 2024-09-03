using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject InstructionMenu;
    public void GoToInstructions()
    {
        SceneManager.LoadSceneAsync("InstructionMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("GameScene1");
    }
}
