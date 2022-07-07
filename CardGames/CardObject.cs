using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;
[System.Serializable]

public class CardObject
{
    /// <summary>
    /// declaring variables 
    /// </summary>
    public int id; // the database id of the card
    public string cardName;
    public string cardDescription;
    public int cardCost; // how many resources 
    public int cardScore; // how many points are rewarded for playing this card
    // add other variables on your card as desired 

    public CardObject()
    {

    }

    /// this is the constructor function that will take the variables fromt he database and create these CardObjects 
    public CardObject(int Id, string CardName, string CardDescription, int CardCost, int CardScore)
    {
        id = Id;
        cardName = CardName;
        cardDescription = CardDescription;
        cardCost = CardCost;
        cardScore = CardScore;

    }


    // Start is called before the first frame update
    void Start()
    {
        // bring in hand vis

    }

    // Update is called once per frame
    void Update()
    {

    }

    //set card info



    //enable glow

    //enable glow (

    //disable glow

    // set interactacble (bool) to check if one can interact (e.g only onwn cards)


    // on mouse enter, if interactable, highlight, unhighlight other cards 

    // on mouse exit, unhighlight 

    // highlight the card 


    // reset; move back to pos, unrotate, reset rotation etc
}
