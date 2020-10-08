using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Starter : MonoBehaviour
{    
    [SerializeField] private BundleLoad BundleLoadPrefab;
    private BundleLoad BundleLoad;
    [SerializeField] private string BundleURL = "https://drive.google.com/uc?export=download&id=1xLY2IRLp1XaHGXp70eTpPW-cinlnW6rW";
    [SerializeField] private string AssetName = "PopupPanel";
    [SerializeField] private int Version = 0;

    [SerializeField] private NewsPopupTransportContainer NewsPopupTransportContainer;

    private void OnEnable()
    {
        BundleLoad.BundleLoadEndEvent += BundleLoadEnd;        
    }
    private void OnDisable()
    {
        BundleLoad.BundleLoadEndEvent -= BundleLoadEnd;
    }


    private void Start()
    {
        //создаем контайнер для передачи между сценами
        NewsPopupTransportContainer = Instantiate(NewsPopupTransportContainer);

        //загружаем бандл и инстантируем.
        BundleLoad = Instantiate(BundleLoadPrefab);
        BundleLoad.LoadBundle(BundleURL, AssetName, Version);

        //тут будем читать джсон и его даные записывать в контейнер.
    }

    private void BundleLoadEnd(GameObject obj)
    {        
        NewsPopupTransportContainer.Popup = obj;      

        LoadLobySceneEvent();  
    }

    void LoadLobySceneEvent()
    {
        //переключаемся на сцену лобби.
        SceneManager.LoadScene("LobyScene");        
    }


}
