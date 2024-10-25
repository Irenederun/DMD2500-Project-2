using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().flipX = false;
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
            GetComponent<SpriteRenderer>().flipX = true;
            if (transform.position.x > -9.5f)
            {
                transform.position = transform.position - new Vector3(3f, 0f, 0f) * Time.deltaTime;
            }

            else if (transform.position.x <= -9.5f)
            {
                transform.position = new Vector3(9.5f, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -5f)
            {
                transform.position = transform.position - new Vector3(0f, 3f, 0f) * Time.deltaTime;
            }
            else if (transform.position.y <= -5f)
            {
                transform.position = new Vector3(0f, 5f, 0f);
            }
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Animator>().SetTrigger("walk");
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            GetComponent<Animator>().SetTrigger("stop");
        }
    }
}
