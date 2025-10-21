using System.ComponentModel;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallManager : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3.5f;

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical);


        transform.Translate(direction * (moveSpeed * Time.deltaTime), Space.World);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bir nesneye çarptı!");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("İçinden geçti!");      
    }

}
