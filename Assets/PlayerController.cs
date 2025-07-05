// Holds the player's jump Function
// When clicked in the ClickRegisterUI, the PlayerJump function will be called.

using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f;
    public bool isGrounded;
    private Rigidbody2D rb;
    

    void Awake() => rb = GetComponent<Rigidbody2D>();

    // Called in the ClickRegisterUI Button Component (OnClick)
    public void PlayerJump(){ 
        if (isGrounded) 
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
        }
    }
    
    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Floor"))
        {
            isGrounded = false;
        }
    }

}
