using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InstantiateObject : MonoBehaviour
{
    public GameObject Object;
    GameObject instance;
    GameObject HoldPlace;
    bool Instantiated;
    float LT_Value;
    public bool PortionLimited = false;
    Color OriginalColor;
     public int Portion;
    public int LeftPortion;
    public int Index;
    public Text PortionDisplay;
    public 

    // Start is called before the first frame update
    void Start()
    {
        LeftPortion = Portion;
        HoldPlace = GameObject.FindGameObjectWithTag("HoldPlace");
    }

    // Update is called once per frame
    void Update()
    {
        if (HoldPlace.transform.childCount > 1)
        {
            Destroy(HoldPlace.transform.GetChild(1).gameObject);
        }

        LT_Value = Input.GetAxis("LT");
        
        if (PortionLimited == true && LeftPortion == 0)
        {
            CookingManager.instance.DisplayedCStations[Index].GetComponent<CookingProcess>().FoodIsReady = false;
            PortionDisplay.enabled = false;
            Destroy(gameObject);
        }
        if (PortionLimited == true && LeftPortion > 0)
        {
            CookingManager.instance.DisplayedCStations[Index].GetComponent<CookingProcess>().FoodIsReady = true;
        }
        if (Instantiated)
        { 
            if (PortionLimited == true)
            {               
                for (int i = 0; i < 3; i++)
                {
                    instance.transform.GetChild(0).gameObject.GetComponent<DishStatus>().Status[i] = CookingManager.instance.DisplayedCStations[Index].GetComponent<CookingProcess>().Status[i];
                    instance.transform.GetChild(0).gameObject.GetComponent<DishStatus>().StatusValue[i] = CookingManager.instance.DisplayedCStations[Index].GetComponent<CookingProcess>().StatusValue[i];
                }
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Left")
        {
            Index = 0;
            PortionDisplay = CookingManager.instance.UIs[Index].transform.GetChild(5).GetComponent<Text>();
            PortionDisplay.enabled = true;
            PortionDisplay.text = LeftPortion.ToString() + "/" + Portion.ToString();
        }
        if (other.gameObject.tag == "Right")
        {
            Index = 2;
            PortionDisplay = CookingManager.instance.UIs[Index].transform.GetChild(5).GetComponent<Text>();
            PortionDisplay.enabled = true;
            PortionDisplay.text = LeftPortion.ToString() + "/" + Portion.ToString();
        }
        if (other.gameObject.tag == "Middle")
        {
            Index = 1;
            PortionDisplay = CookingManager.instance.UIs[Index].transform.GetChild(5).GetComponent<Text>();
            PortionDisplay.enabled = true;
            PortionDisplay.text = LeftPortion.ToString() + "/" + Portion.ToString();

        }
        if (other.gameObject.tag == "PlayerBody")
        {
            if (CookingManager.instance.InstantiatedItems.Count==0)
            {
                if ((Input.GetMouseButton(0) || Input.GetButton("LB"))
                  && PickUpManager.instance.ObjectsInRange.Count == 0)//spawning instance
                {
                    GameObject.Find("CookingSounds").GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sound/Grab_From_Crates"));
                    GameObject.Find("Body").GetComponent<Animator>().SetBool("Holding", true);
                    GameObject.Find("Body").GetComponent<Animator>().SetBool("Throwing", false);
                    instance = Instantiate(Object, HoldPlace.transform.position, Object.transform.rotation);
                    CookingManager.instance.InstantiatedItems.Add(instance);
                    instance.transform.GetChild(0).gameObject.GetComponent<PickedUpChecking>().PickedUp = true;
                    Instantiated = true;
                    if (PortionLimited == true && LeftPortion > 0)
                    {
                        LeftPortion--;
                    }
                }
            }        
        }
       
    }
    private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "PlayerBody")
            {
                 Instantiated = false;
            }
        }

}
