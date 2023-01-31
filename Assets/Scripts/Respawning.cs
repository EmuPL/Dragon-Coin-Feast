using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawning : MonoBehaviour
{
    private void Start()
    {
        GlobalCoins.CoinCount = 0;
        SceneManager.LoadScene(GlobalLevel.levelNumber);
    }
}