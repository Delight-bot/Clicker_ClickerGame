using UnityEngine;

public class CoinMover : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // Destroy if it moves too far off screen
        if (transform.position.x > 20f)
        {
            Destroy(gameObject);
        }
    }
}
