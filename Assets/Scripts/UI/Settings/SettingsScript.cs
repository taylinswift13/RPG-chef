using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject SettingsMenu;

    public TMPro.TMP_Text Controls_Text;

    private int ControlsVar = 0;
    private PersistentItemsScript PI;

    private void Start()
    {
        PI = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>();

        ControlsVar = PlayerPrefs.GetInt("ControlsOption", ControlsVar);
        if (ControlsVar == 0)
            Controls_Text.text = "Mouse";
        else if (ControlsVar == 1)
            Controls_Text.text = "Controller";
    }

    public void ReturnToPauseMenu()
    {
        PauseMenu.SetActive(true);
        SettingsMenu.SetActive(false);
        PlayerPrefs.Save();
    }

    public void SetControlsMouse()
    {
        ControlsVar = 0;
        PlayerPrefs.SetInt("ControlsOption", ControlsVar);
        Controls_Text.text = "Mouse";
    }
    public void SetControlsController()
    {
        ControlsVar = 1;
        PlayerPrefs.SetInt("ControlsOption", ControlsVar);
        Controls_Text.text = "Controller";
    }
}
