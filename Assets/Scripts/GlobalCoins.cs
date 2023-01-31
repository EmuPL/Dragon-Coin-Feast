using TMPro;
using UnityEngine;

public class GlobalCoins : MonoBehaviour
{
    [HideInInspector] public static int CoinCount;
    [SerializeField] private TMP_Text score;

    private void Update()
    {
        score.text = "Score: " + CoinCount;
    }
}