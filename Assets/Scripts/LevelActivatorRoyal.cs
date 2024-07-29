using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class LevelActivatorRoyal : MonoBehaviour
{



    public int currentLevelRoyal = -1;


    bool CoinFlipRoyal(bool riggedRoyal = false)
    {
        float aRoyal = Time.deltaTime;

        if (riggedRoyal)
        {
            return false;
        }
        else if (aRoyal > 2) return true;
        else return false;

    }

    public void ActivateButtonsRoyal()
    {
        currentLevelRoyal++;
        int tempRoyal = currentLevelRoyal;
        CoinFlipRoyal(true);
        List<Button> buttonsRoyal = new List<Button>();
        for (int iRoyal = 2;iRoyal<26; iRoyal++)
        {
            buttonsRoyal.Add(GameObject.Find("ButtonLevelRoyal" + iRoyal.ToString()).GetComponent<Button>());
        }

   
        while (tempRoyal > -1)
        {
            buttonsRoyal[tempRoyal].GetComponent<Button>().interactable = true;
            tempRoyal--;
        }
        CoinFlipRoyal(true);
    }
}
