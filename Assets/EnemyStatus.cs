using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.VFX;


public class EnemyStatus : MonoBehaviour
{
    public float CurrentHP;
    public float maxHP;
    public float Attack;
    public float Defense;
    public float AttackInterval;
    public bool isAlive = true;
    public bool PlayedHealthWarning;
    public float BurningResistance;
    public float PoisonResistance;
    public float RegenResistance;
    public float StunResistance;
    public float BurningResistanceCount;
    public float PoisonResistanceCount;
    public float RegenResistanceCount;
    public float StunResistanceCount;

   
    float ColorShowingInterval = 0.2f;
    float AttackAT;//AT=accumalated time
    float BurningAT;
    float CurrentBurningDamage;
    float PoisonedAT = 0;
    float RegenAT = 0;
    float Duration;
    float LeftDuration;
    float StunAT;
    int PoisonedCount;
 
    bool DamageColorShowing;
    bool Burning;
    bool Regen;
    bool GotDamageInAT = false;
    bool Trigger = false;
    bool Trigger_2 = false;
    bool Stunned;
    bool BurningSoundPlayed;
    bool PoisonSoundPlayed;
    bool RegenSoundPlayed;
    bool StunSoundPlayed;

    public List<string> StatusOnEnemies = new List<string>();
    public List<string> StatusFromDish = new List<string>();
    public List<float> StatusValue = new List<float>();
    public List<bool> CheckingIngredient = new List<bool>();
    public Text BurnDamageDisplay;
    public Text PoisonDamageDisplay;
    public GameObject VFX;
    public Image Poisonbar;
    public Image Regenbar;
    public Image Healthbar;
    public Image Burningbar;
    public Image Attackbar;
    public Image Stunbar;

    Color OriginalColor;
    
    void Start()
    {
        GotDamageInAT = false;
        // OriginalColor = GetComponent<SkinnedMeshRenderer>().material.color;
        Duration = BattleManager.instance.RegenDuration;
        LeftDuration = BattleManager.instance.RegenDuration;
        CurrentBurningDamage = BattleManager.instance.StartBurningDamage+0.5f * BurningResistance;
        BurnDamageDisplay = Burningbar.transform.gameObject.GetComponentInChildren<Text>();
        PoisonDamageDisplay = Poisonbar.transform.gameObject.GetComponentInChildren<Text>();
        StatusOnEnemies.Add("BurningResistanceCount");
        StatusOnEnemies.Add("PoisonResistanceCount");
        StatusOnEnemies.Add("RegenResistanceCount");
        StatusOnEnemies.Add("StunResistanceCount");
        StatusOnEnemies.Add("Defense");
        StatusOnEnemies.Add("Attack");
        StatusOnEnemies.Add("AttackInterval");
    }
    void Update()
    {
        StopPoisoning();
        if (isAlive)
        {         
            StackStatus();
            OnBurning();
            OnPoisoning();
            OnRegening();
            OnStunning();
            BarDispaly();
            AttackingLoop();
            HPControll();
            //HurtColorInvoke();
        }
        if (!isAlive)
        {
            GetComponentInParent<Animator>().SetBool("Die", true);
            StopRegening();
            BarHide();
            StopBurning();
            PoisonedCount = 0;
            StunResistanceCount = 0;
            GetComponent<SkinnedMeshRenderer>().material= Resources.Load<Material>("Material/Ghost");
        }
    }
    public void LoseHP(float damage)
    {
        if (damage - Defense >= 1)
        { CurrentHP -= damage - Defense; }
        else
        {
            CurrentHP -= 1;
        }
        DamageColorShowing = true;
    }
    void AttackingLoop()
    {
        if (Stunned == false)
        { AttackAT += Time.deltaTime; }
        if (AttackAT >= AttackInterval)
        {
            GetComponentInParent<Animator>().Play("Attack", 1, 0f);
            Attacking();
            AttackAT = 0;
        }
    }
    void Attacking()
    {
        if (BattleManager.instance.members.Count > 0)
        { BattleManager.instance.members[0].GetComponent<MemberStatus>().LoseHP(Attack); }
    }
    void HPControll()
    {
        if (CurrentHP <= 0)
        {
            isAlive = false;
        }
        if (CurrentHP >= maxHP)
        {
            CurrentHP = maxHP;
        }
    }
    void HurtColorInvoke()
    {
        if (DamageColorShowing)
        {
            GetComponent<SkinnedMeshRenderer>().material.color = Color.white;
            ColorShowingInterval -= Time.deltaTime;

            if (ColorShowingInterval <= 0)
            {
                DamageColorShowing = false;
                ColorShowingInterval = 0.2f;
                GetComponent<SkinnedMeshRenderer>().material.color = OriginalColor;
            }
        }
    }
    void StackStatus()
    {
        Burningbar.fillAmount = BurningResistanceCount / BurningResistance;
        if (Burningbar.fillAmount == 1)
        {
            Burning = true;
        }
        Poisonbar.fillAmount = PoisonResistanceCount / PoisonResistance;
        if (Poisonbar.fillAmount == 1&&Trigger_2==false)
        {
            PoisonedCount++;
            Trigger_2 = true;
        }
        Regenbar.fillAmount = RegenResistanceCount / RegenResistance;
        if (Regenbar.fillAmount == 1)
        {
            Regen = true;
        }
        Stunbar.fillAmount = StunResistanceCount / StunResistance;
        if (Stunbar.fillAmount == 1)
        {
            Stunned = true;
        }
    }
    void OnBurning()
    {
        if (CurrentBurningDamage < 1)
        {
            Burning = false;
            Burningbar.fillAmount = 0;
            BurningAT = 0;
            BurningResistanceCount = 0;
        }
        if (Burning)
        {
            if (!BurningSoundPlayed)
            {
                GameObject.Find("BurningSound").GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sound/Burning"));
                BurningSoundPlayed = true;
            }
            VFX.transform.GetChild(1).gameObject.SetActive(true);
            BurnDamageDisplay.enabled = true;
            BurnDamageDisplay.text = "-" + ((int)CurrentBurningDamage).ToString();
            BurningAT += Time.deltaTime;
            if (BurningAT >= BattleManager.instance.BurningInterval)
            {
                GotDamageInAT = false;
                BurningAT = 0;
            }
            if (GotDamageInAT == false)
            {
                CurrentHP -= CurrentBurningDamage;
                GotDamageInAT = true;
                if (CurrentBurningDamage >= 1)
                {
                    CurrentBurningDamage = CurrentBurningDamage / 2;

                }
            }
        }
        if (!Burning)
        {
            BurningSoundPlayed = false;
            CurrentBurningDamage = BattleManager.instance.StartBurningDamage;
            VFX.transform.GetChild(1).gameObject.SetActive(false);
            BurnDamageDisplay.enabled = false;
         
        }
        
    }
    void OnPoisoning()
    {

        if (PoisonedCount > 0)
        {
            if (!PoisonSoundPlayed)
            {
                GameObject.Find("PoisonSound").GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sound/Poison"));
                PoisonSoundPlayed = true;
            }
            VFX.transform.GetChild(2).gameObject.SetActive(true);
            Trigger = false;
            PoisonDamageDisplay.text =(- PoisonedCount).ToString();
            PoisonedAT += Time.deltaTime;
            if (PoisonedAT >= BattleManager.instance.PoisonedInterval)
            {
                CurrentHP -= PoisonedCount * BattleManager.instance.PoisonDamage;
                PoisonedAT = 0;
            }
        }
    }
    void OnRegening()
    {
        if (Regen)
        {
            if (PoisonedCount > 0)//release the poison first
            {
                if (!RegenSoundPlayed)
                { 
                    GameObject.Find("RegenSound").GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sound/Regen"));
                    RegenSoundPlayed = true;
                }
                PoisonedCount--;
                RegenResistanceCount = 0;
                LeftDuration = Duration;
                Regen = false;
                RegenSoundPlayed = false;
            }
            else//heal
            {
                VFX.transform.GetChild(3).gameObject.SetActive(true);
                Regenbar.fillAmount = LeftDuration / Duration;
                RegenAT += Time.deltaTime;
                if (RegenAT >= BattleManager.instance.RegenInterval && LeftDuration > 0 && CurrentHP < maxHP)
                {
                    if (!RegenSoundPlayed)
                    {
                        GameObject.Find("RegenSound").GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sound/Regen"));
                        RegenSoundPlayed = true;
                    }
                    CurrentHP += BattleManager.instance.RegenDamage+ 0.2f * RegenResistance;
                    RegenAT = 0;
                    LeftDuration--;
                }
                if (LeftDuration == 0 || CurrentHP >= maxHP)
                {
                    VFX.transform.GetChild(3).gameObject.SetActive(false);
                    LeftDuration = Duration;
                    RegenResistanceCount = 0;
                    Regen = false;
                    RegenSoundPlayed = false;
                }
            }
        }
    }
    void OnStunning()
    {
        if (Stunned)
        {
            if (!StunSoundPlayed)
            { 
                GameObject.Find("StunSound").GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sound/Stun"));
                StunSoundPlayed = true;
            }
            VFX.transform.GetChild(4).gameObject.SetActive(true);
            StunAT += Time.deltaTime;
            Stunbar.fillAmount = (BattleManager.instance.StunInterval -StunAT) / BattleManager.instance.StunInterval;
            if (StunAT >= BattleManager.instance.StunInterval)
            {
                VFX.transform.GetChild(4).gameObject.SetActive(false);
                StunAT = 0;
                StunResistance += StunResistance * 0.25f;
                Stunned = false;
                StunSoundPlayed = false;
                StunResistanceCount = 0;
            }
        }
    }
    void StopBurning()
    {
        Burning = false;
        CurrentBurningDamage = BattleManager.instance.StartBurningDamage;
        VFX.transform.GetChild(1).gameObject.SetActive(false);
        BurnDamageDisplay.enabled = false;
    }
    void StopPoisoning()
    {
        
        if (PoisonedCount <= 0)
        {
            VFX.transform.GetChild(2).gameObject.SetActive(false);
            PoisonDamageDisplay.text = "";
            if (Trigger == false)
            {
                PoisonResistanceCount = 0;
                Trigger = true;
            }
        }
    }
    void StopRegening()
    {
        VFX.transform.GetChild(3).gameObject.SetActive(false);
        Regen = false;
        RegenResistanceCount = 0;
        LeftDuration = Duration;
    }
    private void OnCollisionEnter(Collision collider)
    {
        GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sound/Hit"));
        if (collider.gameObject.tag == "Dish" && isAlive)
        {
            VFX.transform.GetChild(0).position = collider.GetContact(0).point;
            VFX.transform.GetChild(0).GetComponent<VisualEffect>().Play();
            StatusFromDish = new List<string>(collider.gameObject.GetComponent<DishStatus>().Status);
            StatusValue = new List<float>(collider.gameObject.GetComponent<DishStatus>().StatusValue);          
            for(int i = 0; i < 3; i++)
            {
                if (StatusFromDish[i] == StatusOnEnemies[0])//0,0
                {
                    BurningResistanceCount += StatusValue[i];
                    continue;
                }
                if (StatusFromDish[i] == StatusOnEnemies[1])//0,1
                {
                    PoisonResistanceCount += StatusValue[i];
                    continue;
                }
                if (StatusFromDish[i] == StatusOnEnemies[2])//0,2
                {
                    RegenResistanceCount += StatusValue[i];
                    continue;
                }
                if (StatusFromDish[i] == StatusOnEnemies[3])//1,3
                {
                    StunResistanceCount += StatusValue[i];
                    continue;
                }
                if (StatusFromDish[i] == StatusOnEnemies[4])//0,4
                {
                    Defense += StatusValue[i];
                    continue;
                }
                if (StatusFromDish[i] == StatusOnEnemies[5])//0,5
                {
                    Attack += StatusValue[i];
                    continue;
                }
                if (StatusFromDish[i] == StatusOnEnemies[6])
                {
                    AttackInterval += StatusValue[i];
                    continue;
                }
            }
            if (Burning == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (StatusFromDish[i] == StatusOnEnemies[0])//0,0
                    {
                        CurrentBurningDamage += BattleManager.instance.StartBurningDamage;
                        if (!BurningSoundPlayed)
                        {
                            GameObject.Find("BurningSound").GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sound/Burning"));
                            BurningSoundPlayed = true;
                        }
                    }
                }
            }
            if (PoisonedCount >= 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (StatusFromDish[i] == StatusOnEnemies[1])//0,0
                    {
                        PoisonedCount++;
                        if (!PoisonSoundPlayed)
                        {
                            GameObject.Find("PoisonSound").GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sound/Poison"));
                            PoisonSoundPlayed = true;
                        }
                    }
                }
            }
            Destroy(collider.gameObject.transform.parent.gameObject);
        }
    }
    void BarDispaly()
    {
        Healthbar.fillAmount = CurrentHP / maxHP;
        if (Healthbar.fillAmount <= 0.2)
        {
            if (PlayedHealthWarning == false)
            {
                 GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sound/Health_Warning"));
                PlayedHealthWarning = true;
            }
        }
        Attackbar.fillAmount = AttackAT / AttackInterval;
    }
    void BarHide()
    {
        Attackbar.fillAmount = 0;
        Burningbar.fillAmount = 0;
        Poisonbar.fillAmount = 0;
    }
}
