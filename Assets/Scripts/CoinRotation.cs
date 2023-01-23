using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    private float rotateSpeed = 0.5f;

    private void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}