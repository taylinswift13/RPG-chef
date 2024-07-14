using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeSelectionScript : MonoBehaviour
{
    public Toggle TogSkewer;
    public Toggle TogSalad;
    public Toggle TogSoup;
    public Toggle TogStew;
    public Toggle TogPanini;
    public Toggle TogBruschetta;
    private PersistentItemsScript PI;
    private int RoundCounter;

    public GameObject Skewer;
    public GameObject Bruschetta;

    private void Start()
    {
        PI = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>();
        RoundCounter = PlayerPrefs.GetInt("RoundCounter", 1);

        if (RoundCounter == 3)
        {
            Skewer.SetActive(true);
            Bruschetta.SetActive(true);
        }
        else if (RoundCounter == 2)
        {
            Skewer.SetActive(true);
            Bruschetta.SetActive(false);
        }
        else
        {
            Skewer.SetActive(false);
            Bruschetta.SetActive(false);
        }
    }

    private void Update()
    {
        if (PI.Recipe1 != "Skewer" && PI.Recipe2 != "Skewer" && PI.Recipe3 != "Skewer")
        {
            TogSkewer.SetIsOnWithoutNotify(false);
        }
        if (PI.Recipe1 != "Salad" && PI.Recipe2 != "Salad" && PI.Recipe3 != "Salad")
        {
            TogSalad.SetIsOnWithoutNotify(false);
        }
        if (PI.Recipe1 != "Soup" && PI.Recipe2 != "Soup" && PI.Recipe3 != "Soup")
        {
            TogSoup.SetIsOnWithoutNotify(false);
        }
        if (PI.Recipe1 != "Stew" && PI.Recipe2 != "Stew" && PI.Recipe3 != "Stew")
        {
            TogStew.SetIsOnWithoutNotify(false);
        }
        if (PI.Recipe1 != "Panini" && PI.Recipe2 != "Panini" && PI.Recipe3 != "Panini")
        {
            TogPanini.SetIsOnWithoutNotify(false);
        }
        if (PI.Recipe1 != "Bruschetta" && PI.Recipe2 != "Bruschetta" && PI.Recipe3 != "Bruschetta")
        {
            TogBruschetta.SetIsOnWithoutNotify(false);
        }
    }

    public void TestUnlockRecipes()
    {
        if (PlayerPrefs.GetInt("RoundCounter", 1) == 3)
        {
            PlayerPrefs.SetInt("RoundCounter", 1);
            Skewer.SetActive(false);
            Bruschetta.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("RoundCounter", 1) == 2)
        {
            PlayerPrefs.SetInt("RoundCounter", 3);
            Skewer.SetActive(true);
            Bruschetta.SetActive(true);
        }
        else
        {
            PlayerPrefs.SetInt("RoundCounter", 2);
            Skewer.SetActive(true);
            Bruschetta.SetActive(false);
        }
    }

    public void SelectRecipeSkewer()
    {
        if (PI.MenuOpen == false)
        {
            if (!TogSkewer.isOn) //deactivate recipe
            {
                if (PI.Recipe1 == "Skewer")
                {
                    PI.Recipe1 = null;
                    PI.R1Selected = false;
                }
                else if (PI.Recipe2 == "Skewer")
                {
                    PI.Recipe2 = null;
                    PI.R2Selected = false;
                }
                if (PI.Recipe3 == "Skewer")
                {
                    PI.Recipe3 = null;
                    PI.R3Selected = false;
                }
            }
            else //activate recipe
            {
                if (PI.R1Selected == false)
                {
                    PI.Recipe1 = "Skewer";
                    PI.R1Selected = true;
                }
                else
                {
                    if (PI.R2Selected == false)
                    {
                        PI.Recipe2 = "Skewer";
                        PI.R2Selected = true;
                    }
                    else
                    {
                        if (PI.R3Selected == true)
                        {
                            PI.Recipe1 = PI.Recipe2;
                            PI.Recipe2 = PI.Recipe3;
                            PI.Recipe3 = "Skewer";
                        }
                        else
                        {
                            PI.Recipe3 = "Skewer";
                            PI.R3Selected = true;
                        }
                    }
                }
            }
        }
    }

    public void SelectRecipeSalad()
    {
        if (PI.MenuOpen == false)
        {
            if (!TogSalad.isOn) //deactivate recipe
            {
                if (PI.Recipe1 == "Salad")
                {
                    PI.Recipe1 = null;
                    PI.R1Selected = false;
                }
                else if (PI.Recipe2 == "Salad")
                {
                    PI.Recipe2 = null;
                    PI.R2Selected = false;
                }
                if (PI.Recipe3 == "Salad")
                {
                    PI.Recipe3 = null;
                    PI.R3Selected = false;
                }
            }
            else //activate recipe
            {
                if (PI.R1Selected == false)
                {
                    PI.Recipe1 = "Salad";
                    PI.R1Selected = true;
                }
                else
                {
                    if (PI.R2Selected == false)
                    {
                        PI.Recipe2 = "Salad";
                        PI.R2Selected = true;
                    }
                    else
                    {
                        if (PI.R3Selected == true)
                        {
                            PI.Recipe1 = PI.Recipe2;
                            PI.Recipe2 = PI.Recipe3;
                            PI.Recipe3 = "Salad";
                        }
                        else
                        {
                            PI.Recipe3 = "Salad";
                            PI.R3Selected = true;
                        }
                    }
                }
            }
        }
    }

    public void SelectRecipeSoup()
    {
        if (PI.MenuOpen == false)
        {
            if (!TogSoup.isOn) //deactivate recipe
            {
                if (PI.Recipe1 == "Soup")
                {
                    PI.Recipe1 = null;
                    PI.R1Selected = false;
                }
                else if (PI.Recipe2 == "Soup")
                {
                    PI.Recipe2 = null;
                    PI.R2Selected = false;
                }
                if (PI.Recipe3 == "Soup")
                {
                    PI.Recipe3 = null;
                    PI.R3Selected = false;
                }
            }
            else //activate recipe
            {
                if (PI.R1Selected == false)
                {
                    PI.Recipe1 = "Soup";
                    PI.R1Selected = true;
                }
                else
                {
                    if (PI.R2Selected == false)
                    {
                        PI.Recipe2 = "Soup";
                        PI.R2Selected = true;
                    }
                    else
                    {
                        if (PI.R3Selected == true)
                        {
                            PI.Recipe1 = PI.Recipe2;
                            PI.Recipe2 = PI.Recipe3;
                            PI.Recipe3 = "Soup";
                        }
                        else
                        {
                            PI.Recipe3 = "Soup";
                            PI.R3Selected = true;
                        }
                    }
                }
            }
        }
    }

    public void SelectRecipeStew()
    {
        if (PI.MenuOpen == false)
        {
            if (!TogStew.isOn) //deactivate recipe
            {
                if (PI.Recipe1 == "Stew")
                {
                    PI.Recipe1 = null;
                    PI.R1Selected = false;
                }
                else if (PI.Recipe2 == "Stew")
                {
                    PI.Recipe2 = null;
                    PI.R2Selected = false;
                }
                if (PI.Recipe3 == "Stew")
                {
                    PI.Recipe3 = null;
                    PI.R3Selected = false;
                }
            }
            else //activate recipe
            {
                if (PI.R1Selected == false)
                {
                    PI.Recipe1 = "Stew";
                    PI.R1Selected = true;
                }
                else
                {
                    if (PI.R2Selected == false)
                    {
                        PI.Recipe2 = "Stew";
                        PI.R2Selected = true;
                    }
                    else
                    {
                        if (PI.R3Selected == true)
                        {
                            PI.Recipe1 = PI.Recipe2;
                            PI.Recipe2 = PI.Recipe3;
                            PI.Recipe3 = "Stew";
                        }
                        else
                        {
                            PI.Recipe3 = "Stew";
                            PI.R3Selected = true;
                        }
                    }
                }
            }
        }
    }

    public void SelectRecipePanini()
    {
        if (PI.MenuOpen == false)
        {
            if (!TogPanini.isOn) //deactivate recipe
            {
                if (PI.Recipe1 == "Panini")
                {
                    PI.Recipe1 = null;
                    PI.R1Selected = false;
                }
                else if (PI.Recipe2 == "Panini")
                {
                    PI.Recipe2 = null;
                    PI.R2Selected = false;
                }
                if (PI.Recipe3 == "Panini")
                {
                    PI.Recipe3 = null;
                    PI.R3Selected = false;
                }
            }
            else //activate recipe
            {
                if (PI.R1Selected == false)
                {
                    PI.Recipe1 = "Panini";
                    PI.R1Selected = true;
                }
                else
                {
                    if (PI.R2Selected == false)
                    {
                        PI.Recipe2 = "Panini";
                        PI.R2Selected = true;
                    }
                    else
                    {
                        if (PI.R3Selected == true)
                        {
                            PI.Recipe1 = PI.Recipe2;
                            PI.Recipe2 = PI.Recipe3;
                            PI.Recipe3 = "Panini";
                        }
                        else
                        {
                            PI.Recipe3 = "Panini";
                            PI.R3Selected = true;
                        }
                    }
                }
            }
        }
    }

    public void SelectRecipeBruschetta()
    {
        if (PI.MenuOpen == false)
        {
            if (!TogBruschetta.isOn) //deactivate recipe
            {
                if (PI.Recipe1 == "Bruschetta")
                {
                    PI.Recipe1 = null;
                    PI.R1Selected = false;
                }
                else if (PI.Recipe2 == "Bruschetta")
                {
                    PI.Recipe2 = null;
                    PI.R2Selected = false;
                }
                if (PI.Recipe3 == "Bruschetta")
                {
                    PI.Recipe3 = null;
                    PI.R3Selected = false;
                }
            }
            else //activate recipe
            {
                if (PI.R1Selected == false)
                {
                    PI.Recipe1 = "Bruschetta";
                    PI.R1Selected = true;
                }
                else
                {
                    if (PI.R2Selected == false)
                    {
                        PI.Recipe2 = "Bruschetta";
                        PI.R2Selected = true;
                    }
                    else
                    {
                        if (PI.R3Selected == true)
                        {
                            PI.Recipe1 = PI.Recipe2;
                            PI.Recipe2 = PI.Recipe3;
                            PI.Recipe3 = "Bruschetta";
                        }
                        else
                        {
                            PI.Recipe3 = "Bruschetta";
                            PI.R3Selected = true;
                        }
                    }
                }
            }
        }
    }
}
