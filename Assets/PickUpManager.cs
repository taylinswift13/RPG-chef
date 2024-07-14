using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    public List<GameObject> ObjectsInRange = new List<GameObject>();
    public static PickUpManager instance;
    public Transform HoldPlace;
    public float NearestValue;
    public int NearestIndex;
   
    void Start()
    {
        instance = this;
        NearestValue = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectsInRange.Count == 0) return;
        
        if (GameObject.Find("HoldPlace").transform.childCount==0)
        {
          //  NearestObjectCheck();
            PickUptheNearest();
        }
        else
        {
            ObjectsInRange.Clear();
        }
    }
    void NearestObjectCheck()
    {
        
        if (ObjectsInRange.Count > 0 )
        {
            for (int currentOne = 0; currentOne < ObjectsInRange.Count; currentOne++)
            {
                NearestValue = Mathf.Min(ObjectsInRange[currentOne].GetComponent<PickedUpChecking>().Distance, NearestValue);

                if (NearestValue == Mathf.Min(ObjectsInRange[currentOne].GetComponent<PickedUpChecking>().Distance))
                {
                    NearestIndex = currentOne;
                }
            }
        }
       
    }
    void PickUptheNearest()
    {
        if ((Input.GetMouseButton(0) || Input.GetButton("LB"))
            &&ObjectsInRange.Count>0)
        {
            GameObject.Find("Body").GetComponent<Animator>().SetBool("Holding", true);
            GameObject.Find("Body").GetComponent<Animator>().SetBool("Throwing", false);
            ObjectsInRange[0].GetComponent<PickedUpChecking>().PickedUp = true;
        }
    }
}
