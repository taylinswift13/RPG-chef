using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingController : MonoBehaviour
{
    Vector3 point_1, point_2, point_3, AimingDirection;
    GameObject AttachedObject;
    public float MinDistance;
    
    public float MaxDistance;
    public float ChargingSpeed;
    public float Height;
    public float MaxHeight;
    public float StartDistance;
    public float StartHeight;
    Vector3 MouseInView;
    float x;
    float z;
    float LT_Value;
   // public Vector3 MouseInView;

    private void Start()
    {
        StartDistance = MinDistance;
        StartHeight = Height;
        AttachedObject = gameObject.transform.parent.GetChild(0).gameObject;
    }

    void Update()
    {
        LT_Value = Input.GetAxis("LT");
        GetCameraForMousePosition();
        if (AttachedObject.GetComponent<PickedUpChecking>().PickedUp)
        {
            //point 1
            point_1 = GameObject.FindGameObjectWithTag("HoldPlace").transform.position;
            gameObject.transform.GetChild(0).position = point_1;
                if (PlayerMovement.instance.JoystickController)
                {
                    x = -PlayerMovement.instance.MouseInView.normalized.x * MinDistance;
                    z = -PlayerMovement.instance.MouseInView.normalized.y * MinDistance;
                    if (LT_Value > 0.1)
                    {
                        Height = LT_Value / 1 * MaxHeight;
                        MinDistance = LT_Value / 1 * MaxDistance;
                    }
                    if (LT_Value < 0.1)
                    {
                        LT_Value = 0;
                    }
                }
                else
                {
                    x = -PlayerMovement.instance.MouseToPlayer.normalized.x * MinDistance;
                    z = -PlayerMovement.instance.MouseToPlayer.normalized.z * MinDistance;
                    if(Input.GetMouseButton(1) == true)
                    {
                       Height += Time.deltaTime * ChargingSpeed/3;
                       if (Height >= MaxHeight)
                       {
                           Height = MaxHeight;
                       }
                       MinDistance += Time.deltaTime * ChargingSpeed;
                       if (MinDistance >= MaxDistance)
                       {
                           MinDistance = MaxDistance;
                       }
                    }
                }

                gameObject.transform.GetChild(2).position = point_1 + new Vector3(x, 0, z);
               
                //Point 2 
                point_2 = Vector3.Lerp(point_1,gameObject.transform.GetChild(2).position, 0.5f);
                gameObject.transform.GetChild(1).position = new Vector3(point_2.x, point_2.y + Height, point_2.z);
            }
        
    }
    public Camera GetCameraForMousePosition()
    {
        Camera[] allCameras = Object.FindObjectsOfType(typeof(Camera)) as Camera[];
        foreach (Camera camera in allCameras)
        {
           Vector3 position = camera.ScreenToViewportPoint(Input.mousePosition);
            MouseInView = new Vector3(position.x-0.5f, position.y-0.5f, position.z);
        }
        return null;
    }
}
