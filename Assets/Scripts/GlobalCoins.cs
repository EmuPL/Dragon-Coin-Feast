using TMPro;
using UnityEngine;

public class GlobalCoins : MonoBehaviour
{
    [SerializeField] private TMP_Text score;
    [HideInInspector] public static int CoinCount;

    private void Update()
    {
        score.text = "Score: " + CoinCount;
    }
}
