using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private void Update()
    {
        transform.LookAt(player.transform);
    }
}