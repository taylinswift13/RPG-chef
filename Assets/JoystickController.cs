using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoystickController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Toggle>().isOn == true)
        {
            PlayerMovement.instance.JoystickController = true;
        }
        else
        {
            PlayerMovement.instance.JoystickController = false;
        }
    }
}
