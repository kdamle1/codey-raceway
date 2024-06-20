using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerFinishLine : MonoBehaviour
{
    public GameObject winMessage;


    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "FinishLine")
        {
            //if (checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
                //{
                if (winMessage != null)
            {
                print("You Win!");
                winMessage.SetActive(true);
            }
            else
            {
                print("Broken.");
            }
                    
                //}
                
            
        }



        //if (other.CompareTag ("Codey"))
        //{
            //print("YouWin!");
            //Debug.Log("You Win!");
        //}
    }
}
