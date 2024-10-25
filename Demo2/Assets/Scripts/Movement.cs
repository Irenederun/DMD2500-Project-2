using System.Collections;
using System.Collections.Generic;
using UnityEngine; //this is the library sections 

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update 
    void Start()
    {
        //transform.position = new Vector3(1, 0, 0); //reset starting location
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            if (transform.position.x < 9.5f)
            {
                //transform.position = transform.position + new Vector3(2, 0, 0) * Time.deltaTime;
                transform.position += new Vector3(2, 0, 0) * Time.deltaTime;
            }

            else if (transform.position.x >= 9.5f)
            {
                transform.position = new Vector3(-9.5f, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 5.5f)
            {
                transform.position += new Vector3(0, 2f, 0) * Time.deltaTime;
            }

            else if (transform.position.y >= 5.5f)
            {
                transform.position = new Vector3(0, -5.5f, 0);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -5.5f)
            {
                transform.position -= new Vector3(0, 2f, 0) * Time.deltaTime;
            }

            else if (transform.position.y <= -5.5f)
            {
                transform.position = new Vector3(0, 5.5f, 0);
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            if (transform.position.x > -9.5f)
            {
                transform.position = transform.position - new Vector3(2, 0, 0) * Time.deltaTime;
            }

            else if (transform.position.x <= -9.5f)
            {
                transform.position = new Vector3(9.5f, 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Animator>().SetTrigger("walk");

        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            GetComponent<Animator>().SetTrigger("stop");
        }

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    if (transform.position.y < 5.5f)
        //    {
        //        transform.position += new Vector3(0, 1f, 0);
        //    }

        //    else if (transform.position.y >= 5.5f)
        //    {
        //        transform.position = new Vector3(0, -5.5f, 0);
        //    }
        //}

        //if (Input.GetKeyUp(KeyCode.W))
        //{
        //    if (transform.position.y < 5.5f)
        //    {
        //        transform.position -= new Vector3(0, 1f, 0);
        //    }

        //    else if (transform.position.y >= 5.5f)
        //    {
        //        transform.position = new Vector3(0, -5.5f, 0);
        //    }
        //}
    }

}
