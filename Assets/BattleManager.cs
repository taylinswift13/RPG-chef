using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    public static BattleManager instance;
    public GameObject CenterPoint;
    public GameObject LoseScreen;
    public GameObject WinScreen;
    public List<GameObject> members = new List<GameObject>();
    public List<GameObject> enemies = new List<GameObject>();
    public float StartBurningDamage;
    public float BurningInterval;
    public float PoisonedInterval;
    public float PoisonDamage;
    public float RegenInterval;
    public float RegenDamage;
    public int RegenDuration;
    public float StunInterval;
    public void Start()
    {
        instance =this ;
    }

    // Update is called once per frame
   private void Update()
    {
        IsAliveChecking();
        WinLoseCondition();
    }

    public void IsAliveChecking()
    {
        if (enemies.Count > 0)
        { 
            if (enemies[0].GetComponent<EnemyStatus>().isAlive == false)
            {
                enemies.RemoveAt(0); 
            }
        }
        if (enemies.Count == 0)
        {
            return;
        }
        
        if(members.Count>0)
        {
            if (members[0].GetComponent<MemberStatus>().isAlive == false)           
            {
                members.RemoveAt(0); 
            } 
        }
        if (members.Count == 0)
        {
            return;
        }
       
    }
    void WinLoseCondition()
    {
        if (members.Count == 0)
        {
            LoseScreen.GetComponent<LooseScript>().LaunchLoss();
        }
        if (enemies.Count == 0)
        {
            WinScreen.GetComponent<WinScript>().LaunchWin();
        }
    }

}
