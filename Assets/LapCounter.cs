using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCounter : MonoBehaviour
{
    [SerializeField] int numberOfLaps = 1;
    int checkpointCounter = 0;
    int lapCounter = 1;

    public LapIndicator lapIndicator;
    public TextIndication textIndication;
    public Driving driving;

    void Update()
    {
        lapIndicator.SetLapIndication(lapCounter);
    }
    //void Start()
    //{
    //    StartCoroutine(CleanScreen());
    //}

    //IEnumerator CleanScreen ()
    //{
    //    yield return new WaitForSeconds(1);
    //    textIndication.SendMessage("");
    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "CP")
        {
            Debug.Log(checkpointCounter);
            checkpointCounter++;
        }

        if (other.tag == "finish")
        {
            if (checkpointCounter >= 1)
            {
                checkpointCounter = 0;
                lapCounter++;
                if (lapCounter == (numberOfLaps + 1))
                {
                    Debug.Log("FINISH!");
                    textIndication.SetTextValue("FINISH");
                    //CleanScreen();
                }

                else
                {
                    Debug.Log($"Lap {lapCounter} completed");
                    checkpointCounter = 0;
                }
            }
            else
            {
                Debug.Log("Lap is not complited");
                //textIndication.SetTextValue("Lap is not complited");
                checkpointCounter = 0;
                //CleanScreen();
            }
        }

    }

}

   
