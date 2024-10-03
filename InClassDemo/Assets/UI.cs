using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    bool clicked;
    public GameObject showOnClick;
    public GameObject hideOnClick;

    // Start is called before the first frame update
    void Start()
    {
        clicked = false;
        showOnClick.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (clicked == false) // when game starts, or not clicked yet
        {
            showOnClick.SetActive(true);
            hideOnClick.SetActive(false);
            clicked = true;
        }
        else if (clicked == true) //second time clicking
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
