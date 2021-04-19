using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class TestAd : MonoBehaviour
{
    // Start is called before the first frame update

    Button btn_rew;
    string appid = "ca-app-pub-5968991614706710~3059258422";
    string bannerId = "ca-app-pub-3940256099942544/6300978111";
    string intersId = "ca-app-pub-3940256099942544/1033173712";
    string rewardId = "ca-app-pub-3940256099942544/5224354917";


    BannerView banner;
    InterstitialAd inters;
    RewardedAd reward;
    

    
    void Start()
    {
        Darkfeast.Log("start");
        btn_rew = gameObject.AddComponent<Button>();
        btn_rew.onClick.AddListener(Reward);

        MobileAds.Initialize(state =>
        {
            Debug.Log("init reward");
            //reward = new RewardedAd(rewardId);
             InitBanner();
        });

        //MobileAds.Initialize(appid);
       
    }


    void InitBanner()
    {
        banner = new BannerView(bannerId, AdSize.Banner, AdPosition.Bottom);
        banner.OnAdLoaded += BannerLoaded;
        banner.OnAdFailedToLoad += BannerFailed;

        ShowBanner();
    }

    void ShowBanner()
    {
        AdRequest request = new AdRequest.Builder().Build();
        banner.LoadAd(request);
    }

    void Reward()
    {
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.reward.LoadAd(request);
    }


    void BannerLoaded(object sender, EventArgs arg)
    {
        Darkfeast.Log("banner loaded");
    }

    void BannerFailed(object sender,AdFailedToLoadEventArgs arg)
    {
        Darkfeast.Log("banner err " + arg.Message);
    }


}
