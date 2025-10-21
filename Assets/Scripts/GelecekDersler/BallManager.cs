using System;
using UnityEngine;

namespace GelecekDersler
{
    public class BallManager : MonoBehaviour
    {
        private float speed = 3f;

        private void Update()
        {
            Movement();
        }

        private void Movement()
        {
            float horizontal = Input.GetAxisRaw("Horizontal"); // A - D / Sol - Sağ
            float vertical = Input.GetAxisRaw("Vertical");     // W - S / Yukarı - Aşağı

            Vector3 direction = new Vector3(horizontal, 0f, vertical);
            
            
            transform.Translate(direction * (speed * Time.deltaTime), Space.World);
            
        }


        private void OnCollisionEnter(Collision other)
        {
            Debug.Log("Top Yere Düştü");
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Trigger!");
        }
        
        
    }
}
