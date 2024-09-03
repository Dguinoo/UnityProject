using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject GameOver;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0; // make the game frezze or stop
    }

    public void Home()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1; 
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1; // make the game continue 
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
