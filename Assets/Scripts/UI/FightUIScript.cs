using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FightUIScript : MonoBehaviour
{
    public void ToCampScene()
    {
        SceneManager.LoadScene("2_CampScene");
    }
}
