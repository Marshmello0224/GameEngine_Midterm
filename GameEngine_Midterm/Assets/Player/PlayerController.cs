using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static PlayerController instance;
    private float force = 5.0f;
    private Rigidbody rb;

    
  
  
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(moveDirection * force);
    }
}
