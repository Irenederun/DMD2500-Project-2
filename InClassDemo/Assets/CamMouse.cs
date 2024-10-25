using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMouse : MonoBehaviour
{
    float rotateY;
    float rotateX;

    private void Update()
    {
        rotateX = Input.GetAxis("Mouse X");
        rotateY = - Input.GetAxis("Mouse Y");

        transform.eulerAngles += new Vector3(rotateY, rotateX);
    }
}
