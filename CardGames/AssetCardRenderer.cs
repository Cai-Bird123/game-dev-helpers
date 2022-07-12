using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

// holds the refs to all the Text, Images on the card
public class AssetCardRenderer : MonoBehaviour
{

    public CardSOAsset cardAsset;
    public AssetCardRenderer PreviewManager;
    [Header("Text Component References")]
    public GameObject NameText;
    public GameObject CostText;
    public GameObject DescriptionText;
    public GameObject ScoreText;

    [Header("GameObject References")]
    public GameObject CostIcon;
    public GameObject ScoreIcon;
    [Header("Image References")]
    public SpriteRenderer CardTopRibbonImage;
    public SpriteRenderer CardBodyImage;
    public SpriteRenderer CardFaceImage;
    public GameObject CardFaceGlowImage;

    void Awake()
    {
        Debug.Log("found card renderer");
        if (cardAsset != null)
            ReadCardFromAsset();
        else
        {
            Debug.Log("card asset is null");
        }
        // get refs to objects 
    }

    private bool canBePlayedNow = false;
    public bool CanBePlayedNow
    {
        get
        {
            return canBePlayedNow;
        }

        set
        {
            canBePlayedNow = value;

            CardFaceGlowImage.SetActive(value);
        }
    }

    public void ReadCardFromAsset()
    {
        Debug.Log("in read card from asset");


        // 1) apply tint
        if (cardAsset.themeColor != null)
        {

            if (cardAsset.themeColor == "Red")
            {
                CardTopRibbonImage.color = Color.red;
            }

            if (cardAsset.themeColor == "Blue")
            {
                CardTopRibbonImage.color = Color.blue;
            }

            if (cardAsset.themeColor == "Green")
            {
                CardTopRibbonImage.color = Color.green;
            }

            if (cardAsset.themeColor == "Yellow")
            {
                CardTopRibbonImage.color = Color.yellow;
            }

            if (cardAsset.themeColor == "Purple")
            {
                CardTopRibbonImage.color = Color.magenta;
            }


        }
        else
        {
            CardTopRibbonImage.color = Color.white;
        }

        /*
        {
            CardBodyImage.color = GlobalSettings.Instance.CardBodyStandardColor;
            CardFaceFrameImage.color = Color.white;
            CardTopRibbonImage.color = GlobalSettings.Instance.CardRibbonsStandardColor;
            CardLowRibbonImage.color = GlobalSettings.Instance.CardRibbonsStandardColor;
        }
                */


        // universal actions for any Card
        // 2) add card name

        Debug.Log(cardAsset.cardName);
        NameText.GetComponent<TMP_Text>().SetText(cardAsset.cardName);
        // 3) add cost text        
        CostText.GetComponent<TMP_Text>().SetText(cardAsset.cardCost.ToString());
        // 4) add Score text
        ScoreText.GetComponent<TMP_Text>().SetText(cardAsset.cardScore.ToString());
        //ScoreText.text = cardAsset.cardScore.ToString();

        // 4) add description
        DescriptionText.GetComponent<TMP_Text>().SetText(cardAsset.cardDescription);
        //DescriptionText.text = cardAsset.cardDescription;
        // 5) Change the card graphic sprite
        CardFaceImage.GetComponent<SpriteRenderer>().sprite = cardAsset.spriteImage;



        if (PreviewManager != null)
        {
            // this is a card and not a preview
            // Preview GameObject will have OneCardManager as well, but PreviewManager should be null there
            PreviewManager.cardAsset = cardAsset;
            PreviewManager.ReadCardFromAsset();
        }
    }
}
