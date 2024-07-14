using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{
    public GameObject ExclamationMark;
    public GameObject[] Dialogue;
    private AudioSource SpokenDialogue;
    public AudioClip[] DialogueClips;

    private bool DialogueDone = false;

    private PersistentItemsScript PI;
    private int RoundCounter;
    
    void Start()
    {
        PI = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>();
        RoundCounter = PlayerPrefs.GetInt("RoundCounter", 1);

        if (Dialogue[/*PI.*/RoundCounter - 1] != null && DialogueDone == false/* && DialogueClips[PI.RoundCounter - 1] != null*/)
        {
            ExclamationMark.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (Dialogue[/*PI.*/RoundCounter - 1] != null/* && DialogueClips[PI.RoundCounter - 1] != null*/ && PI.MenuOpen == false)
        {
            for (int i = 0; i < /*PI.*/RoundCounter; i++)
            {
                if (i == /*PI.*/RoundCounter - 1)
                {
                    if (Dialogue[i].activeSelf != true)
                    {
                        Dialogue[i].SetActive(true);
                        //SpokenDialogue.clip = DialogueClips[i];
                        //SpokenDialogue.Play();
                        ExclamationMark.SetActive(false);
                        //StartCoroutine("StopPlay", i);
                    }
                    else
                    {
                        Dialogue[i].SetActive(false);
                    }
                }
            }
        }
    }

    private IEnumerator StopPlay (int Round)
    {
        yield return new WaitForSeconds(SpokenDialogue.clip.length);
        Dialogue[Round].SetActive(false);
    }
}
