using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatacterSpeak : MonoBehaviour
{
    public GameObject words;
     int clickTimes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (clickTimes == 0) 
        {
            words.SetActive(true);
            clickTimes = 1;
        }

        else if (clickTimes == 1) 
        {
            words.SetActive(false); 
            clickTimes = 0;
        }
    }
}
