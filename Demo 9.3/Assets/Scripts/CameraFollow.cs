using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    public Transform playerTransform;
    public SpriteRenderer playerSR;
    public WASD playerScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;
        
        
        //offset = player.GetComponent<WASD>().horSpeed;
    }
}
