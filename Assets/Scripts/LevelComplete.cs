using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    [SerializeField] private int coins;
    [SerializeField] private GameObject fadeOut;
    [SerializeField] private GameObject completeText;
    [SerializeField] private GameObject player;

    private void Update()
    {
        coins = GlobalCoins.CoinCount;
        if (coins == 8)
        {
            StartCoroutine(LevelCompete());
        }
    }

    private IEnumerator LevelCompete()
    {
        yield return new WaitForSeconds(0.2f);
        completeText.SetActive(true);
        fadeOut.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = false;
        yield return new WaitForSeconds(3);
        GlobalLevel.levelNumber += 1;
        PlayerPrefs.SetInt("LevelLoadNum", GlobalLevel.levelNumber);
        SceneManager.LoadScene(2);
    }
}