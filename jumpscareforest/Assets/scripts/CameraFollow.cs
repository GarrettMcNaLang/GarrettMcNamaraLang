
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //the character
    public GameObject Target;
    //how much distance the character can move freely before our camera starts moving
    public Vector2 Offset;
    //defined boundary box
    public Vector2 threshold;

    void Update()
    {
        //formula that calculates threshold
        private Vector3 calculateThreshold()
        {
            //defines aspect ratio of camera
            Rect aspect = Camera.main.pixelRect;
        }
    }
}
