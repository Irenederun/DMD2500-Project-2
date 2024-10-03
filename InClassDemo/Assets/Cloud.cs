using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 speed;
    public Vector3 leftBoundary;
    public Vector3 rightBoundary;

    public GameObject raindropPrefab;
    public GameObject raindropHolder;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + speed * Time.deltaTime;

        if (transform.position.x >= rightBoundary.x)
        {
            transform.position = leftBoundary;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(raindropPrefab, raindropHolder.transform.position, transform.rotation);
        }
    }
}
