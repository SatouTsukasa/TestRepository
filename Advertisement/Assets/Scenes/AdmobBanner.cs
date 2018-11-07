﻿using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds.Api;
using UnityEngine;
using System;

public class AdmobBanner : MonoBehaviour {

    private BannerView bannerView;
    
    public void Start()
    {
    #if UNITY_ANDROID
            //アプリID
                string appId = "ca-app-pub-3940256099942544~3347511713";
    #elif UNITY_IPHONE
                string appId = "ca-app-pub-3940256099942544~1458002511";
    #else
            string appId = "unexpected_platform";
    #endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        this.RequestBanner();
    }

    private void RequestBanner()
    {
    #if UNITY_ANDROID
            //広告ID
                string adUnitId = "ca-app-pub-3940256099942544/6300978111";
    #elif UNITY_IPHONE
                string adUnitId = "ca-app-pub-3940256099942544/2934735716";
    #else
            string adUnitId = "unexpected_platform";
    #endif

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

        bannerView.OnAdLoaded += HandleOnAdLoaded;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        //広告を表示する
        bannerView.Show();
    }
}
