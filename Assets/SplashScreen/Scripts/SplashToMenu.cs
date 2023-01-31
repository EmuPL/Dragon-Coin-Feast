using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    
    private void Start()
    {
        StartCoroutine(ProceedToMenu());
    }

    private IEnumerator ProceedToMenu()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}