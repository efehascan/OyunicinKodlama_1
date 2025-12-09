using System;
using UnityEngine;

namespace Ders6
{
    public class PlayerManager : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        [SerializeField] private float jumpForce;
        [SerializeField] private AudioClip blink;

        private Renderer _renderer;        
        private Rigidbody _rb;
        private AudioSource _calgiciKarisi;
        private bool _isGrounded;
        
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _renderer = GetComponent<Renderer>();
            _calgiciKarisi = GetComponent<AudioSource>();
        }

        private void Start()
        {
            _calgiciKarisi.Play();
        }

        private void Update()   
        {
            Movement();
            Jump();
        }

        private void Movement()
        {
            float x  = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            
            Vector3 move = new Vector3(x, 0, z) * moveSpeed;
            Vector3 newVelocity = new Vector3(move.x, _rb.linearVelocity.y, move.z); 
            _rb.linearVelocity = newVelocity;
        }

        private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
            {
                _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }

        private void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.CompareTag("Red"))
            {
                _calgiciKarisi.PlayOneShot(blink);
                _renderer.material.color = Color.red;
            }
            else if (collision.gameObject.CompareTag("Green"))
            {
                _calgiciKarisi.PlayOneShot(blink);
                _renderer.material.color = Color.green;
            }
            else if (collision.gameObject.CompareTag("Blue"))
            {
                _calgiciKarisi.PlayOneShot(blink);
                _renderer.material.color = Color.blue;
            }
            else if (collision.gameObject.CompareTag("Yellow"))
            {
                _calgiciKarisi.PlayOneShot(blink);
                _renderer.material.color = Color.yellow;
            }
        }


        private void OnCollisionStay(Collision collision)
        {
            _isGrounded = true;
        }

        private void OnCollisionExit(Collision collision)
        {
            _isGrounded = false;
        }
        
    }
}
