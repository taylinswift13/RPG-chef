using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuText : MonoBehaviour
{
    public MenuText_Modif PWT;

    public TMPro.TMP_Text Recipe1Text;
    public TMPro.TMP_Text R1I1Text;
    public TMPro.TMP_Text R1I2Text;
    public TMPro.TMP_Text R1I3Text;

    public TMPro.TMP_Text Recipe2Text;
    public TMPro.TMP_Text R2I1Text;
    public TMPro.TMP_Text R2I2Text;
    public TMPro.TMP_Text R2I3Text;

    public TMPro.TMP_Text Recipe3Text;
    public TMPro.TMP_Text R3I1Text;
    public TMPro.TMP_Text R3I2Text;
    public TMPro.TMP_Text R3I3Text;

    private PersistentItemsScript PI;

    private void Start()
    {
        PI = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>();

        Recipe1Text.text = PWT.NothingSelected_Text;
        Recipe2Text.text = PWT.NothingSelected_Text;
        Recipe3Text.text = PWT.NothingSelected_Text;

        R1I1Text.text = PWT.NothingSelected_Text;
        R1I2Text.text = PWT.NothingSelected_Text;
        R1I3Text.text = PWT.NothingSelected_Text;

        R2I1Text.text = PWT.NothingSelected_Text;
        R2I2Text.text = PWT.NothingSelected_Text;
        R2I3Text.text = PWT.NothingSelected_Text;

        R3I1Text.text = PWT.NothingSelected_Text;
        R3I2Text.text = PWT.NothingSelected_Text;
        R3I3Text.text = PWT.NothingSelected_Text;
    }
    void FixedUpdate()
    {
        //Recipe1 Texts
        if (PI.R1Selected == false)
            Recipe1Text.text = PWT.NothingSelected_Text;
        else if (PI.R1Selected == true)
        {
            if (PI.Recipe1 == "Skewer")
            {
                Recipe1Text.text = PWT.RecipeSkewer_Text;
            }
            if (PI.Recipe1 == "Salad")
            {
                Recipe1Text.text = PWT.RecipeSalad_Text;
            }
            if (PI.Recipe1 == "Soup")
            {
                Recipe1Text.text = PWT.RecipeSoup_Text;
            }
            if (PI.Recipe1 == "Stew")
            {
                Recipe1Text.text = PWT.RecipeStew_Text;
            }
            if (PI.Recipe1 == "Panini")
            {
                Recipe1Text.text = PWT.RecipePanini_Text;
            }
            if (PI.Recipe1 == "Bruschetta")
            {
                Recipe1Text.text = PWT.RecipeBruschetta_Text;
            }
        }

        //R1 Ingredients
        if (PI.R1Selected == true)
        {
            if (PI.R1_I1 == "" || PI.R1_I1 == null)
            {
                R1I1Text.text = PWT.NothingSelected_Text;
            }
            if (PI.R1_I1 == "Toast") //Base
            {
                R1I1Text.text = PWT.Toast_Text;
            }
            else if (PI.R1_I1 == "Loaf")
            {
                R1I1Text.text = PWT.Loaf_Text;
            }
            else
            {
                if (PI.R1_I1 == "Tomato")
                {
                    R1I1Text.text = PWT.Tomato_Text;
                }
                else if (PI.R1_I1 == "Chili")
                {
                    R1I1Text.text = PWT.Chili_Text;
                }
                else
                {
                    if (PI.R1_I1 == "Beef")
                    {
                        R1I1Text.text = PWT.Beef_Text;
                    }
                    else if (PI.R1_I1 == "Ham")
                    {
                        R1I1Text.text = PWT.Ham_Text;
                    }
                    else
                    {
                        if (PI.R1_I1 == "Champignon")
                        {
                            R1I1Text.text = PWT.Champignon_Text;
                        }
                        else if (PI.R1_I1 == "DeathCap")
                        {
                            R1I1Text.text = PWT.DeathCap_Text;
                        }
                        else
                        {
                            if (PI.R1_I1 == "Onion")
                            {
                                R1I1Text.text = PWT.Onion_Text;
                            }
                            else if (PI.R1_I1 == "Carrot")
                            {
                                R1I1Text.text = PWT.Carrot_Text;
                            }
                        }
                    }
                }
            }

            if (PI.R1_I2 == "" || PI.R1_I2 == null)
            {
                R1I2Text.text = PWT.NothingSelected_Text;
            }
            if (PI.R1_I2 == "Toast") //Base
            {
                R1I2Text.text = PWT.Toast_Text;
            }
            else if (PI.R1_I2 == "Loaf")
            {
                R1I2Text.text = PWT.Loaf_Text;
            }
            else
            {
                if (PI.R1_I2 == "Tomato")
                {
                    R1I2Text.text = PWT.Tomato_Text;
                }
                else if (PI.R1_I2 == "Chili")
                {
                    R1I2Text.text = PWT.Chili_Text;
                }
                else
                {
                    if (PI.R1_I2 == "Beef")
                    {
                        R1I2Text.text = PWT.Beef_Text;
                    }
                    else if (PI.R1_I2 == "Ham")
                    {
                        R1I2Text.text = PWT.Ham_Text;
                    }
                    else
                    {
                        if (PI.R1_I2 == "Champignon")
                        {
                            R1I2Text.text = PWT.Champignon_Text;
                        }
                        else if (PI.R1_I2 == "DeathCap")
                        {
                            R1I2Text.text = PWT.DeathCap_Text;
                        }
                        else
                        {
                            if (PI.R1_I2 == "Onion")
                            {
                                R1I2Text.text = PWT.Onion_Text;
                            }
                            else if (PI.R1_I2 == "Carrot")
                            {
                                R1I2Text.text = PWT.Carrot_Text;
                            }
                        }
                    }
                }
            }

            if (PI.R1_I3 == "" || PI.R1_I3 == null)
            {
                R1I3Text.text = PWT.NothingSelected_Text;
            }
            if (PI.R1_I3 == "Toast") //Base
            {
                R1I3Text.text = PWT.Toast_Text;
            }
            else if (PI.R1_I3 == "Loaf")
            {
                R1I3Text.text = PWT.Loaf_Text;
            }
            else
            {
                if (PI.R1_I3 == "Tomato")
                {
                    R1I3Text.text = PWT.Tomato_Text;
                }
                else if (PI.R1_I3 == "Chili")
                {
                    R1I3Text.text = PWT.Chili_Text;
                }
                else
                {
                    if (PI.R1_I3 == "Beef")
                    {
                        R1I3Text.text = PWT.Beef_Text;
                    }
                    else if (PI.R1_I3 == "Ham")
                    {
                        R1I3Text.text = PWT.Ham_Text;
                    }
                    else
                    {
                        if (PI.R1_I3 == "Champignon")
                        {
                            R1I3Text.text = PWT.Champignon_Text;
                        }
                        else if (PI.R1_I3 == "DeathCap")
                        {
                            R1I3Text.text = PWT.DeathCap_Text;
                        }
                        else
                        {
                            if (PI.R1_I3 == "Onion")
                            {
                                R1I3Text.text = PWT.Onion_Text;
                            }
                            else if (PI.R1_I3 == "Carrot")
                            {
                                R1I3Text.text = PWT.Carrot_Text;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            R1I1Text.text = PWT.NothingSelected_Text;
            R1I2Text.text = PWT.NothingSelected_Text;
            R1I3Text.text = PWT.NothingSelected_Text;
        }

        //Recipe2 Texts
        if (PI.R2Selected == false)
            Recipe2Text.text = PWT.NothingSelected_Text;
        else if (PI.R2Selected == true)
        {
            if (PI.Recipe2 == "Skewer")
            {
                Recipe2Text.text = PWT.RecipeSkewer_Text;
            }
            if (PI.Recipe2 == "Salad")
            {
                Recipe2Text.text = PWT.RecipeSalad_Text;
            }
            if (PI.Recipe2 == "Soup")
            {
                Recipe2Text.text = PWT.RecipeSoup_Text;
            }
            if (PI.Recipe2 == "Stew")
            {
                Recipe2Text.text = PWT.RecipeStew_Text;
            }
            if (PI.Recipe2 == "Panini")
            {
                Recipe2Text.text = PWT.RecipePanini_Text;
            }
            if (PI.Recipe2 == "Bruschetta")
            {
                Recipe2Text.text = PWT.RecipeBruschetta_Text;
            }
        }

        //R2 Ingredients
        if (PI.R2Selected == true)
        {
            if (PI.R2_I1 == "" || PI.R2_I1 == null)
            {
                R2I1Text.text = PWT.NothingSelected_Text;
            }
            if (PI.R2_I1 == "Toast") //Base
            {
                R2I1Text.text = PWT.Toast_Text;
            }
            else if (PI.R2_I1 == "Loaf")
            {
                R2I1Text.text = PWT.Loaf_Text;
            }
            else
            {
                if (PI.R2_I1 == "Tomato")
                {
                    R2I1Text.text = PWT.Tomato_Text;
                }
                else if (PI.R2_I1 == "Chili")
                {
                    R2I1Text.text = PWT.Chili_Text;
                }
                else
                {
                    if (PI.R2_I1 == "Beef")
                    {
                        R2I1Text.text = PWT.Beef_Text;
                    }
                    else if (PI.R2_I1 == "Ham")
                    {
                        R2I1Text.text = PWT.Ham_Text;
                    }
                    else
                    {
                        if (PI.R2_I1 == "Champignon")
                        {
                            R2I1Text.text = PWT.Champignon_Text;
                        }
                        else if (PI.R2_I1 == "DeathCap")
                        {
                            R2I1Text.text = PWT.DeathCap_Text;
                        }
                        else
                        {
                            if (PI.R2_I1 == "Onion")
                            {
                                R2I1Text.text = PWT.Onion_Text;
                            }
                            else if (PI.R2_I1 == "Carrot")
                            {
                                R2I1Text.text = PWT.Carrot_Text;
                            }
                        }
                    }
                }
            }

            if (PI.R2_I2 == "" || PI.R2_I2 == null)
            {
                R2I2Text.text = PWT.NothingSelected_Text;
            }
            if (PI.R2_I2 == "Toast") //Base
            {
                R2I2Text.text = PWT.Toast_Text;
            }
            else if (PI.R2_I2 == "Loaf")
            {
                R2I2Text.text = PWT.Loaf_Text;
            }
            else
            {
                if (PI.R2_I2 == "Tomato")
                {
                    R2I2Text.text = PWT.Tomato_Text;
                }
                else if (PI.R2_I2 == "Chili")
                {
                    R2I2Text.text = PWT.Chili_Text;
                }
                else
                {
                    if (PI.R2_I2 == "Beef")
                    {
                        R2I2Text.text = PWT.Beef_Text;
                    }
                    else if (PI.R2_I2 == "Ham")
                    {
                        R2I2Text.text = PWT.Ham_Text;
                    }
                    else
                    {
                        if (PI.R2_I2 == "Champignon")
                        {
                            R2I2Text.text = PWT.Champignon_Text;
                        }
                        else if (PI.R2_I2 == "DeathCap")
                        {
                            R2I2Text.text = PWT.DeathCap_Text;
                        }
                        else
                        {
                            if (PI.R2_I2 == "Onion")
                            {
                                R2I2Text.text = PWT.Onion_Text;
                            }
                            else if (PI.R2_I2 == "Carrot")
                            {
                                R2I2Text.text = PWT.Carrot_Text;
                            }
                        }
                    }
                }
            }

            if (PI.R2_I3 == "" || PI.R2_I3 == null)
            {
                R2I3Text.text = PWT.NothingSelected_Text;
            }
            if (PI.R2_I3 == "Toast") //Base
            {
                R2I3Text.text = PWT.Toast_Text;
            }
            else if (PI.R2_I3 == "Loaf")
            {
                R2I3Text.text = PWT.Loaf_Text;
            }
            else
            {
                if (PI.R2_I3 == "Tomato")
                {
                    R2I3Text.text = PWT.Tomato_Text;
                }
                else if (PI.R2_I3 == "Chili")
                {
                    R2I3Text.text = PWT.Chili_Text;
                }
                else
                {
                    if (PI.R2_I3 == "Beef")
                    {
                        R2I3Text.text = PWT.Beef_Text;
                    }
                    else if (PI.R2_I3 == "Ham")
                    {
                        R2I3Text.text = PWT.Ham_Text;
                    }
                    else
                    {
                        if (PI.R2_I3 == "Champignon")
                        {
                            R2I3Text.text = PWT.Champignon_Text;
                        }
                        else if (PI.R2_I3 == "DeathCap")
                        {
                            R2I3Text.text = PWT.DeathCap_Text;
                        }
                        else
                        {
                            if (PI.R2_I3 == "Onion")
                            {
                                R2I3Text.text = PWT.Onion_Text;
                            }
                            else if (PI.R2_I3 == "Carrot")
                            {
                                R2I3Text.text = PWT.Carrot_Text;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            R2I1Text.text = PWT.NothingSelected_Text;
            R2I2Text.text = PWT.NothingSelected_Text;
            R2I3Text.text = PWT.NothingSelected_Text;
        }

        //Recipe3 Texts
        if (PI.R3Selected == false)
            Recipe3Text.text = PWT.NothingSelected_Text;
        else if (PI.R3Selected == true)
        {
            if (PI.Recipe3 == "Skewer")
            {
                Recipe3Text.text = PWT.RecipeSkewer_Text;
            }
            if (PI.Recipe3 == "Salad")
            {
                Recipe3Text.text = PWT.RecipeSalad_Text;
            }
            if (PI.Recipe3 == "Soup")
            {
                Recipe3Text.text = PWT.RecipeSoup_Text;
            }
            if (PI.Recipe3 == "Stew")
            {
                Recipe3Text.text = PWT.RecipeStew_Text;
            }
            if (PI.Recipe3 == "Panini")
            {
                Recipe3Text.text = PWT.RecipePanini_Text;
            }
            if (PI.Recipe3 == "Bruschetta")
            {
                Recipe3Text.text = PWT.RecipeBruschetta_Text;
            }
        }

        //R3 Ingredients
        if (PI.R3Selected == true)
        {
            if (PI.R3_I1 == "" || PI.R3_I1 == null)
            {
                R3I1Text.text = PWT.NothingSelected_Text;
            }
            if (PI.R3_I1 == "Toast") //Base
            {
                R3I1Text.text = PWT.Toast_Text;
            }
            else if (PI.R3_I1 == "Loaf")
            {
                R3I1Text.text = PWT.Loaf_Text;
            }
            else
            {
                if (PI.R3_I1 == "Tomato")
                {
                    R3I1Text.text = PWT.Tomato_Text;
                }
                else if (PI.R3_I1 == "Chili")
                {
                    R3I1Text.text = PWT.Chili_Text;
                }
                else
                {
                    if (PI.R3_I1 == "Beef")
                    {
                        R3I1Text.text = PWT.Beef_Text;
                    }
                    else if (PI.R3_I1 == "Ham")
                    {
                        R3I1Text.text = PWT.Ham_Text;
                    }
                    else
                    {
                        if (PI.R3_I1 == "Champignon")
                        {
                            R3I1Text.text = PWT.Champignon_Text;
                        }
                        else if (PI.R3_I1 == "DeathCap")
                        {
                            R3I1Text.text = PWT.DeathCap_Text;
                        }
                        else
                        {
                            if (PI.R3_I1 == "Onion")
                            {
                                R3I1Text.text = PWT.Onion_Text;
                            }
                            else if (PI.R3_I1 == "Carrot")
                            {
                                R3I1Text.text = PWT.Carrot_Text;
                            }
                        }
                    }
                }
            }

            if (PI.R3_I2 == "" || PI.R3_I2 == null)
            {
                R3I2Text.text = PWT.NothingSelected_Text;
            }
            if (PI.R3_I2 == "Toast") //Base
            {
                R3I2Text.text = PWT.Toast_Text;
            }
            else if (PI.R3_I2 == "Loaf")
            {
                R3I2Text.text = PWT.Loaf_Text;
            }
            else
            {
                if (PI.R3_I2 == "Tomato")
                {
                    R3I2Text.text = PWT.Tomato_Text;
                }
                else if (PI.R3_I2 == "Chili")
                {
                    R3I2Text.text = PWT.Chili_Text;
                }
                else
                {
                    if (PI.R3_I2 == "Beef")
                    {
                        R3I2Text.text = PWT.Beef_Text;
                    }
                    else if (PI.R3_I2 == "Ham")
                    {
                        R3I2Text.text = PWT.Ham_Text;
                    }
                    else
                    {
                        if (PI.R3_I2 == "Champignon")
                        {
                            R3I2Text.text = PWT.Champignon_Text;
                        }
                        else if (PI.R3_I2 == "DeathCap")
                        {
                            R3I2Text.text = PWT.DeathCap_Text;
                        }
                        else
                        {
                            if (PI.R3_I2 == "Onion")
                            {
                                R3I2Text.text = PWT.Onion_Text;
                            }
                            else if (PI.R3_I2 == "Carrot")
                            {
                                R3I2Text.text = PWT.Carrot_Text;
                            }
                        }
                    }
                }
            }

            if (PI.R3_I3 == "" || PI.R3_I3 == null)
            {
                R3I3Text.text = PWT.NothingSelected_Text;
            }
            if (PI.R3_I3 == "Toast") //Base
            {
                R3I3Text.text = PWT.Toast_Text;
            }
            else if (PI.R3_I3 == "Loaf")
            {
                R3I3Text.text = PWT.Loaf_Text;
            }
            else
            {
                if (PI.R3_I3 == "Tomato")
                {
                    R3I3Text.text = PWT.Tomato_Text;
                }
                else if (PI.R3_I3 == "Chili")
                {
                    R3I3Text.text = PWT.Chili_Text;
                }
                else
                {
                    if (PI.R3_I3 == "Beef")
                    {
                        R3I3Text.text = PWT.Beef_Text;
                    }
                    else if (PI.R3_I3 == "Ham")
                    {
                        R3I3Text.text = PWT.Ham_Text;
                    }
                    else
                    {
                        if (PI.R3_I3 == "Champignon")
                        {
                            R3I3Text.text = PWT.Champignon_Text;
                        }
                        else if (PI.R3_I3 == "DeathCap")
                        {
                            R3I3Text.text = PWT.DeathCap_Text;
                        }
                        else
                        {
                            if (PI.R3_I3 == "Onion")
                            {
                                R3I3Text.text = PWT.Onion_Text;
                            }
                            else if (PI.R3_I3 == "Carrot")
                            {
                                R3I3Text.text = PWT.Carrot_Text;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            R3I1Text.text = PWT.NothingSelected_Text;
            R3I2Text.text = PWT.NothingSelected_Text;
            R3I3Text.text = PWT.NothingSelected_Text;
        }
    }

    void Update()
    {
        ////Recipe1 Texts
        //if (PI.R1Selected == false)
        //    Recipe1Text.text = PWT.NothingSelected_Text;
        //else if (PI.R1Selected == true)
        //{
        //    if (PI.Recipe1 == "Skewer")
        //    {
        //        Recipe1Text.text = PWT.RecipeSkewer_Text;
        //    }
        //    if (PI.Recipe1 == "Salad")
        //    {
        //        Recipe1Text.text = PWT.RecipeSalad_Text;
        //    }
        //    if (PI.Recipe1 == "Soup")
        //    {
        //        Recipe1Text.text = PWT.RecipeSoup_Text;
        //    }
        //    if (PI.Recipe1 == "Stew")
        //    {
        //        Recipe1Text.text = PWT.RecipeStew_Text;
        //    }
        //    if (PI.Recipe1 == "Panini")
        //    {
        //        Recipe1Text.text = PWT.RecipePanini_Text;
        //    }
        //    if (PI.Recipe1 == "Bruschetta")
        //    {
        //        Recipe1Text.text = PWT.RecipeBruschetta_Text;
        //    }
        //}

        ////R1 Ingredients
        //if (PI.R1Selected == true)
        //{
        //    if (PI.R1_I1 == "Toast") //Base
        //    {
        //        R1I1Text.text = PWT.Toast_Text;
        //    }
        //    else if (PI.R1_I1 == "Loaf")
        //    {
        //        R1I1Text.text = PWT.Loaf_Text;
        //    }
        //    else
        //    {
        //        if (PI.R1_I1 == "Tomato")
        //        {
        //            R1I1Text.text = PWT.Tomato_Text;
        //        }
        //        else if (PI.R1_I1 == "Chili")
        //        {
        //            R1I1Text.text = PWT.Chili_Text;
        //        }
        //        else
        //        {
        //            if (PI.R1_I1 == "Beef")
        //            {
        //                R1I1Text.text = PWT.Beef_Text;
        //            }
        //            else if (PI.R1_I1 == "Ham")
        //            {
        //                R1I1Text.text = PWT.Ham_Text;
        //            }
        //            else
        //            {
        //                if (PI.R1_I1 == "Champignon")
        //                {
        //                    R1I1Text.text = PWT.Champignon_Text;
        //                }
        //                else if (PI.R1_I1 == "DeathCap")
        //                {
        //                    R1I1Text.text = PWT.DeathCap_Text;
        //                }
        //                else
        //                {
        //                    if (PI.R1_I1 == "Onion")
        //                    {
        //                        R1I1Text.text = PWT.Onion_Text;
        //                    }
        //                    else if (PI.R1_I1 == "Carrot")
        //                    {
        //                        R1I1Text.text = PWT.Carrot_Text;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (PI.R1_I2 == "Toast") //Base
        //    {
        //        R1I2Text.text = PWT.Toast_Text;
        //    }
        //    else if (PI.R1_I2 == "Loaf")
        //    {
        //        R1I2Text.text = PWT.Loaf_Text;
        //    }
        //    else
        //    {
        //        if (PI.R1_I2 == "Tomato")
        //        {
        //            R1I2Text.text = PWT.Tomato_Text;
        //        }
        //        else if (PI.R1_I2 == "Chili")
        //        {
        //            R1I2Text.text = PWT.Chili_Text;
        //        }
        //        else
        //        {
        //            if (PI.R1_I2 == "Beef")
        //            {
        //                R1I2Text.text = PWT.Beef_Text;
        //            }
        //            else if (PI.R1_I2 == "Ham")
        //            {
        //                R1I2Text.text = PWT.Ham_Text;
        //            }
        //            else
        //            {
        //                if (PI.R1_I2 == "Champignon")
        //                {
        //                    R1I2Text.text = PWT.Champignon_Text;
        //                }
        //                else if (PI.R1_I2 == "DeathCap")
        //                {
        //                    R1I2Text.text = PWT.DeathCap_Text;
        //                }
        //                else
        //                {
        //                    if (PI.R1_I2 == "Onion")
        //                    {
        //                        R1I2Text.text = PWT.Onion_Text;
        //                    }
        //                    else if (PI.R1_I2 == "Carrot")
        //                    {
        //                        R1I2Text.text = PWT.Carrot_Text;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (PI.R1_I3 == "Toast") //Base
        //    {
        //        R1I3Text.text = PWT.Toast_Text;
        //    }
        //    else if (PI.R1_I3 == "Loaf")
        //    {
        //        R1I3Text.text = PWT.Loaf_Text;
        //    }
        //    else
        //    {
        //        if (PI.R1_I3 == "Tomato")
        //        {
        //            R1I3Text.text = PWT.Tomato_Text;
        //        }
        //        else if (PI.R1_I3 == "Chili")
        //        {
        //            R1I3Text.text = PWT.Chili_Text;
        //        }
        //        else
        //        {
        //            if (PI.R1_I3 == "Beef")
        //            {
        //                R1I3Text.text = PWT.Beef_Text;
        //            }
        //            else if (PI.R1_I3 == "Ham")
        //            {
        //                R1I3Text.text = PWT.Ham_Text;
        //            }
        //            else
        //            {
        //                if (PI.R1_I3 == "Champignon")
        //                {
        //                    R1I3Text.text = PWT.Champignon_Text;
        //                }
        //                else if (PI.R1_I3 == "DeathCap")
        //                {
        //                    R1I3Text.text = PWT.DeathCap_Text;
        //                }
        //                else
        //                {
        //                    if (PI.R1_I3 == "Onion")
        //                    {
        //                        R1I3Text.text = PWT.Onion_Text;
        //                    }
        //                    else if (PI.R1_I3 == "Carrot")
        //                    {
        //                        R1I3Text.text = PWT.Carrot_Text;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        //else
        //{
        //    R1I1Text.text = PWT.NothingSelected_Text;
        //    R1I2Text.text = PWT.NothingSelected_Text;
        //    R1I3Text.text = PWT.NothingSelected_Text;
        //}

        ////Recipe2 Texts
        //if (PI.R2Selected == false)
        //    Recipe2Text.text = PWT.NothingSelected_Text;
        //else if (PI.R2Selected == true)
        //{
        //    if (PI.Recipe2 == "Skewer")
        //    {
        //        Recipe2Text.text = PWT.RecipeSkewer_Text;
        //    }
        //    if (PI.Recipe2 == "Salad")
        //    {
        //        Recipe2Text.text = PWT.RecipeSalad_Text;
        //    }
        //    if (PI.Recipe2 == "Soup")
        //    {
        //        Recipe2Text.text = PWT.RecipeSoup_Text;
        //    }
        //    if (PI.Recipe2 == "Stew")
        //    {
        //        Recipe2Text.text = PWT.RecipeStew_Text;
        //    }
        //    if (PI.Recipe2 == "Panini")
        //    {
        //        Recipe2Text.text = PWT.RecipePanini_Text;
        //    }
        //    if (PI.Recipe2 == "Bruschetta")
        //    {
        //        Recipe2Text.text = PWT.RecipeBruschetta_Text;
        //    }
        //}

        ////R2 Ingredients
        //if (PI.R2Selected == true)
        //{
        //    if (PI.R2_I1 == "Toast") //Base
        //    {
        //        R2I1Text.text = PWT.Toast_Text;
        //    }
        //    else if (PI.R2_I1 == "Loaf")
        //    {
        //        R2I1Text.text = PWT.Loaf_Text;
        //    }
        //    else
        //    {
        //        if (PI.R2_I1 == "Tomato")
        //        {
        //            R2I1Text.text = PWT.Tomato_Text;
        //        }
        //        else if (PI.R2_I1 == "Chili")
        //        {
        //            R2I1Text.text = PWT.Chili_Text;
        //        }
        //        else
        //        {
        //            if (PI.R2_I1 == "Beef")
        //            {
        //                R2I1Text.text = PWT.Beef_Text;
        //            }
        //            else if (PI.R2_I1 == "Ham")
        //            {
        //                R2I1Text.text = PWT.Ham_Text;
        //            }
        //            else
        //            {
        //                if (PI.R2_I1 == "Champignon")
        //                {
        //                    R2I1Text.text = PWT.Champignon_Text;
        //                }
        //                else if (PI.R2_I1 == "DeathCap")
        //                {
        //                    R2I1Text.text = PWT.DeathCap_Text;
        //                }
        //                else
        //                {
        //                    if (PI.R2_I1 == "Onion")
        //                    {
        //                        R2I1Text.text = PWT.Onion_Text;
        //                    }
        //                    else if (PI.R2_I1 == "Carrot")
        //                    {
        //                        R2I1Text.text = PWT.Carrot_Text;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (PI.R2_I2 == "Toast") //Base
        //    {
        //        R2I2Text.text = PWT.Toast_Text;
        //    }
        //    else if (PI.R2_I2 == "Loaf")
        //    {
        //        R2I2Text.text = PWT.Loaf_Text;
        //    }
        //    else
        //    {
        //        if (PI.R2_I2 == "Tomato")
        //        {
        //            R2I2Text.text = PWT.Tomato_Text;
        //        }
        //        else if (PI.R2_I2 == "Chili")
        //        {
        //            R2I2Text.text = PWT.Chili_Text;
        //        }
        //        else
        //        {
        //            if (PI.R2_I2 == "Beef")
        //            {
        //                R2I2Text.text = PWT.Beef_Text;
        //            }
        //            else if (PI.R2_I2 == "Ham")
        //            {
        //                R2I2Text.text = PWT.Ham_Text;
        //            }
        //            else
        //            {
        //                if (PI.R2_I2 == "Champignon")
        //                {
        //                    R2I2Text.text = PWT.Champignon_Text;
        //                }
        //                else if (PI.R2_I2 == "DeathCap")
        //                {
        //                    R2I2Text.text = PWT.DeathCap_Text;
        //                }
        //                else
        //                {
        //                    if (PI.R2_I2 == "Onion")
        //                    {
        //                        R2I2Text.text = PWT.Onion_Text;
        //                    }
        //                    else if (PI.R2_I2 == "Carrot")
        //                    {
        //                        R2I2Text.text = PWT.Carrot_Text;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (PI.R2_I3 == "Toast") //Base
        //    {
        //        R2I3Text.text = PWT.Toast_Text;
        //    }
        //    else if (PI.R2_I3 == "Loaf")
        //    {
        //        R2I3Text.text = PWT.Loaf_Text;
        //    }
        //    else
        //    {
        //        if (PI.R2_I3 == "Tomato")
        //        {
        //            R2I3Text.text = PWT.Tomato_Text;
        //        }
        //        else if (PI.R2_I3 == "Chili")
        //        {
        //            R2I3Text.text = PWT.Chili_Text;
        //        }
        //        else
        //        {
        //            if (PI.R2_I3 == "Beef")
        //            {
        //                R2I3Text.text = PWT.Beef_Text;
        //            }
        //            else if (PI.R2_I3 == "Ham")
        //            {
        //                R2I3Text.text = PWT.Ham_Text;
        //            }
        //            else
        //            {
        //                if (PI.R2_I3 == "Champignon")
        //                {
        //                    R2I3Text.text = PWT.Champignon_Text;
        //                }
        //                else if (PI.R2_I3 == "DeathCap")
        //                {
        //                    R2I3Text.text = PWT.DeathCap_Text;
        //                }
        //                else
        //                {
        //                    if (PI.R2_I3 == "Onion")
        //                    {
        //                        R2I3Text.text = PWT.Onion_Text;
        //                    }
        //                    else if (PI.R2_I3 == "Carrot")
        //                    {
        //                        R2I3Text.text = PWT.Carrot_Text;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        //else
        //{
        //    R2I1Text.text = PWT.NothingSelected_Text;
        //    R2I2Text.text = PWT.NothingSelected_Text;
        //    R2I3Text.text = PWT.NothingSelected_Text;
        //}

        ////Recipe3 Texts
        //if (PI.R3Selected == false)
        //    Recipe3Text.text = PWT.NothingSelected_Text;
        //else if (PI.R3Selected == true)
        //{
        //    if (PI.Recipe3 == "Skewer")
        //    {
        //        Recipe3Text.text = PWT.RecipeSkewer_Text;
        //    }
        //    if (PI.Recipe3 == "Salad")
        //    {
        //        Recipe3Text.text = PWT.RecipeSalad_Text;
        //    }
        //    if (PI.Recipe3 == "Soup")
        //    {
        //        Recipe3Text.text = PWT.RecipeSoup_Text;
        //    }
        //    if (PI.Recipe3 == "Stew")
        //    {
        //        Recipe3Text.text = PWT.RecipeStew_Text;
        //    }
        //    if (PI.Recipe3 == "Panini")
        //    {
        //        Recipe3Text.text = PWT.RecipePanini_Text;
        //    }
        //    if (PI.Recipe3 == "Bruschetta")
        //    {
        //        Recipe3Text.text = PWT.RecipeBruschetta_Text;
        //    }
        //}

        ////R3 Ingredients
        //if (PI.R3Selected == true)
        //{
        //    if (PI.R3_I1 == "Toast") //Base
        //    {
        //        R3I1Text.text = PWT.Toast_Text;
        //    }
        //    else if (PI.R3_I1 == "Loaf")
        //    {
        //        R3I1Text.text = PWT.Loaf_Text;
        //    }
        //    else
        //    {
        //        if (PI.R3_I1 == "Tomato")
        //        {
        //            R3I1Text.text = PWT.Tomato_Text;
        //        }
        //        else if (PI.R3_I1 == "Chili")
        //        {
        //            R3I1Text.text = PWT.Chili_Text;
        //        }
        //        else
        //        {
        //            if (PI.R3_I1 == "Beef")
        //            {
        //                R3I1Text.text = PWT.Beef_Text;
        //            }
        //            else if (PI.R3_I1 == "Ham")
        //            {
        //                R3I1Text.text = PWT.Ham_Text;
        //            }
        //            else
        //            {
        //                if (PI.R3_I1 == "Champignon")
        //                {
        //                    R3I1Text.text = PWT.Champignon_Text;
        //                }
        //                else if (PI.R3_I1 == "DeathCap")
        //                {
        //                    R3I1Text.text = PWT.DeathCap_Text;
        //                }
        //                else
        //                {
        //                    if (PI.R3_I1 == "Onion")
        //                    {
        //                        R3I1Text.text = PWT.Onion_Text;
        //                    }
        //                    else if (PI.R3_I1 == "Carrot")
        //                    {
        //                        R3I1Text.text = PWT.Carrot_Text;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (PI.R3_I2 == "Toast") //Base
        //    {
        //        R3I2Text.text = PWT.Toast_Text;
        //    }
        //    else if (PI.R3_I2 == "Loaf")
        //    {
        //        R3I2Text.text = PWT.Loaf_Text;
        //    }
        //    else
        //    {
        //        if (PI.R3_I2 == "Tomato")
        //        {
        //            R3I2Text.text = PWT.Tomato_Text;
        //        }
        //        else if (PI.R3_I2 == "Chili")
        //        {
        //            R3I2Text.text = PWT.Chili_Text;
        //        }
        //        else
        //        {
        //            if (PI.R3_I2 == "Beef")
        //            {
        //                R3I2Text.text = PWT.Beef_Text;
        //            }
        //            else if (PI.R3_I2 == "Ham")
        //            {
        //                R3I2Text.text = PWT.Ham_Text;
        //            }
        //            else
        //            {
        //                if (PI.R3_I2 == "Champignon")
        //                {
        //                    R3I2Text.text = PWT.Champignon_Text;
        //                }
        //                else if (PI.R3_I2 == "DeathCap")
        //                {
        //                    R3I2Text.text = PWT.DeathCap_Text;
        //                }
        //                else
        //                {
        //                    if (PI.R3_I2 == "Onion")
        //                    {
        //                        R3I2Text.text = PWT.Onion_Text;
        //                    }
        //                    else if (PI.R3_I2 == "Carrot")
        //                    {
        //                        R3I2Text.text = PWT.Carrot_Text;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (PI.R3_I3 == "Toast") //Base
        //    {
        //        R3I3Text.text = PWT.Toast_Text;
        //    }
        //    else if (PI.R3_I3 == "Loaf")
        //    {
        //        R3I3Text.text = PWT.Loaf_Text;
        //    }
        //    else
        //    {
        //        if (PI.R3_I3 == "Tomato")
        //        {
        //            R3I3Text.text = PWT.Tomato_Text;
        //        }
        //        else if (PI.R3_I3 == "Chili")
        //        {
        //            R3I3Text.text = PWT.Chili_Text;
        //        }
        //        else
        //        {
        //            if (PI.R3_I3 == "Beef")
        //            {
        //                R3I3Text.text = PWT.Beef_Text;
        //            }
        //            else if (PI.R3_I3 == "Ham")
        //            {
        //                R3I3Text.text = PWT.Ham_Text;
        //            }
        //            else
        //            {
        //                if (PI.R3_I3 == "Champignon")
        //                {
        //                    R3I3Text.text = PWT.Champignon_Text;
        //                }
        //                else if (PI.R3_I3 == "DeathCap")
        //                {
        //                    R3I3Text.text = PWT.DeathCap_Text;
        //                }
        //                else
        //                {
        //                    if (PI.R3_I3 == "Onion")
        //                    {
        //                        R3I3Text.text = PWT.Onion_Text;
        //                    }
        //                    else if (PI.R3_I3 == "Carrot")
        //                    {
        //                        R3I3Text.text = PWT.Carrot_Text;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        //else
        //{
        //    R3I1Text.text = PWT.NothingSelected_Text;
        //    R3I2Text.text = PWT.NothingSelected_Text;
        //    R3I3Text.text = PWT.NothingSelected_Text;
        //}
    }
}
