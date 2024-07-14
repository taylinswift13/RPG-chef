using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookingManager : MonoBehaviour
{
    public List<Transform> CookingStationPositions=new List<Transform>();
    public List<Transform> MealPositions=new List<Transform>();
    public List<GameObject> UIs = new List<GameObject>();
    public List<GameObject> CookingStations = new List<GameObject>();
    public List<RecipeInformation> Recipes = new List<RecipeInformation>();
    public List<RecipeInformation> DisplayedRecipes = new List<RecipeInformation>();
    public List<GameObject> DisplayedCStations = new List<GameObject>();
    public List<string> SelectedRecipes = new List<string>();
    public List<GameObject> Crates = new List<GameObject>();
    public List<GameObject> InstantiatedItems = new List<GameObject>();
    public static CookingManager instance;
    public GameObject Status;
    // Start is called before the first frame update
    void Start()
    {
        Status = GameObject.Find("Status");
        Status.SetActive(false);
        instance = this;
        SelectedRecipes[0]=GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().Recipe1;
        SelectedRecipes[1]=GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().Recipe2;
        SelectedRecipes[2]=GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().Recipe3;
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (RecipeInformation Recipe in Recipes)//find 3 recipes out of 6 to display
        {
            for (int i = 0; i < 3; i++)
            {
                if (SelectedRecipes[i] == Recipe.RecipeName&&DisplayedRecipes.Count<3)
                {
                    DisplayedRecipes.Add(Recipe);
                }
            }
        }
        
        for (int i = 0; i < 3; i++)
        {
            UIs[i].transform.GetChild(1).transform.GetChild(0).GetComponent<Image>().sprite= Resources.Load<Sprite>("Material/"+DisplayedRecipes[i].Ingredient_1);
            UIs[i].transform.GetChild(2).transform.GetChild(0).GetComponent<Image>().sprite= Resources.Load<Sprite>("Material/"+DisplayedRecipes[i].Ingredient_2);
            UIs[i].transform.GetChild(3).transform.GetChild(0).GetComponent<Image>().sprite= Resources.Load<Sprite>("Material/"+DisplayedRecipes[i].Ingredient_3);
        }
        foreach (GameObject CookingStation in CookingStations)
        {
            for (int i = 0; i < 3; i++)
            {
                if (CookingStation.name == DisplayedRecipes[i].RecipeName)
                { 
                    CookingStation.transform.position = CookingStationPositions[i].position;
                    CookingStation.GetComponent<CookingProcess>().Index = i;
                   if (DisplayedCStations.Count < 3)
                   {
                        DisplayedCStations.Add(CookingStation);
                   }
                   CookingStation.GetComponent<CookingProcess>().Dispay = true;
                }
            }
            
            if (CookingStation.GetComponent<CookingProcess>().Dispay == false)
            {
                CookingStation.SetActive (false);
            }
        }
        IngredientUpdate();
        DisplayCrates();
    }
    void IngredientUpdate()
    {
        for (int i = 0; i < 3; i++)
        {
            if (SelectedRecipes[0] == DisplayedCStations[i].name)//match the name from camp scene with fight scene
            {//take camp scene sequence as reference and change the ingredient based on that
                DisplayedRecipes[i].Ingredient_1 = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R1_I1;
                DisplayedRecipes[i].Ingredient_2 = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R1_I2;
                DisplayedRecipes[i].Ingredient_3 = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R1_I3;
                if (DisplayedCStations[i].GetComponent<CookingProcess>().Ingredients.Count < 3)
                {
                    DisplayedCStations[i].GetComponent<CookingProcess>().Ingredients.Add(GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R1_I1);
                    DisplayedCStations[i].GetComponent<CookingProcess>().Ingredients.Add(GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R1_I2);
                    DisplayedCStations[i].GetComponent<CookingProcess>().Ingredients.Add(GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R1_I3);
                }
            }
            if (SelectedRecipes[1] == DisplayedCStations[i].name)//match the name from camp scene with fight scene
            {//take camp scene sequence as reference and change the ingredient based on that
                DisplayedRecipes[i].Ingredient_1 = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R2_I1;
                DisplayedRecipes[i].Ingredient_2 = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R2_I2;
                DisplayedRecipes[i].Ingredient_3 = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R2_I3;
                if (DisplayedCStations[i].GetComponent<CookingProcess>().Ingredients.Count < 3)
                {
                    DisplayedCStations[i].GetComponent<CookingProcess>().Ingredients.Add(GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R2_I1);
                    DisplayedCStations[i].GetComponent<CookingProcess>().Ingredients.Add(GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R2_I2);
                    DisplayedCStations[i].GetComponent<CookingProcess>().Ingredients.Add(GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R2_I3);
                }
            }
            if (SelectedRecipes[2] == DisplayedCStations[i].name)//match the name from camp scene with fight scene
            {//take camp scene sequence as reference and change the ingredient based on that
                DisplayedRecipes[i].Ingredient_1 = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R3_I1;
                DisplayedRecipes[i].Ingredient_2 = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R3_I2;
                DisplayedRecipes[i].Ingredient_3 = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R3_I3;
                if (DisplayedCStations[i].GetComponent<CookingProcess>().Ingredients.Count < 3)
                {
                    DisplayedCStations[i].GetComponent<CookingProcess>().Ingredients.Add(GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R3_I1);
                    DisplayedCStations[i].GetComponent<CookingProcess>().Ingredients.Add(GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R3_I2);
                    DisplayedCStations[i].GetComponent<CookingProcess>().Ingredients.Add(GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>().R3_I3);
                }
            }
        }
    }
    void DisplayCrates()
    {
        foreach(RecipeInformation recipeInformation in DisplayedRecipes)
        {
            foreach(GameObject Crate in Crates)
            {
                if (recipeInformation.Ingredient_1 == Crate.name)
                {
                    Crate.SetActive(true);
                }
                if (recipeInformation.Ingredient_2 == Crate.name)
                {
                    Crate.SetActive(true);
                }
                if (recipeInformation.Ingredient_3 == Crate.name)
                {
                    Crate.SetActive(true);
                }

            }
        }
    }
    
}
