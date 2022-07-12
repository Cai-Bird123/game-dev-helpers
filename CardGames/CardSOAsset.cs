using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum themeColor { Red, Blue, Green, Yellow, Purple }
public class CardSOAsset : ScriptableObject
{
    // an alternative way to generate a card (as opposed to using a factory class as earlier)
    // we can create a scriptable ob, this will create a menu when u right click in the assets folders 
    // we'd need to change DisplayCard class to take the SO as input rather than output from CardObject factory   public int id; // the database id of the card
    // add other variables on your card as desired 

    [Header("General Card info")]
    public AgentAsset agentAsset;
    public int id;
    public string cardName;
    public Sprite spriteImage;
    public string cardDescription;
    public bool unique; // some cards can only be present 1x 
    public string cardBehaviourScriptName; // name of the code used to drive this card 
    public string themeColor; // red for mil, blue for gods, yellow goverment, green merchant, purple special 
    public bool isAgent; // some cards are agents that will be hired at round start 



    [Header("Asset Card Info")]
    public int cardCost; // how many resources 
    public int cardScore; // how many points are rewarded for playing this card


    //[Header("Event Card Info")] // in later parts we'll want 
    //public string eventScriptName

}
