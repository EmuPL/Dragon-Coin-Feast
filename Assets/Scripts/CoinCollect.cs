using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    [SerializeField] private AudioSource collect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            collect.Play();
            GlobalCoins.CoinCount += 1;
            this.gameObject.SetActive(false);
        }
    }
}