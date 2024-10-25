using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Treasure : MonoBehaviour
{
    public Vector3 location0;
    public Vector3 location1;
    public int capturedTimes;
    public string goToSceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        location0 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        ResetLocation(); 
    }

    void ResetLocation()
    {
        capturedTimes++;

        if (capturedTimes == 1)
        {
            transform.position = location1;
        }
        if (capturedTimes == 2)
        {
            SceneManager.LoadScene(goToSceneName);
        }
    }
}
