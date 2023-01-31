using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollide : MonoBehaviour
{
    [SerializeField] private GameObject fadeOut;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            gameOverText.SetActive(true);
            fadeOut.SetActive(true);
            StartCoroutine(RespawningLevel());
        }
    }

    private IEnumerator RespawningLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }
}