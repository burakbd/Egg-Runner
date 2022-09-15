using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -4.38f;
    public static float rightSide = 4.8f;
    public float internalLeft;
    public float internalRight;
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
