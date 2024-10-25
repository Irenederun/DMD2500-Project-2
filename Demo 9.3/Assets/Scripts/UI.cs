using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject showOnClick;
    public GameObject hideOnClick;

    int clickTimes;

    // Start is called before the first frame update
    void Start()
    {
        showOnClick.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (clickTimes == 0)
        {
            showOnClick.SetActive(true);
            hideOnClick.SetActive(false);
            clickTimes = 1;
        }
        else if (clickTimes == 1)
        {
            showOnClick.SetActive(false);
            hideOnClick.SetActive(true);
            clickTimes = 0;
        }
    }
}
