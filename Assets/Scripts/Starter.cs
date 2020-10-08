﻿using System;
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

    private void OnEnable()
    {
        BundleLoad.BundleInstantiateEvent += LoadLobySceneEvent;
    }
    private void OnDisable()
    {
        BundleLoad.BundleInstantiateEvent -= LoadLobySceneEvent;
    }


    private void Start()
    {
        //загружаем бандл и инстантируем.
        BundleLoad = Instantiate(BundleLoadPrefab);
        BundleLoad.LoadBundle(BundleURL, AssetName, Version);
    }

    void LoadLobySceneEvent()
    {
        //переключаемся на сцену лобби.
        SceneManager.LoadScene("LobyScene");        
    }


}
