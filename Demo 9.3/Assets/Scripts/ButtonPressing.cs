using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressing : MonoBehaviour
{
    bool clicked = false;
    public GameObject showOnClick;
    public GameObject hideOnClick;

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
        if (clicked == false) // before the clicking happens.
        {
            showOnClick.SetActive(true);
            hideOnClick.SetActive(false);
            clicked = true;
        }

        else if (clicked == true)
        {
            showOnClick.SetActive(false);
            hideOnClick.SetActive(true);
            clicked = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        showOnClick.SetActive(true);
        hideOnClick.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        showOnClick.SetActive(false);
        hideOnClick.SetActive(true);
    }
}
