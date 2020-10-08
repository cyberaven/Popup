using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupPanel : MonoBehaviour
{    
    [SerializeField] private Button PurchaseButton;
    private Text PurchaseButtonText;
    [SerializeField] private Image BgImage;
    [SerializeField] private Text DescriptionText;
    [SerializeField] private Text TitleText;

    
    private void Awake()
    {
        PurchaseButton = PurchaseButton.GetComponent<Button>();
        PurchaseButtonText = PurchaseButton.GetComponentInChildren<Text>();
        BgImage = BgImage.GetComponent<Image>();
        DescriptionText = DescriptionText.GetComponent<Text>();
        TitleText = TitleText.GetComponent<Text>();    
    }

    public void Show(string descriptionText, string titleText, string purchaseButtonText, Sprite bgImage)
    {
        DescriptionText.text = descriptionText;
        TitleText.text = titleText;       
        PurchaseButtonText.text = purchaseButtonText;
        BgImage.sprite = bgImage;
    }   
    public void Close() //Кнопка CloseButton 
    {
        gameObject.SetActive(false);
    }
    public void Purchase()  //Кнопка PurchaseButton 
    {
        throw new Exception("PopupPanel Purchase Error");
    }
}
