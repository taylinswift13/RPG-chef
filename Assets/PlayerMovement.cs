using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    public Transform Body;
    public LayerMask GroundMask;
    public static PlayerMovement instance;
    public Vector3 MouseInView;
     Vector3 newPosition;
    public float Speed;
    public Ray raycast;
    public Vector3 LandingPoint;
    public Vector3 MouseToPlayer;
    Vector3 position;
    public bool JoystickController;
    public int ControlsVariable;
    public GameObject HoldPlace;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    private void Update()
    {
            if (HoldPlace.transform.childCount > 1)
            {
                Destroy(HoldPlace.transform.GetChild(1).gameObject);
            }
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        ControlsVariable = PlayerPrefs.GetInt("ControlsOption");
        if (ControlsVariable == 0)
        {
            JoystickController = false;
        }
        else //ControlsVariable == 1
        {
            JoystickController = true;
        }

        //Look At
        Camera[] allCameras = Object.FindObjectsOfType(typeof(Camera)) as Camera[];
        foreach (Camera camera in allCameras)
        {       
            if (!JoystickController)
            {
               position = camera.ScreenToViewportPoint(Input.mousePosition);
                MouseInView = new Vector3(position.x-0.5f,position.y-0.5f,position.z);
                Body.LookAt(Body.position + new Vector3(-MouseToPlayer.x, 0, -MouseToPlayer.z));
                Vector3 MoveDirection = (newPosition.x * transform.right + newPosition.z * transform.forward).normalized;
                GetComponent<Rigidbody>().velocity = MoveDirection * Speed;
            }         
            raycast = camera.ScreenPointToRay(Input.mousePosition);
            
        }
        if(JoystickController)
        {
            position.x = Input.GetAxis("RS_Horizontal");
            position.y = -Input.GetAxis("RS_Vertical"); 
            MouseInView = position;
            Body.LookAt(Body.position + new Vector3(-MouseInView.x, 0,-MouseInView.y));
            Vector3 MoveDirection = (newPosition.x * transform.right + newPosition.z * transform.forward).normalized;
            GetComponent<Rigidbody>().velocity = MoveDirection * Speed;
        }
       
        MouseToPlayer = Body.position - LandingPoint;
        //Movement
        float moveVertical = -Input.GetAxis("Vertical");
        float moveHorizontal = -Input.GetAxis("Horizontal");
        newPosition = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if (moveHorizontal == 0 & moveVertical == 0)
        {
            Body.GetComponent<Animator>().SetBool("Walking", false);
        }
        else
        {
            Body.GetComponent<Animator>().SetBool("Walking", true);
        }
        RaycastHit hit;
        if (Physics.Raycast(raycast, out hit,1000f,GroundMask))
        {
            LandingPoint = hit.point;
        }
    }
}
