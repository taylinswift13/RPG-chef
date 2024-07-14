using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialsScript : MonoBehaviour
{
    public GameObject Window_Tutorials;

    public GameObject Window_Ingredients;
    public GameObject Window_IngDetails;
    public GameObject Window_MouseControls;
    public GameObject Window_PreparingBattle;
    public GameObject Window_StatusMechanic;
    public GameObject Window_Stats;
    public GameObject Window_StatusEffects;

    private PersistentItemsScript PI;

    void Start()
    {
        PI = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>();
    }

    public void ReturnTutorials()
    {
        Window_IngDetails.SetActive(false);
        Window_Ingredients.SetActive(false);
        Window_MouseControls.SetActive(false);
        Window_PreparingBattle.SetActive(false);
        Window_Stats.SetActive(false);
        Window_StatusEffects.SetActive(false);
        Window_StatusMechanic.SetActive(false);
        Window_Tutorials.SetActive(true);
    }

    public void IngWindow()
    {
        Window_Tutorials.SetActive(false);
        Window_Ingredients.SetActive(true);
    }

    public void IngDetails()
    {
        Window_IngDetails.SetActive(true);
        Window_Ingredients.SetActive(false);
    }

    public void BattlePrep()
    {
        Window_PreparingBattle.SetActive(true);
        Window_Tutorials.SetActive(false);
    }

    public void Stats()
    {
        Window_Stats.SetActive(true);
        Window_Tutorials.SetActive(false);
    }

    public void StatusMechanic()
    {
        Window_StatusMechanic.SetActive(true);
        Window_Tutorials.SetActive(false);
    }

    public void StatusEffects()
    {
        Window_StatusEffects.SetActive(true);
        Window_Tutorials.SetActive(false);
    }

    public void MouseThrowing()
    {
        Window_Tutorials.SetActive(false);
        Window_MouseControls.SetActive(true);
    }
}
