using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManagerRoyal : MonoBehaviour
{
    public AudioSource themeRoyal;
    public AudioSource pingRoyal;
    public AudioSource clickRoyal;

    float soundLevelRoyal = 0.5f;
    float musicLevelRoyal = 0.5f;

    public Slider musicSliderRoyal;
    public Slider soundSliderRoyal;

    public bool changedRoyal = false;


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
    void Start()
    {
        CoinFlipRoyal();
        themeRoyal.Play();
    }

    public void PlayPingRoyal()
    {
        CoinFlipRoyal();
        pingRoyal.volume=soundLevelRoyal;
        pingRoyal.Play(); 
        
    }

    public void PlayClickRoyal()
    {
        CoinFlipRoyal();
        clickRoyal.volume = soundLevelRoyal;
        clickRoyal.Play(); 
       
    }



    void Update()
    {

        soundLevelRoyal = soundSliderRoyal.value;
        musicLevelRoyal = musicSliderRoyal.value;
        themeRoyal.volume = musicLevelRoyal;

        if (!themeRoyal.isPlaying)
        {
             themeRoyal.Play(); 
            
        }
    }


}
