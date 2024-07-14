using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickedUpChecking : MonoBehaviour
{
    Transform HoldingPlace;
    public bool PickedUp;
    public bool ReadyToThrow;
    public bool isGrounded;
    public bool Holding;
    public float Distance;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerBody"&&HoldingPlace.transform.childCount==0)
        {
            PickUpManager.instance.ObjectsInRange.Add(gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "PlayerBody")
        {
            PickUpManager.instance.ObjectsInRange.Clear();
        }
    }
  
    // Update is called once per frame
    void Update()
    {
        HoldingPlace = GameObject.Find("HoldPlace").transform;
        if (PickedUp)
        {
            gameObject.transform.parent.SetParent(HoldingPlace);
            if (gameObject.tag == "Dish")
            {
               CookingManager.instance.Status.SetActive(true);
                GameObject.Find("Status_1").GetComponent<Image>().sprite = Resources.Load<Sprite>("Material/" + GetComponent<DishStatus>().Status[0]);
                GameObject.Find("Status_2").GetComponent<Image>().sprite = Resources.Load<Sprite>("Material/" + GetComponent<DishStatus>().Status[1]);
                GameObject.Find("Status_3").GetComponent<Image>().sprite = Resources.Load<Sprite>("Material/" + GetComponent<DishStatus>().Status[2]);
            }
            gameObject.transform.position = HoldingPlace.position;
          //  gameObject.GetComponent<Rigidbody>().Sleep();
           gameObject.GetComponent<Rigidbody>().useGravity = false;
           gameObject.GetComponent<Rigidbody>().freezeRotation = true;
        }
        else
        {
            if (gameObject.tag == "Dish")
            { CookingManager.instance.Status.SetActive(false); }
           // gameObject.GetComponent<Rigidbody>().WakeUp();
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject.GetComponent<Rigidbody>().freezeRotation = false;
        }
        Distance = Vector3.Distance(transform.position, HoldingPlace.transform.position);
    }
}
