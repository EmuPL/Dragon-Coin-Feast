using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int loadLevel;
    public TMP_Text hintText;
    public int hintNum;

    public void Start()
    {
        hintNum = Random.Range(0, 3);
        if (hintNum == 0)
        {
            hintText.text = "Collect 8 coins to complete the level.";
        }
        if (hintNum == 1)
        {
            hintText.text = "Don't let the timer hit zero.";
        }
        if (hintNum == 2)
        {
            hintText.text = "Don't crash into the obstacles.";
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(GlobalLevel.levelNumber);
    }

    public void LoadGame()
    {
        loadLevel = PlayerPrefs.GetInt("LevelLoadNum");
        if (loadLevel < 3)
        {
            SceneManager.LoadScene(GlobalLevel.levelNumber);
        }
        else
        {
            GlobalLevel.levelNumber = loadLevel;
            SceneManager.LoadScene(loadLevel);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}