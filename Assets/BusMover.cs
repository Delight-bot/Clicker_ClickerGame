using UnityEngine;

public class BusMover : MonoBehaviour
{
    public float speed = 1.8f; // How fast the bus moves
    public float targetX = 0f; // X-position where bus should stop

    void Update()
    {
        // Move the bus towards targetX
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}

