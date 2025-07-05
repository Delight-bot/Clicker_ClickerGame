using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;  // Bronze = 1, Silver = 5, Gold = 10

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Increase score or money
            PointManager.Instance.AddPoints(value); 
            Destroy(gameObject);  // Remove coin after collection
        }
    }
}

