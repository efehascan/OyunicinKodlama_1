
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float jumpForce = 5f;

    private Rigidbody rb;
    private bool isGrounded = false;

    private float horizontal;
    private float vertical;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        direction = direction.normalized;

        rb.AddForce(direction * moveSpeed);
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        isGrounded = false;

        Debug.Log("Zýpladýn!");

        AudioManager.instance.PlayJumpSound();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Yerdesin!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GreenBall"))
        {
            ScoreManager.instance.AddScore(10);

            AudioManager.instance.PlayGreenBallSound();

            Debug.Log("GreenBall! +10 Puan");

            Destroy(other.gameObject);
        }
        else if (other.CompareTag("RedBall"))
        {
            ScoreManager.instance.RemoveScore(5);

            AudioManager.instance.PlayRedBallSound();

            Debug.Log("RedBall! -5 Puan");

            Destroy(other.gameObject);
        }
    }
}
