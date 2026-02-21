using UnityEngine;

public class WASDController : MonoBehaviour
{
    public KeyCode keyLeft;
    public KeyCode keyRight;

    public float moveForce = 10f;
    public float jumpForce = 7f;

    bool isGrounded;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()   
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);
        
        Vector3 dir = Vector3.zero;

        if (Input.GetKey(keyLeft))
            dir += Vector3.left;

        if (Input.GetKey(keyRight))
            dir += Vector3.right;

        if (dir != Vector3.zero)
        {
            dir.Normalize();
            rb.AddForce(dir * moveForce);
        }
    }

    void Update()
    {
        // jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
