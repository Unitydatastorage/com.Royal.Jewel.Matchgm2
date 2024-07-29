using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class CellMovementRoyal : MonoBehaviour
{

    bool startRoyal = false;
    Vector3 position1Royal;
    Vector3 position2Royal;

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
    public void Transition(RectTransform firstRoyal, RectTransform secondRoyal)
    {
        CoinFlipRoyal(true);
        position1Royal = firstRoyal.localPosition;
        position2Royal = secondRoyal.localPosition;
        startRoyal = true;

        if (firstRoyal.localPosition != position2Royal)
        {
            firstRoyal.localPosition = Vector3.Lerp(position1Royal, position2Royal, 0);
        }
        CoinFlipRoyal(true);
        if (secondRoyal.localPosition != position1Royal)
        {
            secondRoyal.localPosition = Vector3.Lerp(position2Royal, position1Royal, 0);
        }
    }


}
