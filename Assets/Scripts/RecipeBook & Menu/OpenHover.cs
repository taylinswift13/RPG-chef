using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHover : MonoBehaviour
{
    public GameObject HoverWindow;

    private PersistentItemsScript PI;

    private void Start()
    {
        PI = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>();
    }
    public void OpenHoverWindow()
    {
        if (PI.MenuOpen == false)
        {
            if (HoverWindow.activeSelf)
                HoverWindow.SetActive(false);
            else
                HoverWindow.SetActive(true);
        }
    }
}
