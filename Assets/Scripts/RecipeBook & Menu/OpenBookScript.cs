using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBookScript : MonoBehaviour
{
    public GameObject RecipeBook;
    public GameObject ClosedBook;

    private void OnMouseDown()
    {
        RecipeBook.SetActive(true);
        ClosedBook.SetActive(false);
        
    }
}
