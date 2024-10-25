using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource myAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (myAudio.isPlaying == false)
        {
            myAudio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (myAudio.isPlaying == true)
        {
            myAudio.Stop();
        }
    }

}
