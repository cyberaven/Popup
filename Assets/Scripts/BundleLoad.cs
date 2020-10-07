using System;
using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class BundleLoad : MonoBehaviour 
{
    private string BundleURL;
    private string AssetName;
    private int Version;

    public delegate void BundleInstantiate();
    public static event BundleInstantiate BundleInstantiateEvent;


    public void LoadBundle(string bundleURL, string assetName, int version)
    {
        BundleURL = bundleURL;
        AssetName = assetName;
        Version = version;
        
        WWW www = new WWW(BundleURL);

        StartCoroutine (DownloadBundle(www));
    }


    IEnumerator DownloadBundle (WWW www)
    {
        yield return www;

        while(www.isDone == false)
        {
            yield return null;
        }

        AssetBundle bundle = www.assetBundle;

        if(www.error == null)
        {
            GameObject obj = (GameObject)bundle.LoadAsset(AssetName);
            Instantiate(obj);
            BundleInstantiateEvent?.Invoke();           
        }
        else
        {
            Debug.Log("www.error: " + www.error);
        }

    } 
    
}
