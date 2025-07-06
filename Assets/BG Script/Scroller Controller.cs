using UnityEngine;

public class ScrollerController : MonoBehaviour
{
    private float startPos, length;
    public GameObject cam;
    public float parallaxEffect; //The speed at which the background should move relative to the camera

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      startPos = transform.position.x; 
      length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = cam.transform.position.x * parallaxEffect; // 0 = does not move || 1 = moves with camera || 0.5 = half
        float movement = cam.transform.position.x * (parallaxEffect);

        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        //if background has reached the end of its length adjust its position for infinite scrolling
        if (movement > startPos + length)
        {
            startPos += length;
        }
        else if (movement < startPos - length)
        {
             startPos -= length;
        }
        


    }
}
