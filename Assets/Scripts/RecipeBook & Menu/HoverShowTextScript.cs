using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HoverShowTextScript : MonoBehaviour
{
    public GameObject HoverText;
    public GameObject[] RecipePages;
    public int PageNumber;

    public bool RecipeTitle;

    private PersistentItemsScript PI;

    private void Start()
    {
        PI = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>();
    }

    private void OnMouseOver()
    {
        if (PI.MenuOpen == false && RecipeTitle == false)
        {
            HoverText.SetActive(true);
        }

        if (RecipeTitle == true)
        {
            this.gameObject.GetComponent<TMP_Text>().color = Color.red;
        }
    }
    private void OnMouseExit()
    {
        if (PI.MenuOpen == false && RecipeTitle == false)
        {
            HoverText.SetActive(false);
        }

        if (RecipeTitle == true)
        {
            this.gameObject.GetComponent<TMP_Text>().color = Color.black;
        }
    }
    private void OnMouseDown() //Show/hide recipe
    {
        if (PI.MenuOpen == false)
        {
            if (RecipePages.Length > 0)
            {
                if (RecipePages[PageNumber].activeSelf)
                {
                    RecipePages[PageNumber].SetActive(false);
                }
                else
                {
                    for (int i = 0; i < RecipePages.Length; i++)
                    {
                        RecipePages[i].SetActive(false);
                    }

                    RecipePages[PageNumber].SetActive(true);
                }
            }
        }
    }
}
