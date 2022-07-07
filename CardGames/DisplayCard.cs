using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayCard : MonoBehaviour
{
    public List<CardObject> displayCard = new List<CardObject>();
    public int displayId;

    public int id; // the database id of the card
    public string cardName;
    public string cardDescription;
    public int cardCost; // how many resources 
    public int cardScore; // how many points are rewarded for playing this card
    // add other variables on your card as desired 

    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public TMP_Text scoreText;
    public TMP_Text costText;

    // Start is called before the first frame update
    void Start()
    {
        displayCard[0] = CardDatabase.cardList[displayId];

    }

    // Update is called once per frame
    void Update()
    {
        // get the card variables to be displayed 
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cardCost = displayCard[0].cardCost;
        cardScore = displayCard[0].cardScore;
        cardDescription = displayCard[0].cardDescription;

        nameText.text = " " + cardName;
        costText.text = " " + cardCost.ToString();
        scoreText.text = " " + cardScore.ToString();
        descriptionText.text = "" + cardDescription;

    }
}
