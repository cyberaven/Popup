using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{    
    private void Start()
    {
        GameObject.Find("PopupPanel(Clone)").transform.SetParent(this.transform);
    }
}
