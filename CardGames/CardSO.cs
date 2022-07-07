using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Create New Card")]
public class CardSO : ScriptableObject
{
    // an alternative way to generate a card (as opposed to using a factory class as earlier)
    // we can create a scriptable ob, this will create a menu when u right click in the assets folders 
    // we'd need to change DisplayCard class to take the SO as input rather than output from CardObject factory   public int id; // the database id of the card

    public int id;
    public string cardName;
    public string cardDescription;
    public int cardCost; // how many resources 
    public int cardScore; // how many points are rewarded for playing this card
    // add other variables on your card as desired 

}
