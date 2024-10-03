using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int speed;
    public float speedSprinting;
    public bool isSprinting;
    public string charName = "Irene";
    
    public Vector3 hSpeed;
    public SpriteRenderer mySR;

    public int playerHealth = 3;
    public Vector3 respawnPos;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi! My name is " + charName + speed + isSprinting);
        //mySR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.LeftShift))
        //{
        //    isSprinting = true;
        //    mySR.flipX = true;
        //}

        if (Input.GetKey(KeyCode.D))
        {
            //if (isSprinting = false )
            transform.position = 
                transform.position + hSpeed * Time.deltaTime;
            //IF (isS = true)
            //rewrite the movement code with the faster speed
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = 
                transform.position - hSpeed * Time.deltaTime;
        }

        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    Debug.Log("fhdjskalfhdskjalfhadlsk");
        //    playerHealth = playerHealth - 1;
        //}
    }

    public void PlayerTakesDamage()
    {
        if (playerHealth == 2)
        {
            mySR.color = Color.yellow;
            //transform.position = respawnPos;
        }

        if (playerHealth == 1)
        {
            mySR.color = Color.red;
            //transform.position = respawnPos;
        }

        if (playerHealth <= 0)
        {
            //player should have died
            mySR.color = Color.black;
            SceneManager.LoadScene("BadEnd");
        }
    }
}
