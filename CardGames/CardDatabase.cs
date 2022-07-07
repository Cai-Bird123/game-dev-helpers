using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<CardObject> cardList = new List<CardObject>(); //list of CardObjects 

    void Awake()
    {
        //vars that are needed to construct items on cardlist:  int Id, string CardName, string CardDescription, int CardCost, int CardScore
        // eventually we can take this from an actual database at that point we'd want 2 functions here - retrieve data from db and then construct card list 
        cardList.Add(new CardObject(0, "Red1", "this is Red1", 1, 1));
        cardList.Add(new CardObject(1, "Red2", "this is Red2", 2, 2));
        cardList.Add(new CardObject(2, "Red3", "this is Red3", 3, 3));
        cardList.Add(new CardObject(3, "Red4", "this is Red4", 4, 4));
    }
}
