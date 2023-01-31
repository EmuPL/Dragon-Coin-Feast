using UnityEngine;

public class GlobalLevel : MonoBehaviour
{
    [HideInInspector] public static int levelNumber = 3;
    [HideInInspector] public int internalNum;

    private void Update()
    {
        internalNum = levelNumber;
    }
}