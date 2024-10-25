using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public WASD playerScript;

    private void Update()
    {
        transform.position += Vector3.up * Time.deltaTime;

        if (transform.position.y >=5)
        {
            transform.position = new Vector3(transform.position.x, -5, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered!");
        //SceneManager.LoadScene(1);
        //playerScript.playerHealth--;
        playerScript.PlayerHit();
    }
}
