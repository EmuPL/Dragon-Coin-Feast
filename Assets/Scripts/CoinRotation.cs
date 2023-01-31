using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    private float rotateSpeed = 0.5f;

    private void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.timeScale, 0, Space.World);
    }
}