using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update 
    void Start()
    {
        //transform.position = new Vector3(3, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 9.5f)
            {
                transform.position = transform.position + new Vector3(3f, 0f, 0f) * Time.deltaTime;
            }

            else if (transform.position.x >= 9.5f)
            {
                transform.position = new Vector3(-9.5f, 0f, 0f);
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 5f)
            {
                transform.position = transform.position + new Vector3(0f, 3f, 0) * Time.deltaTime;
            }

            else if (transform.position.y >= 5f)
            {
                transform.position = new Vector3(0f, -5f, 0f);
            }
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -9.5f)
            {
                transform.position = transform.position - new Vector3(3f, 0f, 0f) * Time.deltaTime;
            }

            else if(transform.position.x <= -9.5f)
            {
                transform.position = new Vector3(9.5f, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -5f)
            {
                transform.position = transform.position - new Vector3 (0f ,3f,0f) * Time.deltaTime;
            }
            else if(transform.position.y <= -5f)
            {
                transform.position = new Vector3(0f, 5f, 0f);
            }
        }
    }
}
