using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AUdio : MonoBehaviour
{
    public AudioSource myAudio;
    public AudioSource myAudio2;
    public AudioClip myClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!myAudio.isPlaying)
        {
            myAudio.Play();
        //myAudio.PlayOneShot(myClip, 1f);
        } 
        if (!myAudio2.isPlaying)
        {
            myAudio2.Play();
        //myAudio.PlayOneShot(myClip, 1f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (myAudio.isPlaying)
        {
            myAudio.Stop();
        }
    }
}
