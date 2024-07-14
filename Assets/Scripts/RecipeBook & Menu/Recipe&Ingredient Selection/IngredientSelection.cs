using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientSelection : MonoBehaviour
{
    public GameObject HWFirst;
    public GameObject HWSecond;
    public GameObject HWThird;

    public Image FirstIngredientImage;

    public Image SecondIngredientImage;

    public Image ThirdIngredientImage;

    private PersistentItemsScript PI;

    public Sprite Toast;
    public Sprite Loaf;
    public Sprite Tomato;
    public Sprite Carrot;
    public Sprite Chili;
    public Sprite Onion;
    public Sprite Beef;
    public Sprite Ham;
    public Sprite Champignon;
    public Sprite DeathCap;

    void Start()
    {
        PI = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>();
    }

    //Skewer Fungi, meat, veg
    public void SetSkewerFirstChampignon()
    {
        HWFirst.SetActive(false);

        FirstIngredientImage.sprite = Champignon;
        PI.Skewer_1 = "Champignon";
    } //done
    public void SetSkewerFirstDeathCap()
    {
        HWFirst.SetActive(false);

        FirstIngredientImage.sprite = DeathCap;
        PI.Skewer_1 = "DeathCap";
    } //done
    public void SetSkewerSecondBeef()
    {
        HWSecond.SetActive(false);

        SecondIngredientImage.sprite = Beef;
        PI.Skewer_2 = "Beef";
    } //done
    public void SetSkewerSecondHam()
    {
        HWSecond.SetActive(false);

        SecondIngredientImage.sprite = Ham;
        PI.Skewer_2 = "Ham";
    } //done
    public void SetSkewerThirdTomato()
    {
        HWThird.SetActive(false);

        ThirdIngredientImage.sprite = Tomato;
        PI.Skewer_3 = "Tomato";
    } //done
    public void SetSkewerThirdCarrot()
    {
        HWThird.SetActive(false);

        ThirdIngredientImage.sprite = Carrot;
        PI.Skewer_3 = "Carrot";
    } //done

    //Salad Bread, Fungi, veg
    public void SetSaladFirstLoaf()
    {
        HWFirst.SetActive(false);

        FirstIngredientImage.sprite = Loaf;
        PI.Salad_1 = "Loaf";
    } //done
    public void SetSaladFirstToast()
    {
        HWFirst.SetActive(false);

        FirstIngredientImage.sprite = Toast;
        PI.Salad_1 = "Toast";
    } //done
    public void SetSaladSecondChampignon()
    {
        HWSecond.SetActive(false);

        SecondIngredientImage.sprite = Champignon;
        PI.Salad_2 = "Champignon";
    } //done
    public void SetSaladSecondDeathCap()
    {
        HWSecond.SetActive(false);

        SecondIngredientImage.sprite = DeathCap;
        PI.Salad_2 = "DeathCap";
    } //done
    public void SetSaladThirdTomato()
    {
        HWThird.SetActive(false);

        ThirdIngredientImage.sprite = Tomato;
        PI.Salad_3 = "Tomato";
        
    } //done
    public void SetSaladThirdCarrot()
    {
        HWThird.SetActive(false);

        ThirdIngredientImage.sprite = Carrot;
        PI.Salad_3 = "Carrot";
    } //done

    //Soup Aromatic, fungi, veg
    public void SetSoupFirstChili()
    {
        HWFirst.SetActive(false);

        FirstIngredientImage.sprite = Chili;
        PI.Soup_1 = "Chili";
    } //done
    public void SetSoupFirstOnion()
    {
        HWFirst.SetActive(false);

        FirstIngredientImage.sprite = Onion;
        PI.Soup_1 = "Onion";
    } //done
    public void SetSoupSecondChampignon()
    {
        HWSecond.SetActive(false);

        SecondIngredientImage.sprite = Champignon;
        PI.Soup_2 = "Champignon";
    } //done
    public void SetSoupSecondDeathCap()
    {
        HWSecond.SetActive(false);

        SecondIngredientImage.sprite = DeathCap;
        PI.Soup_2 = "DeathCap";
    } //done
    public void SetSoupThirdTomato()
    {
        HWThird.SetActive(false);

        ThirdIngredientImage.sprite = Tomato;
        PI.Soup_3 = "Tomato";
    } //done
    public void SetSoupThirdCarrot()
    {
        HWThird.SetActive(false);

        ThirdIngredientImage.sprite = Carrot;
        PI.Soup_3 = "Carrot";
    } //Done

    //Stew Aromatic, fungi, meat
    public void SetStewFirstChili()
    {
        HWFirst.SetActive(false);

        FirstIngredientImage.sprite = Chili;
        PI.Stew_1 = "Chili";
    } //done
    public void SetStewFirstOnion()
    {
        HWFirst.SetActive(false);

        FirstIngredientImage.sprite = Onion;
        PI.Stew_1 = "Onion";
    } //done
    public void SetStewSecondChampignon()
    {
        HWSecond.SetActive(false);

        SecondIngredientImage.sprite = Champignon;
        PI.Stew_2 = "Champignon";
    } //done
    public void SetStewSecondDeathCap()
    {
        HWSecond.SetActive(false);

        SecondIngredientImage.sprite = DeathCap;
        PI.Stew_2 = "DeathCap";
    } //done
    public void SetStewThirdBeef()
    {
        HWThird.SetActive(false);

        ThirdIngredientImage.sprite = Beef;
        PI.Stew_3 = "Beef";
    } //done
    public void SetStewThirdHam()
    {
        HWThird.SetActive(false);

        ThirdIngredientImage.sprite = Ham;
        PI.Stew_3 = "Ham";
    } //done

    //Panini Aromatic, bread, meat
    public void SetPaniniFirstChili()
    {
        HWFirst.SetActive(false);

        FirstIngredientImage.sprite = Chili;
        PI.Panini_1 = "Chili";
    } //done
    public void SetPaniniFirstOnion()
    {
        HWFirst.SetActive(false);

        FirstIngredientImage.sprite = Onion;
        PI.Panini_1 = "Onion";
    } //done
    public void SetPaniniSecondLoaf()
    {
        HWSecond.SetActive(false);

        SecondIngredientImage.sprite = Loaf;
        PI.Panini_2 = "Loaf";
    } //done
    public void SetPaniniSecondToast()
    {
        HWSecond.SetActive(false);

        SecondIngredientImage.sprite = Toast;
        PI.Panini_2 = "Toast";
    } //done
    public void SetPaniniThirdHam()
    {
        HWThird.SetActive(false);

        ThirdIngredientImage.sprite = Ham;
        PI.Panini_3 = "Ham";
    } //done
    public void SetPaniniThirdBeef()
    {
        HWThird.SetActive(false);

        ThirdIngredientImage.sprite = Beef;
        PI.Panini_3 = "Beef";
    } //done

    //Bruschetta Aromatic, bread, vegetable
    public void SetBruschettaFirstChili()
    {
        HWFirst.SetActive(false);

        FirstIngredientImage.sprite = Chili;
        PI.Bruschetta_1 = "Chili";
    } //done
    public void SetBruschettaFirstOnion()
    {
        HWFirst.SetActive(false);

        FirstIngredientImage.sprite = Onion;
        PI.Bruschetta_1 = "Onion";
    } //done
    public void SetBruschettaSecondLoaf()
    {
        HWSecond.SetActive(false);

        SecondIngredientImage.sprite = Loaf;
        PI.Bruschetta_2 = "Loaf";
    } //done
    public void SetBruschettaSecondToast()
    {
        HWSecond.SetActive(false);

        SecondIngredientImage.sprite = Toast;
        PI.Bruschetta_2 = "Toast";
    } //done
    public void SetBruschettaThirdCarrot()
    {
        HWThird.SetActive(false);

        ThirdIngredientImage.sprite = Carrot;
        PI.Bruschetta_3 = "Carrot";
    } //done
    public void SetBruschettaThirdTomato()
    {
        HWThird.SetActive(false);

        ThirdIngredientImage.sprite = Tomato;
        PI.Bruschetta_3 = "Tomato";
    } //done
}
