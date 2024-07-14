using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    [SerializeField] float SlowScrollingSpeed = 70.0f;
    [SerializeField] float FastScrollingSpeed = 200.0f;
    [SerializeField] float TargetTime = 80.0f;

    private float ScrollingSpeed;

    void Start()
    {
        ScrollingSpeed = SlowScrollingSpeed;
    }
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * ScrollingSpeed;
        TargetTime -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScrollingSpeed = FastScrollingSpeed;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ScrollingSpeed = SlowScrollingSpeed;
        }

        if (TargetTime <= 0.0f)
        {
            SceneManager.LoadScene("1_StartScene");
        }
    }
}
