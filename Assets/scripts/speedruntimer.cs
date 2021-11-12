using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class speedruntimer : MonoBehaviour
{
    // Start is called before the first frame update
    float time;
    bool startDeleteMessage;
   
    void Start()
    {
        GameObject.Find("TimerUI").GetComponent<Text>().text = "";//lege bericht wordt op de UI weergeven.
        time = 300f;//tijd is 5 minuten (60*5)
    }

    // Update is called once per frame
    void Update()
    {
        
        //time = time - Time.deltaTime;
        int seconds = (int) (time%60);//berekenen van seconden.
        int minutes = (int) (time/60);//berekenen van minuten.
        
        GameObject.Find("TimerUI").GetComponent<Text>().text = "Time:"+ minutes + ":" +  seconds;//tijd wordt in de UI weergeven.
        if (time>0){//zolang de tijd groter is dan 0 neemt de tijd af.
            time = time - Time.deltaTime;
        }
        
        if (time < 1){//wanneer de tijd kleiner dan 1 is wordt de scene weer herladen.
            SceneManager.LoadScene("Speedrun");
        }

        }
        
    }
    
 


