using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Settings")]
    public float jumpForce = 10;

    [Header("References")]
    public Rigidbody2D playerRigidbody2D;
    public Animator playerAnimator;


    public bool isGrounded = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRigidbody2D.AddForceY(jumpForce, ForceMode2D.Impulse);
            playerAnimator.SetInteger("state", 1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        playerAnimator.SetInteger("state", 2);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

}

