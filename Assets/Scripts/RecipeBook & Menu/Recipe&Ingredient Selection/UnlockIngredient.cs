using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockIngredient : MonoBehaviour
{
    public GameObject Unlock;

    public bool DeathCap;
    public bool Beef;
    public bool Loaf;
    public bool Carrot;

    private int RoundCounter;

    private void OnEnable()
    {
        RoundCounter = PlayerPrefs.GetInt("RoundCounter", 1);

        if (RoundCounter == 1)
        {
            if (DeathCap == true)
            {
                Unlock.SetActive(false);
            }
            if (Beef == true)
            {
                Unlock.SetActive(false);
            }
            if (Loaf == true)
            {
                Unlock.SetActive(false);
            }
            if (Carrot == true)
            {
                Unlock.SetActive(false);
            }
        }
        else if (RoundCounter == 2)
        {
            if (DeathCap == true)
            {
                Unlock.SetActive(true);
            }
            if (Beef == true)
            {
                Unlock.SetActive(true);
            }
            if (Loaf == true)
            {
                Unlock.SetActive(false);
            }
            if (Carrot == true)
            {
                Unlock.SetActive(false);
            }
        }
        else
        {
            if (DeathCap == true)
            {
                Unlock.SetActive(true);
            }
            if (Beef == true)
            {
                Unlock.SetActive(true);
            }
            if (Loaf == true)
            {
                Unlock.SetActive(true);
            }
            if (Carrot == true)
            {
                Unlock.SetActive(true);
            }
        }
    }
}
