using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raindrop : MonoBehaviour
{
    public float lowerLimit;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= lowerLimit)
        {
            Destroy(gameObject);
        }
    }
}
