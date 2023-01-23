using UnityEngine;


public class CoinCollect : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GlobalCoins.CoinCount +=  1;
            this.gameObject.SetActive(false);
        }
    }
}
