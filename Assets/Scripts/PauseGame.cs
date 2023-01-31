using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    private bool gamePaused = false;
    [SerializeField] private GameObject pauseMenu;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (gamePaused == false)
            {
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                this.GetComponent<AudioSource>().Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(false);
                this.GetComponent<AudioSource>().UnPause();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
            }
        }
    }

    public void ResumeLevel()
    {
        pauseMenu.SetActive(false);
        this.GetComponent<AudioSource>().UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1;
        GlobalCoins.CoinCount = 0;
        SceneManager.LoadScene(GlobalLevel.levelNumber);
    }

    public void Menu()
    {
        Time.timeScale = 1;
        GlobalCoins.CoinCount = 0;
        GlobalLevel.levelNumber = 3;
        SceneManager.LoadScene(1);
    }
}