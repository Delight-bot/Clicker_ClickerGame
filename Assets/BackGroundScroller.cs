using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 2f;
    public float resetPositionX = 19.092f;   // Width of one background tile
    public float startPositionX = 19.092f;   // Distance to reposition once off-screen

    void Update()
    {
        // Move the background left
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        // If it's fully off-screen, reset position to the right
        if (transform.position.x <= -resetPositionX)
        {
            transform.position += new Vector3(startPositionX * 2f, 0, 0); // move to the right of the other background
        }
    }
}

