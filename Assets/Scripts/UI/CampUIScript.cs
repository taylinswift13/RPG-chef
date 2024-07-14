using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CampUIScript : MonoBehaviour
{
    public GameObject ChooseFightScreen;
    public GameObject RecipeMissing;
    public GameObject IngredientMissing;
    public TMPro.TMP_Text RecMissingIng;

    private PersistentItemsScript PI;
    private int RoundCounter;

    private void Start()
    {
        PI = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>();
        RoundCounter = PlayerPrefs.GetInt("RoundCounter", 1);
        Time.timeScale = 1;
        PI.MenuOpen = false;
    }

    public void NextScene()
    {
        if (PI.MenuOpen == false)
        {
            if (PI.R1Selected == false || PI.R2Selected == false || PI.R3Selected == false)
            {
                RecipeMissing.SetActive(true);
                PI.MenuOpen = true;
            }
            else if (PI.R1Selected == true && PI.R2Selected == true && PI.R3Selected == true)
            {
                if (PI.R1_I1 != null && PI.R1_I1 != "" && PI.R1_I2 != null && PI.R1_I2 != "" && PI.R1_I3 != null &&
                    PI.R1_I3 != "" && PI.R2_I1 != null && PI.R2_I1 != "" && PI.R2_I2 != null && PI.R2_I2 != "" &&
                    PI.R2_I3 != null && PI.R2_I3 != "" && PI.R3_I1 != null && PI.R3_I1 != "" && PI.R3_I2 != null &&
                    PI.R3_I2 != "" && PI.R3_I3 != null && PI.R3_I3 != "")//all ingredients selected
                {
                    //ChooseFightScreen.SetActive(true);
                    //PI.MenuOpen = true;
                    GoToFight();
                }

                else if (PI.R1_I1 == null || PI.R1_I1 == "" || PI.R1_I2 == null || PI.R1_I2 == "" || PI.R1_I3 == null ||
                    PI.R1_I3 == "" || PI.R2_I1 == null || PI.R2_I1 == "" || PI.R2_I2 == null || PI.R2_I2 == "" || PI.R2_I3 == null
                    || PI.R2_I3 == "" || PI.R3_I1 == null || PI.R3_I1 == "" || PI.R3_I2 == null || PI.R3_I2 == "" ||
                    PI.R3_I3 == null || PI.R3_I3 == "")
                {
                    if (PI.R1_I1 == null || PI.R1_I1 == "" || PI.R1_I2 == null || PI.R1_I2 == "" || PI.R1_I3 == null ||
                    PI.R1_I3 == "")
                    {
                        if (PI.R2_I1 == null || PI.R2_I1 == "" || PI.R2_I2 == null || PI.R2_I2 == "" || PI.R2_I3 == null
                    || PI.R2_I3 == "")
                        {
                            if (PI.R3_I1 == null || PI.R3_I1 == "" || PI.R3_I2 == null || PI.R3_I2 == "" ||
                    PI.R3_I3 == null || PI.R3_I3 == "")
                            {
                                RecMissingIng.text = PI.Recipe1 + ", " + PI.Recipe2 + ", " + PI.Recipe3;
                                IngredientMissing.SetActive(true);
                                PI.MenuOpen = true;
                            }
                        }
                    }

                    else if (PI.R1_I1 != null && PI.R1_I1 != "" && PI.R1_I2 != null && PI.R1_I2 != "" && PI.R1_I3 != null &&
                    PI.R1_I3 != "")
                    {
                        if (PI.R2_I1 == null || PI.R2_I1 == "" || PI.R2_I2 == null || PI.R2_I2 == "" || PI.R2_I3 == null
                    || PI.R2_I3 == "")
                        {
                            if (PI.R3_I1 == null || PI.R3_I1 == "" || PI.R3_I2 == null || PI.R3_I2 == "" ||
                    PI.R3_I3 == null || PI.R3_I3 == "")
                            {
                                RecMissingIng.text = PI.Recipe2 + ", " + PI.Recipe3;
                                IngredientMissing.SetActive(true);
                                PI.MenuOpen = true;
                            }
                        }

                        else if (PI.R2_I1 != null && PI.R2_I1 != "" && PI.R2_I2 != null && PI.R2_I2 != "" &&
                    PI.R2_I3 != null && PI.R2_I3 != "")
                        {
                            if (PI.R3_I1 == null || PI.R3_I1 == "" || PI.R3_I2 == null || PI.R3_I2 == "" ||
                    PI.R3_I3 == null || PI.R3_I3 == "")
                            {
                                RecMissingIng.text = PI.Recipe3;
                                IngredientMissing.SetActive(true);
                                PI.MenuOpen = true;
                            }
                        }
                    }
                }
            }
        }
    }
    public void BackToCamp()
    {
        ChooseFightScreen.SetActive(false);
        RecipeMissing.SetActive(false);
        IngredientMissing.SetActive(false);
        PI.MenuOpen = false;
    }

    public void ToFight1()
    {
        PI.MenuOpen = false;
        SceneManager.LoadScene("Mock up Yin");
    }
    public void ToFight2()
    {
        PI.MenuOpen = false;
        SceneManager.LoadScene("Mock up Yin 2");
    }
    public void ToFight3()
    {
        PI.MenuOpen = false;
        SceneManager.LoadScene("Mock up Yin 3");
    }
    public void GoToFight()
    {
        RoundCounter = PlayerPrefs.GetInt("RoundCounter", 1);

        if (RoundCounter == 1)
        {
            SceneManager.LoadScene("Mock up Yin");
        }
        if (RoundCounter == 2)
        {
            SceneManager.LoadScene("Mock up Yin 2");
        }
        if (RoundCounter == 3)
        {
            SceneManager.LoadScene("Mock up Yin 3");
        }
    }
}
