using System;

using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class GameLogicRoyal : MonoBehaviour
{

    public CellRoyal firstClickedRoyal;
    public bool boolFirstRoyal = false;

    public CellRoyal secondClickedRoyal;
    public bool boolSecondRoyal = false;
    System.Random rRoyal = new System.Random();

    bool checkValueRoyal = true;
    bool levelCanGrowRoual = true;

    public Sprite sprite1Royal;
    public Sprite sprite2Royal;
    public Sprite sprite3Royal;


    public Slider sliderRoyal1;
    public Slider sliderRoyal2;
    public Slider sliderRoyal3;

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

    public bool firstMoveFinishedRoyal =false;
    public bool secondMoveFinishedRoyal = false;


   
    bool destructionHappenedRoyal = false;

    public int pointsRoyal = 0;
    public int pointGoalRoyal = 25;
    public int pickedLevelRoyal = 0;
    bool pointCountRoyal = false;


    List<int> horizontal;
    List<int> vertical;

    public async Task TryCheckRoyal()
    {
        CoinFlipRoyal(true);

        for (int jRoyal = 1; jRoyal < 31; jRoyal++)
        {

            if (horizontal.Contains(jRoyal)){
                
                if ((GameObject.Find("GamePiece" + (jRoyal + 1).ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID() == GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID()) && (GameObject.Find("GamePiece" + (jRoyal - 1).ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID() == GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID()))
                {
                    if (!GameObject.Find("GamePiece" + (jRoyal - 1).ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal)
                    {
                        GameObject.Find("GamePiece" + (jRoyal - 1).ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal = true;
                        if (pointCountRoyal)
                            pointsRoyal += 1;
                    }
                    if (!GameObject.Find("GamePiece" + (jRoyal).ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal)
                    {
                        GameObject.Find("GamePiece" + (jRoyal).ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal = true;
                        if (pointCountRoyal)
                            pointsRoyal += 1;
                    }
                    if (!GameObject.Find("GamePiece" + (jRoyal + 1).ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal)
                    {
                        GameObject.Find("GamePiece" + (jRoyal + 1).ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal = true;
                        if (pointCountRoyal)
                            pointsRoyal += 1;
                    }
                    if (pointCountRoyal)
                    {
                        if (GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID() == sprite1Royal.GetInstanceID()) sliderRoyal1.value += 10;
                        if (GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID() == sprite2Royal.GetInstanceID()) sliderRoyal2.value += 10;
                        if (GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID() == sprite3Royal.GetInstanceID()) sliderRoyal3.value += 10;
                    }
                }
            }
            CoinFlipRoyal(true);
            if (vertical.Contains(jRoyal))
            {
             
                if ((GameObject.Find("GamePiece" + (jRoyal + 5).ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID() == GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID()) && (GameObject.Find("GamePiece" + (jRoyal - 5).ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID() == GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID()))
                {
                    if (!GameObject.Find("GamePiece" + (jRoyal - 5).ToString()+"Royal").GetComponent<CellRoyal>().needsDestructionRoyal)
                    {
                        GameObject.Find("GamePiece" + (jRoyal - 5).ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal = true;
                        if (pointCountRoyal)
                            pointsRoyal += 1;
                    }
                    if (!GameObject.Find("GamePiece" + (jRoyal).ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal)
                    {
                        GameObject.Find("GamePiece" + (jRoyal).ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal = true;
                        if (pointCountRoyal)
                            pointsRoyal += 1;
                    }
                    if (!GameObject.Find("GamePiece" + (jRoyal + 5).ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal)
                    {
                        GameObject.Find("GamePiece" + (jRoyal + 5).ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal = true;
                        if (pointCountRoyal)
                            pointsRoyal += 1;
                    }
                    if (pointCountRoyal)
                    {
                        if (GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID() == sprite1Royal.GetInstanceID()) sliderRoyal1.value += 10;
                        if (GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID() == sprite2Royal.GetInstanceID()) sliderRoyal2.value += 10;
                        if (GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal.GetInstanceID() == sprite3Royal.GetInstanceID()) sliderRoyal3.value += 10;
                    }
                }

            }


        }
        bool happenedRoyal = false;

        for (int jRoyal = 1; jRoyal < 31; jRoyal++)
        {
            CoinFlipRoyal(true);
            if (GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal)
            {

                GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().RecolorRoyal();
                happenedRoyal = true;

            }
        }
        CoinFlipRoyal(true);
        if (happenedRoyal&&pointCountRoyal) await Task.Delay(1000);


        for (int jRoyal = 1; jRoyal < 31; jRoyal++)
        {
            CoinFlipRoyal(true);
            if ( GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal){
                GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().needsDestructionRoyal = false;
                NewDestroyRoyal(GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>(), jRoyal);
                
            }
        }
        CoinFlipRoyal(true);
        if (happenedRoyal) { destructionHappenedRoyal = true;
            if (pointCountRoyal) GameObject.Find("MainCameraRoyal").GetComponent<SoundManagerRoyal>().PlayPingRoyal();
        }
        else destructionHappenedRoyal= false;
        CoinFlipRoyal(true);

    }


    public void NewDestroyRoyal(CellRoyal targetRoyal,int numberRoyal)
    {
        CoinFlipRoyal(true);
        if (numberRoyal < 6)
        {        
            targetRoyal.spriteRoyal = RandomSpriteRoyal();
        }
        else
        {
            targetRoyal.spriteRoyal = GameObject.Find("GamePiece" + (numberRoyal - 5).ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal;
            NewDestroyRoyal(GameObject.Find("GamePiece" + (numberRoyal - 5).ToString() + "Royal").GetComponent<CellRoyal>(), numberRoyal - 5);
        }
        CoinFlipRoyal(true);
    }

    public void GameStartRoyal()
    {
        pointCountRoyal = false;
        horizontal = new List<int>
        {2,3,4,7,8,9,12,13,14,17,18,19,22,23,24,27,28,29};

        vertical = new List<int>
        {6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25};
        CoinFlipRoyal(true);

        levelCanGrowRoual = true;
        CoinFlipRoyal(true);

        for (int jRoyal = 1; jRoyal < 31; jRoyal++)
        {
            GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().spriteRoyal = RandomSpriteRoyal();
            GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().CellStartRoyal();

        }

        checkValueRoyal = true;
        sliderRoyal1.value = 0;
        sliderRoyal2.value = 0;
        sliderRoyal3.value = 0;
        CoinFlipRoyal(true);
        pointsRoyal = 0;
        pointGoalRoyal = 20 + pickedLevelRoyal * 5;


        CoinFlipRoyal(true);

        BigGameCheckRoyal();
        pointCountRoyal = true;
    }
    public Sprite RandomSpriteRoyal()
    {
        CoinFlipRoyal(true);
        Sprite tempSpriteRoyal;
        int rIntRoyal = rRoyal.Next(0, 3);
        if (rIntRoyal == 0) tempSpriteRoyal = sprite1Royal;
        else if (rIntRoyal == 1) tempSpriteRoyal = sprite2Royal;
        else tempSpriteRoyal = sprite3Royal;
        CoinFlipRoyal(true);
        CoinFlipRoyal(true);
        return tempSpriteRoyal;
    }

    void SwapRoyal()
    {
     
        if ((Math.Abs(firstClickedRoyal.positionXRoyal - secondClickedRoyal.positionXRoyal) +Math.Abs(firstClickedRoyal.positionYRoyal - secondClickedRoyal.positionYRoyal))==1)
        {
            Vector3 firstTempRoyal = secondClickedRoyal.currentPositionRoyal;
            Vector3 secondTempRoyal = firstClickedRoyal.currentPositionRoyal;
            Sprite temp1 = secondClickedRoyal.spriteRoyal;
            Sprite temp2 = firstClickedRoyal.spriteRoyal;
            firstClickedRoyal.StartMoveRoyal(firstTempRoyal, temp1);
            secondClickedRoyal.StartMoveRoyal(secondTempRoyal, temp2);
            CoinFlipRoyal(true);
        }
        else
        {
            firstClickedRoyal.RefreshSpriteRoyal();
            firstClickedRoyal = null;
            secondClickedRoyal = null;
            boolFirstRoyal = false;
            boolSecondRoyal = false;
        }
        CoinFlipRoyal(true);
    }

 


    public async void BigGameCheckRoyal()
    {
        await TryCheckRoyal();

        if(!pointCountRoyal)
        while (destructionHappenedRoyal)
        {
            TryCheckRoyal();
            CoinFlipRoyal(true);
        }
        for (int jRoyal = 1; jRoyal < 31; jRoyal++)
        {
            GameObject.Find("GamePiece" + jRoyal.ToString() + "Royal").GetComponent<CellRoyal>().RefreshSpriteRoyal();
            CoinFlipRoyal(true);

        }
        CoinFlipRoyal(true);
        if (pointCountRoyal)
            if ((destructionHappenedRoyal)&&(checkValueRoyal))
             {
                Invoke("BigGameCheckRoyal", 1);
                //BigGameCheckRoyal();
                    }
    }



    void Update()
    {
        if (GameObject.Find("MainCameraRoyal").GetComponent<CanvasHolderRoyal>().gameCanvasRoyal.enabled)
        {
            if ((sliderRoyal2.value>=100) && (sliderRoyal3.value >= 100) && (sliderRoyal1.value >= 100))
            {
                checkValueRoyal = false;
                CoinFlipRoyal(true);
                if(levelCanGrowRoual)GameObject.Find("LevelChoiceCanvasRoyal").GetComponent<LevelActivatorRoyal>().ActivateButtonsRoyal();
                levelCanGrowRoual = false;
                GameObject.Find("MainCameraRoyal").GetComponent<CanvasHolderRoyal>().MoveRoyal("winRoyal");
            }
        }

        if (boolFirstRoyal && boolSecondRoyal)
        {
            CoinFlipRoyal(true);
            boolFirstRoyal = false;
            boolSecondRoyal = false;
            if (firstClickedRoyal != secondClickedRoyal) SwapRoyal();
            else firstClickedRoyal.RefreshSpriteRoyal();         
           
        }

        if (firstMoveFinishedRoyal && secondMoveFinishedRoyal)
        {
            CoinFlipRoyal(true);
            firstMoveFinishedRoyal = false;
            secondMoveFinishedRoyal = false;
            BigGameCheckRoyal();
        }
    }
}
