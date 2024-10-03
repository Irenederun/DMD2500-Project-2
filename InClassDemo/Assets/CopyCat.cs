using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyCat : MonoBehaviour
{
    public Vector3 offset;
    public Transform playerTransform;
    public SpriteRenderer playerSR;
    public Player playerScript;
    public Collider2D playerCollider;

    public SpriteRenderer mySR;
      
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;
        mySR.color = playerSR.color;
    }
}
