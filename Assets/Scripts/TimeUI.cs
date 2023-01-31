using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeUI : MonoBehaviour
{
    public int Seconds = 30;
    [HideInInspector] public bool DeductingTime;
    [SerializeField] private TMP_Text time;
    [SerializeField] private GameObject fadeOut;
    [SerializeField] private GameObject timeUpText;
    [SerializeField] private GameObject player;

    private void Update()
    {
        if (Seconds == 0)
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            Seconds = 0;
            timeUpText.SetActive(true);
            fadeOut.SetActive(true);
            StartCoroutine(RespawningLevel());
        }
        else
        {
            if (DeductingTime == false)
            {
                DeductingTime = true;
                StartCoroutine(DeductSecund());
            }
        }
    }

    private IEnumerator DeductSecund()
    {
        yield return new WaitForSeconds(1);
        Seconds -= 1;
        time.text = "Time: " + Seconds;
        DeductingTime = false;
    }

    private IEnumerator RespawningLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }
}