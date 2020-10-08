using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{    
    private NewsPopupTransportContainer NewsPopupTransportContainer;

    private void Start()
    {
        NewsPopupTransportContainer =  GameObject.Find("NewsPopupTransportContainer(Clone)").GetComponent<NewsPopupTransportContainer>();
        GameObject newsPopup = NewsPopupTransportContainer.Popup;
        Instantiate(newsPopup, transform);
    }
}
