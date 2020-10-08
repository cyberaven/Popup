using UnityEngine;
public class NewsPopupTransportContainer : MonoBehaviour
{
    public GameObject Popup;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }   
}
