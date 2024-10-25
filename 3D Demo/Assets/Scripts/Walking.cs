using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public float moveForce;
    public float jumpForce;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce);
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * moveForce);  //t.r = Vector3 (1,0,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * moveForce); //(-1,0,0)
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * moveForce);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * moveForce);
        }
    }
}
