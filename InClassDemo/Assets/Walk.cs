using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public float force;
    public float jumpForce;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(- transform.right * force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(- transform.forward * force);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * force);
        }
    }
}
