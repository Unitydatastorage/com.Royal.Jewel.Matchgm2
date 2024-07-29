using System.Collections;
using UnityEngine;


public class CellRoyal : MonoBehaviour
{

    public int positionXRoyal;
    public int positionYRoyal;
    public Sprite spriteRoyal;
    public Vector3 currentPositionRoyal;
    public bool needsDestructionRoyal = false;



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

    public void OnClickRoyal()
    {
        GameObject.Find("MainCameraRoyal").GetComponent<SoundManagerRoyal>().PlayClickRoyal();
        if (!GameObject.Find("GameCanvasRoyal").GetComponent<GameLogicRoyal>().boolFirstRoyal)
        {
            GetComponent<UnityEngine.UI.Image>().color = Color.green;
            GameObject.Find("GameCanvasRoyal").GetComponent<GameLogicRoyal>().firstClickedRoyal = this;
            GameObject.Find("GameCanvasRoyal").GetComponent<GameLogicRoyal>().boolFirstRoyal = true;
        }
        else if (!GameObject.Find("GameCanvasRoyal").GetComponent<GameLogicRoyal>().boolSecondRoyal)
        {
            CoinFlipRoyal(true);
            GameObject.Find("GameCanvasRoyal").GetComponent<GameLogicRoyal>().secondClickedRoyal = this;
            GameObject.Find("GameCanvasRoyal").GetComponent<GameLogicRoyal>().boolSecondRoyal = true;
        }
    }

    public void RefreshSpriteRoyal()
    {
        CoinFlipRoyal(true);
        GetComponent<UnityEngine.UI.Image>().color = Color.white;
        GetComponent<UnityEngine.UI.Image>().sprite = spriteRoyal;
    }

    public void RecolorRoyal()
    {
        CoinFlipRoyal(true);
        GetComponent<UnityEngine.UI.Image>().color = Color.green;
       
    }


    public void StartMoveRoyal(Vector3 destinationRoyal, Sprite newSpriteRoyal)
    {
        CoinFlipRoyal(true);
        GetComponent<UnityEngine.UI.Image>().color = Color.white;
        StartCoroutine(moveObjectRoyal(destinationRoyal, newSpriteRoyal));
    }

    public IEnumerator moveObjectRoyal(Vector3 destinationRoyal, Sprite newSpriteRoyal)
    {
        CoinFlipRoyal(true);
        float totalMovementTimeRoyal = 1f; 
        float currentMovementTimeRoyal = 0f;
        while (Vector3.Distance(transform.localPosition, destinationRoyal) > 0)
        {
            currentMovementTimeRoyal += Time.deltaTime;
            transform.localPosition = Vector3.Lerp(currentPositionRoyal, destinationRoyal, currentMovementTimeRoyal / totalMovementTimeRoyal);
            yield return null;
        }
        transform.localPosition = currentPositionRoyal;
        spriteRoyal = newSpriteRoyal;
        RefreshSpriteRoyal();
        CoinFlipRoyal(true);
        if (GameObject.Find("GameCanvasRoyal").GetComponent<GameLogicRoyal>().firstMoveFinishedRoyal == false)
        {
            GameObject.Find("GameCanvasRoyal").GetComponent<GameLogicRoyal>().firstMoveFinishedRoyal = true;
        }
        else GameObject.Find("GameCanvasRoyal").GetComponent<GameLogicRoyal>().secondMoveFinishedRoyal = true;

    }


    public void CellStartRoyal()
    {
        CoinFlipRoyal(true);
        currentPositionRoyal = transform.localPosition;
        RefreshSpriteRoyal();
    }

  
   
}
