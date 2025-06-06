using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    //public float Time;
    public FMODUnity.StudioEventEmitter FMODTimeEvent;
    public GameManager gmanager;
    public string periodOfTheDay;

    public float RawTime, TwentyFourHourTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        TwentyFourHourTime = (RawTime / 1440f) * 24f;
        FMODTimeEvent.SetParameter("Time", TwentyFourHourTime);

    }

    public void updateTimePeriod(int periodIndex) 
    {
        FMODTimeEvent.SetParameter("TimeOfDay", periodIndex);
        if (periodIndex == 0)
        {
            periodOfTheDay = "Night";
        }
        else if (periodIndex == 1)
        {
            periodOfTheDay = "Morning";
        }
        else if (periodIndex == 2)
        {
            periodOfTheDay = "Afternoon";
        }
        else if (periodIndex == 3) 
        {
            periodOfTheDay = "Evening";
        }
    }


}


