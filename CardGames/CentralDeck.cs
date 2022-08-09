using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralDeck : MonoBehaviour
{
    [SerializeField]
    public List<CardSOAsset> listOfCardsInDeck = new List<CardSOAsset>();
    public List<CardSOAsset> shuffledDeck;
    public List<CardSOAsset> unShuffledDeck;
    public PlayerManager playerManager;


    void Start()
    {


    }

    void OnMakeDeckBtnClick()
    {
        Debug.Log("clicked instantiate Deck");
        InstantiateCentralDeck();
    }



    public void InstantiateCentralDeck()
    {
        // constructor to instantiate the deck object when required, then shuffle it 
        for (int i = 0; i < listOfCardsInDeck.Count; i++)
        {
            unShuffledDeck.Add(listOfCardsInDeck[i]);
            Debug.Log("adding card to central deck " + listOfCardsInDeck[i].cardName);
        }
        shuffledDeck = ShuffleListOfCardsIntoFreshDeck(unShuffledDeck);
    }





    public List<CardSOAsset> ShuffleListOfCardsIntoFreshDeck(List<CardSOAsset> unShuffledDeck)
    {
        // Shuffle using Fisher Yates algo Knuth variation https://exceptionnotfound.net/understanding-the-fisher-yates-card-shuffling-algorithm/
        // takes an empty deck and shuffles it 
        // make list of unique values that will act as indicies to be randomly chosen 
        List<int> uniqueNumbers = new List<int>();
        // make new list to be returned as shuffled deck
        List<CardSOAsset> shuffledDeck = new List<CardSOAsset>();
        Debug.Log("Shuffling");
        // make unique indicies 
        for (int i = 0; i < unShuffledDeck.Count; i++)
        {
            uniqueNumbers.Add(i);
        }
        // start shuffle
        for (int i = 0; i < unShuffledDeck.Count; i++)
        {
            // pick random index from uniqueNUmbers
            int ranNumIndex = uniqueNumbers[Random.Range(0, uniqueNumbers.Count)];
            Debug.Log(ranNumIndex.ToString());
            shuffledDeck.Add(unShuffledDeck[ranNumIndex]); // grab the card from the unShuffled deck at index and add to shuffled deck
            uniqueNumbers.Remove(ranNumIndex); // remove the used index as we do not want duplicates 
        }
        return shuffledDeck;

    }



    public List<CardSOAsset> ShuffleExistingDeck(List<CardSOAsset> ShuffledDeck)
    {
        // Shuffle using Fisher Yates algo Knuth variation https://exceptionnotfound.net/understanding-the-fisher-yates-card-shuffling-algorithm/
        // takes the current deck and shuffles it 
        // make list of unique values that will act as indicies to be randomly chosen 
        List<int> uniqueNumbers = new List<int>();
        // make new list to be returned as shuffled deck
        List<CardSOAsset> tempShuffledDeck = new List<CardSOAsset>();
        Debug.Log("Shuffling");
        // make unique indicies 
        for (int i = 0; i < ShuffledDeck.Count; i++)
        {
            uniqueNumbers.Add(i);
        }
        // start shuffle
        for (int i = 0; i < ShuffledDeck.Count; i++)
        {
            // pick random index from uniqueNUmbers
            int ranNumIndex = uniqueNumbers[Random.Range(0, uniqueNumbers.Count)];
            Debug.Log(ranNumIndex.ToString());
            tempShuffledDeck.Add(ShuffledDeck[ranNumIndex]); // grab the card from the unShuffled deck at index and add to shuffled deck
            uniqueNumbers.Remove(ranNumIndex); // remove the used index as we do not want duplicates 
        }
        return shuffledDeck;

    }





    void DealCardToPlayer(PlayerManager playerManager)
    {
        //TODO make deal logic 
        Debug.Log("Dealing");

    }
}
