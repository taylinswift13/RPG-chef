using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public GameObject Rewards_1;
    public GameObject Rewards_2;
    public GameObject Rewards_3;

    private int RoundCounter;
    private PersistentItemsScript PI;

    private void Start()
    {
        Time.timeScale = 1;
        PI = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>();
        RoundCounter = PlayerPrefs.GetInt("RoundCounter", 1);
    }

    private void Awake()
    {
        
    }

    public void Continue()
    {
        if (RoundCounter < 3)
        {
            PlayerPrefs.SetInt("RoundCounter", RoundCounter + 1);
            PI.MenuOpen = false;
            Time.timeScale = 1;
            Rewards_1.SetActive(false);
            Rewards_2.SetActive(false);
            Rewards_3.SetActive(false);
            SceneManager.LoadScene("2_CampScene");
        }
        if (RoundCounter == 3)
        {
            PlayerPrefs.SetInt("RoundCounter", 1);
            PI.MenuOpen = false;
            Time.timeScale = 1;
            Rewards_1.SetActive(false);
            Rewards_2.SetActive(false);
            Rewards_3.SetActive(false);
            SceneManager.LoadScene("4_EndScene");
        }
    }

    public void LaunchWin()
    {
        Time.timeScale = 0;

        if (RoundCounter == 1)
        {
            Rewards_1.SetActive(true);
            PI.MenuOpen = true;
        }
        if (RoundCounter == 2)
        {
            Rewards_2.SetActive(true);
            PI.MenuOpen = true;
        }
        if (RoundCounter == 3)
        {
            Rewards_3.SetActive(true);
            PI.MenuOpen = true;
        }
    }
}
