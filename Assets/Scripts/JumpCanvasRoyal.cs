using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCanvasRoyal : MonoBehaviour
{

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

    public void JumpRoyal(string destinationRoyal)
    {
        CoinFlipRoyal(true);
        GameObject.Find("MainCameraRoyal").GetComponent<SoundManagerRoyal>().PlayClickRoyal();
        GameObject.Find("MainCameraRoyal").GetComponent<CanvasHolderRoyal>().MoveRoyal(destinationRoyal,false);
    }


    public void JumpRoyalLevel(int levelRoyal)
    {
        CoinFlipRoyal(true);
        GameObject.Find("GameCanvasRoyal").GetComponent<GameLogicRoyal>().pickedLevelRoyal = levelRoyal;
        JumpRoyal("gameRoyal");
    }


    public void JumpBackRoyal()
    {
        CoinFlipRoyal(true);
        GameObject.Find("MainCameraRoyal").GetComponent<SoundManagerRoyal>().PlayClickRoyal();
        GameObject.Find("MainCameraRoyal").GetComponent<CanvasHolderRoyal>().MoveBackRoyal();
    }

    public void JumpOKRoyal()
    {
        CoinFlipRoyal(true);
        GameObject.Find("MainCameraRoyal").GetComponent<SoundManagerRoyal>().PlayClickRoyal();
        GameObject.Find("MainCameraRoyal").GetComponent<CanvasHolderRoyal>().MoveToOKRoyal();
    }

    public void CloseRoyal()
    {
        CoinFlipRoyal(true);
        AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        activity.Call<bool>("moveTaskToBack", true);
    }
}
