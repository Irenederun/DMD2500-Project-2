using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WASD : MonoBehaviour
{
    public int speed = 2;
    public float speedAlt = 5.5f;
    public float acceleration = 3.5f;

    public string theRock = "Dwayne Johnson"; 
    public string qualifier = "is famous"; 
    public string question = "Is 1+1 = 2?"; 
    public bool answer = true;

    public bool movingRight = false;

    public Vector3 horSpeed = new Vector3(2, 0, 0);

    public SpriteRenderer sp;

    public int playerHealth = 3;

    public GameObject shield;
    public GameObject wound;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(question + answer);
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += horSpeed * Time.deltaTime;
            movingRight = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= horSpeed * Time.deltaTime;
            movingRight = false;
        }

        if (movingRight == false)
        {
            sp.flipX = true;
        }
        else if (movingRight == true) 
        {
            sp.flipX = false;
        }

        

        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    playerHealth--;
        //}

    }

    public void PlayerHit()
    {
        playerHealth--;
        transform.position = Vector3.zero;


        if (playerHealth == 2)
        {
            Destroy(shield);
            //shield.SetActive(true);
        }

        if (playerHealth == 1)
        {
            wound.SetActive(true);
        }

        if (playerHealth <= 0)
        {
           PlayerDied();
        }
    }

    private void PlayerDied()
    {
        sp.color = Color.black;
        horSpeed = Vector3.zero;
        SceneManager.LoadScene("End");
    }
}
