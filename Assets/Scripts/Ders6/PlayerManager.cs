using System;
using UnityEngine;

namespace Ders6
{
    public class PlayerManager : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        [SerializeField] private float jumpForce;
        
        private Rigidbody _rb;
        private bool _isGrounded;
        
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
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
