using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCardSO : MonoBehaviour
{
    public CardSO displayCard; // a card scriptable object 


    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public TMP_Text scoreText;
    public TMP_Text costText;

    // Start is called before the first frame update
    void Start()
    {
        // get the card variables to be displayed 
        //id = displayCard.id; //would need this if you wanted to display the id of card somewhere on it
        nameText.text = " " + displayCard.cardName; ;
        costText.text = " " + displayCard.cardCost.ToString();
        scoreText.text = " " + displayCard.cardScore.ToString();
        descriptionText.text = "" + displayCard.cardDescription;


    }

    // Update is called once per frame
    void Update()
    {
        // Code to display cards continuously as they update? 

    }
}


