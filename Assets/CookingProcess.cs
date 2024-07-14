using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UI;

public class CookingProcess : MonoBehaviour
{
    public float CookingTime;
    public GameObject Meal;  
    bool ClearThePot;
    public bool FoodIsReady;
    public bool Dispay;
    public int Index;
    float CookingCD;
    bool isCooking;
    public GameObject CookingEfect;
    public GameObject FailEfect;
    public GameObject DoneEfect;
    public Transform mealPosition;
    
    public List<GameObject> ObjectsInPot = new List<GameObject>(); 
    public List<string> Ingredients = new List<string>();
    public List<string> Status = new List<string>();
    public List<float> StatusValue = new List<float>();
    
    // Start is called before the first frame update
    void Start()
    {
        CookingCD = CookingTime;
    }

    // Update is called once per frame
    void Update()
    {
        mealPosition = CookingManager.instance.MealPositions[Index];
        CookingManager.instance.UIs[Index].transform.GetChild(4).GetComponent<Image>().fillAmount = CookingCD / CookingTime;
        if (FoodIsReady == false)
        { 
            Cooking();
        }
       Clear();
        if (ObjectsInPot.Count == 0)
        {
            ClearThePot = false;
        }
        CookingSoundPlay();
    }
    private void OnTriggerEnter(Collider other)//check if the ingredient is needed and trigger the toggle 
    {
      for (int i = 0; i < Ingredients.Count; i++)//travesal the list
    {
        if (other.gameObject.tag == Ingredients[i])//found the right string
        {
            CookingManager.instance.GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sound/Correct_Ingredient"));
            Status[i] = other.gameObject.GetComponent<IngredientStatus>().Effect;
            StatusValue[i]= other.gameObject.GetComponent<IngredientStatus>().Value;
            CookingManager.instance.UIs[Index].transform.GetChild(i+1).GetComponent<Toggle>().isOn = true;
            ObjectsInPot.Add(other.gameObject.transform.parent.gameObject);
        }
    }
    }
    private void OnTriggerStay(Collider other)
    {
   
        if (other.gameObject.tag != "PlayerBody"&&other.gameObject.tag!="HoldPlace")
        {
            if (!Ingredients.Contains(other.gameObject.tag))//wrong ingredients
            {
                if (isCooking)
                {
                    isCooking = false;
                    CookingEfect.SetActive(false);
                    CookingCD = CookingTime;
                }
                CookingManager.instance.GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sound/Wrong_Ingredient"));
                FailEfect.GetComponent<VisualEffect>().Play();
                Debug.Log(other.gameObject.name);
                ClearThePot = true;
                CookingManager.instance.UIs[Index].transform.GetChild(1).GetComponent<Toggle>().isOn = false;
                CookingManager.instance.UIs[Index].transform.GetChild(2).GetComponent<Toggle>().isOn = false;
                CookingManager.instance.UIs[Index].transform.GetChild(3).GetComponent<Toggle>().isOn = false;
                Destroy(other.gameObject.transform.parent.gameObject);
            }
        }                
    }
    private void OnTriggerExit(Collider other)
    {
        for (int i = 0; i < Ingredients.Count; i++)//travesal the list
        {
            if (other.gameObject.tag == Ingredients[i])//found the right string
            {
                CookingManager.instance.UIs[Index].transform.GetChild(i+1).GetComponent<Toggle>().isOn = false;
                ObjectsInPot.Remove(other.gameObject.transform.parent.gameObject);
            }
        }
    }
    void Clear()
    {
        if (ObjectsInPot.Count > 0&&ClearThePot)
        {
            foreach (GameObject Object in ObjectsInPot)
            {
                Destroy(Object.gameObject);
            }
            ObjectsInPot.Clear();
        }
        
    }
    void Cooking()
    {
        if (ReadyforCooking())
        {
            isCooking = true;
            CookingEfect.SetActive(true);
            CookingCD -= Time.deltaTime;
        }
        
        if (CookingCD <= 0)
        {
            CookingManager.instance.GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sound/Food_Done"));
            isCooking = false;
            DoneEfect.GetComponent<VisualEffect>().Play(); 
            DoneEfect.transform.position=mealPosition.position;
            CookingEfect.SetActive(false);
            CookingManager.instance.UIs[Index].transform.GetChild(1).GetComponent<Toggle>().isOn = false;
            CookingManager.instance.UIs[Index].transform.GetChild(2).GetComponent<Toggle>().isOn = false;
            CookingManager.instance.UIs[Index].transform.GetChild(3).GetComponent<Toggle>().isOn = false;
            InstantiateFood();
             CookingCD = CookingTime;
             ClearThePot = true;    
        }       
    }
    bool ReadyforCooking()
    {
        for (int i = 0; i < 3; i++)
        { 
            if (CookingManager.instance.UIs[Index].transform.GetChild(1).GetComponent<Toggle>().isOn == true &
               CookingManager.instance.UIs[Index].transform.GetChild(2).GetComponent<Toggle>().isOn == true &
               CookingManager.instance.UIs[Index].transform.GetChild(3).GetComponent<Toggle>().isOn == true)//every toggle is on then start cooking
            {
                return true;
            }
        }
        return false;
    }
    void InstantiateFood()
    {
        
        Instantiate(Meal, mealPosition.position, Meal.transform.rotation);        
    }
    void CookingSoundPlay()
    {
        if (isCooking == true)
        {
            if (GetComponent<AudioSource>().isPlaying == false)
            {
                GetComponent<AudioSource>().Play();
            }
        }
        else
        {
            GetComponent<AudioSource>().Stop();
        }
    }
   
}
