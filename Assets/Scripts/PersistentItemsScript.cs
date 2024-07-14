using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistentItemsScript : MonoBehaviour
{
    //Try to use arrays for recipes & ingredients
    public string[] AvailableRecipes;
    public string[] AvailableIngredients;

    public bool R1Selected = false;
    public string Recipe1;
    public string R1_ThrowType;
    public string R1_I1;
    public string R1_I2;
    public string R1_I3;

    public bool R2Selected = false;
    public string Recipe2;
    public string R2_ThrowType;
    public string R2_I1;
    public string R2_I2;
    public string R2_I3;

    public bool R3Selected = false;
    public string Recipe3;
    public string R3_ThrowType;
    public string R3_I1;
    public string R3_I2;
    public string R3_I3;

    public int RoundCounter = 1;
    public bool MenuOpen = false;

    public string Panini_1;
    public string Panini_2;
    public string Panini_3;

    public string Salad_1;
    public string Salad_2;
    public string Salad_3;

    public string Soup_1;
    public string Soup_2;
    public string Soup_3;

    public string Stew_1;
    public string Stew_2;
    public string Stew_3;

    public string Skewer_1;
    public string Skewer_2;
    public string Skewer_3;

    public string Bruschetta_1;
    public string Bruschetta_2;
    public string Bruschetta_3;

    void Start()
    {
        R1_I1 = null;
        R1_I2 = null;
        R1_I3 = null;
        R2_I1 = null;
        R2_I2 = null;
        R2_I3 = null;
        R3_I1 = null;
        R3_I2 = null;
        R3_I3 = null;

        RoundCounter = PlayerPrefs.GetInt("RoundCounter", 1);
        MenuOpen = false;
    }

    private void Awake()
    {
        Scene CurrentScene = SceneManager.GetActiveScene();

        if (CurrentScene.name != "1_StartScene" || CurrentScene.name != "4_EndScene")
            DontDestroyOnLoad(this.gameObject);

        if (CurrentScene.name == "Mock Up Yin")
        {
            PlayerPrefs.SetInt("RoundCounter", 1);
        }
        if (CurrentScene.name == "Mock Up Yin 2")
        {
            PlayerPrefs.SetInt("RoundCounter", 2);
        }
        if (CurrentScene.name == "Mock Up Yin 3")
        {
            PlayerPrefs.SetInt("RoundCounter", 3);
        }
    }

    private void FixedUpdate()
    {
        RoundCounter = PlayerPrefs.GetInt("RoundCounter", 1);

        //Sorting Recipes
        if (Recipe2 == null && Recipe3 != null)
        {
            Recipe2 = Recipe3;
            R2_ThrowType = R3_ThrowType;
            R2_I1 = R3_I1;
            R2_I2 = R3_I2;
            R2_I3 = R3_I3;
            Recipe3 = null;
            R3_I1 = null;
            R3_I2 = null;
            R3_I3 = null;
            R3_ThrowType = null;
        }
        if (Recipe1 == null && Recipe2 != null)
        {
            Recipe1 = Recipe2;
            R1_ThrowType = R2_ThrowType;
            R1_I1 = R2_I1;
            R1_I2 = R2_I2;
            R1_I3 = R2_I3;
            Recipe2 = null;
        }

        //Make sure none of the bools are true/false when they're not supposed to be
        if (Recipe1 == null)
        {
            R1Selected = false;

            R1_I1 = null;
            R1_I2 = null;
            R1_I3 = null;
            R1_ThrowType = null;
        }
        else if (Recipe1 == AvailableRecipes[0] || Recipe1 == AvailableRecipes[1] || Recipe1 == AvailableRecipes[2] 
            || Recipe1 == AvailableRecipes[3] || Recipe1 == AvailableRecipes[4] || Recipe1 == AvailableRecipes[5])
            R1Selected = true;

        if (Recipe2 == null)
        {
            R2Selected = false;

            R2_I1 = null;
            R2_I2 = null;
            R2_I3 = null;
            R2_ThrowType = null;
        }
        else if (Recipe2 == AvailableRecipes[0] || Recipe2 == AvailableRecipes[1] || Recipe2 == AvailableRecipes[2]
             || Recipe2 == AvailableRecipes[3] || Recipe2 == AvailableRecipes[4] || Recipe2 == AvailableRecipes[5])
            R2Selected = true;

        if (Recipe3 == null)
        {
            R3Selected = false;

            R3_I1 = null;
            R3_I2 = null;
            R3_I3 = null;
            R3_ThrowType = null;
        }
        else if (Recipe3 == AvailableRecipes[0] || Recipe3 == AvailableRecipes[1] || Recipe3 == AvailableRecipes[2]
             || Recipe3 == AvailableRecipes[3] || Recipe3 == AvailableRecipes[4] || Recipe3 == AvailableRecipes[5])
            R3Selected = true;

        if (R1Selected == true)
        {
            if (Recipe1 == "Panini")
            {
                R1_I1 = Panini_1;
                R1_I2 = Panini_2;
                R1_I3 = Panini_3;
            }
            else if (Recipe1 == "Salad")
            {
                R1_I1 = Salad_1;
                R1_I2 = Salad_2;
                R1_I3 = Salad_3;
            }
            else
            {
                if (Recipe1 == "Soup")
                {
                    R1_I1 = Soup_1;
                    R1_I2 = Soup_2;
                    R1_I3 = Soup_3;
                }
                else if (Recipe1 == "Stew")
                {
                    R1_I1 = Stew_1;
                    R1_I2 = Stew_2;
                    R1_I3 = Stew_3;
                }
                else
                {
                    if (Recipe1 == "Skewer")
                    {
                        R1_I1 = Skewer_1;
                        R1_I2 = Skewer_2;
                        R1_I3 = Skewer_3;
                    }
                    else if (Recipe1 == "Bruschetta")
                    {
                        R1_I1 = Bruschetta_1;
                        R1_I2 = Bruschetta_2;
                        R1_I3 = Bruschetta_3;
                    }
                }
            }
        }

        if (R2Selected == true)
        {
            if (Recipe2 == "Panini")
            {
                R2_I1 = Panini_1;
                R2_I2 = Panini_2;
                R2_I3 = Panini_3;
            }
            else if (Recipe2 == "Salad")
            {
                R2_I1 = Salad_1;
                R2_I2 = Salad_2;
                R2_I3 = Salad_3;
            }
            else
            {
                if (Recipe2 == "Soup")
                {
                    R2_I1 = Soup_1;
                    R2_I2 = Soup_2;
                    R2_I3 = Soup_3;
                }
                else if (Recipe2 == "Stew")
                {
                    R2_I1 = Stew_1;
                    R2_I2 = Stew_2;
                    R2_I3 = Stew_3;
                }
                else
                {
                    if (Recipe2 == "Skewer")
                    {
                        R2_I1 = Skewer_1;
                        R2_I2 = Skewer_2;
                        R2_I3 = Skewer_3;
                    }
                    else if (Recipe2 == "Bruschetta")
                    {
                        R2_I1 = Bruschetta_1;
                        R2_I2 = Bruschetta_2;
                        R2_I3 = Bruschetta_3;
                    }
                }
            }
        }

        if (R3Selected == true)
        {
            if (Recipe3 == "Panini")
            {
                R3_I1 = Panini_1;
                R3_I2 = Panini_2;
                R3_I3 = Panini_3;
            }
            else if (Recipe3 == "Salad")
            {
                R3_I1 = Salad_1;
                R3_I2 = Salad_2;
                R3_I3 = Salad_3;
            }
            else
            {
                if (Recipe3 == "Soup")
                {
                    R3_I1 = Soup_1;
                    R3_I2 = Soup_2;
                    R3_I3 = Soup_3;
                }
                else if (Recipe3 == "Stew")
                {
                    R3_I1 = Stew_1;
                    R3_I2 = Stew_2;
                    R3_I3 = Stew_3;
                }
                else
                {
                    if (Recipe3 == "Skewer")
                    {
                        R3_I1 = Skewer_1;
                        R3_I2 = Skewer_2;
                        R3_I3 = Skewer_3;
                    }
                    else if (Recipe3 == "Bruschetta")
                    {
                        R3_I1 = Bruschetta_1;
                        R3_I2 = Bruschetta_2;
                        R3_I3 = Bruschetta_3;
                    }
                }
            }
        }
    }
}
