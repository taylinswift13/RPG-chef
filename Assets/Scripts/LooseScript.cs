using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LooseScript : MonoBehaviour
{
    private int RoundCounter;
    private PersistentItemsScript PI;

    public GameObject Loose_1;

    void Start()
    {
        Time.timeScale = 1;
        PI = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>();
        RoundCounter = PlayerPrefs.GetInt("RoundCounter", 1);
    }
    public void ReturnCamp()
    {
        PI.MenuOpen = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("2_CampScene");
    }
    public void RestartFight()
    {
        PI.MenuOpen = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }
    public void ReturnMainMenu()
    {
        PlayerPrefs.SetInt("RoundCounter", 1);
        Time.timeScale = 1;
        SceneManager.LoadScene("1_StartScene");
    }
    public void LaunchLoss()
    {
        Loose_1.SetActive(true);
        PI.MenuOpen = true;
        Time.timeScale = 0;
    }
}
