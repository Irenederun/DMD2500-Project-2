using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    float rotateX;
    float rotateY;

    // Update is called once per frame
    void Update()
    {
        rotateX = Input.GetAxis("Mouse X");
        rotateY = -Input.GetAxis("Mouse Y");

        transform.eulerAngles += new Vector3(rotateY, rotateX, 0);
    }
}
