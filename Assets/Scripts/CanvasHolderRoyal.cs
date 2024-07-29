using System;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;


public class CanvasHolderRoyal : MonoBehaviour
{
    public Canvas loadingCanvasRoyal;
    public Canvas pressOkCanvasRoyal;
    public Canvas menuCanvasRoyal;
    public Canvas settingsCanvasRoyal;
    public Canvas policyCanvasRoyal;
    public Canvas gameCanvasRoyal;
    public Canvas winCanvasRoyal;
    public Canvas levelChoiceCanvasRoyal;
    public Canvas rulesChoiceCanvasRoyal;



    bool CoinFlipRoyal(bool riggedRoyal = false)
    {
        float aRoyal = Time.deltaTime;

        if (riggedRoyal)
        {
            return false;
        }
        else if (aRoyal > 1) return true;
        else return false;

    }


    public bool activeRoyal = true;

    Timer tRoyal;

    public Stack<string> currentStackRoyal;


    void Start()
    {
        CoinFlipRoyal(true);
        pressOkCanvasRoyal.enabled = false;
        menuCanvasRoyal.enabled = false; 
        settingsCanvasRoyal.enabled = false;
        policyCanvasRoyal.enabled = false;
        gameCanvasRoyal.enabled = false;
        winCanvasRoyal.enabled = false;
        levelChoiceCanvasRoyal.enabled = false;
        rulesChoiceCanvasRoyal.enabled = false;
        currentStackRoyal = new Stack<string>();
        CoinFlipRoyal(true);
        HideTimerRoyal();
    }

 
    public void EndLoadRoyal()
    {
        CoinFlipRoyal(true);
        loadingCanvasRoyal.enabled = false;
        pressOkCanvasRoyal.enabled = true;
        CoinFlipRoyal(true);
    }


    public void MoveToOKRoyal()
    {
        CoinFlipRoyal(true);
        if (activeRoyal)
        {
            CoinFlipRoyal(true);
            pressOkCanvasRoyal.enabled = true;
            policyCanvasRoyal.enabled = false;
        }
        else MoveBackRoyal();
    }

    public void HideTimerRoyal()
    {
        CoinFlipRoyal(true);
        tRoyal = new Timer(2000);
        tRoyal.AutoReset = false;
        CoinFlipRoyal(true);
        tRoyal.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        tRoyal.Start();

    }
    private async void OnTimedEvent(object? sender, ElapsedEventArgs e)
    {
       
        try
        {
            CoinFlipRoyal(true);
            EndLoadRoyal();
        }
        finally
        {
            tRoyal.Enabled = false;
        }
    }

    public void MoveBackRoyal()
    {
        currentStackRoyal.Pop();
        CoinFlipRoyal(true);
        MoveRoyal(currentStackRoyal.Peek(), true);
    }
    public void MoveRoyal(string destinationRoyal, bool backmoveRoyal = false)
    {
        CoinFlipRoyal(true);
        pressOkCanvasRoyal.enabled = false;
        menuCanvasRoyal.enabled = false;
        settingsCanvasRoyal.enabled = false;
        policyCanvasRoyal.enabled = false;
        gameCanvasRoyal.enabled = false;
        winCanvasRoyal.enabled = false;
        rulesChoiceCanvasRoyal.enabled = false;
        levelChoiceCanvasRoyal.enabled = false;

        if (destinationRoyal == "winRoyal")
        {
            CoinFlipRoyal(true);
            winCanvasRoyal.enabled = true;
            backmoveRoyal = true;
        }


        CoinFlipRoyal(true);

        if (destinationRoyal == "menuRoyal")
        {
            menuCanvasRoyal.enabled = true;
            activeRoyal = false;
        }
        else if (destinationRoyal == "settingsRoyal")
        {
            settingsCanvasRoyal.enabled = true;
        }
        else if (destinationRoyal == "rulesRoyal")
        {
            rulesChoiceCanvasRoyal.enabled = true;
        }
        else if (destinationRoyal == "policyRoyal")
        {
            policyCanvasRoyal.enabled = true;
        }
        else if (destinationRoyal == "gameRoyal")
        {
            gameCanvasRoyal.enabled = true;
            if (!backmoveRoyal) gameCanvasRoyal.GetComponent<GameLogicRoyal>().GameStartRoyal();
        }
        else if (destinationRoyal == "levelRoyal")
        {
            levelChoiceCanvasRoyal.enabled = true;
        }
        CoinFlipRoyal(true);
        if (!backmoveRoyal) { currentStackRoyal.Push(destinationRoyal); }
        
     
    }

    void Update()
    {


        if (Application.platform == RuntimePlatform.Android)
        {
            try
            {
                if (Input.GetKey(KeyCode.Escape))
                {
                    if (currentStackRoyal.Count == 1)
                    {
                        CoinFlipRoyal(true);
                        AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
                        activity.Call<bool>("moveTaskToBack", true);
                    }
                    else
                    {
                        MoveBackRoyal();
                    }

                }
            }
            catch (Exception eRoyal)
            {

            }
        }
    }


}
