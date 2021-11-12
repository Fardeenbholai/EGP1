using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Timermaze : MonoBehaviour
{
    // Start is called before the first frame update
    float time;
    bool startDeleteMessage;
    float timer;
   
    void Start()
    {
        startDeleteMessage = false;//Bool om UI bericht te verwijderen.
        timer = 5f;//tijd voor het verwijderen van het bericht.
        GameObject.Find("usermessageUImaze").GetComponent<Text>().text = "";//bij start UI leegmaken.
        GameObject.Find("TimerUImaze").GetComponent<Text>().text = "";//bij start UI leegmaken.
        time = 300f;//tijd is 5 minuten (60*5)
    }

    // Update is called once per frame
    void Update()
    {
        
        //time = time - Time.deltaTime;
        int seconds = (int) (time%60);//berekenen van seconden.
        int minutes = (int) (time/60);//berekenen van minuten.
        
        GameObject.Find("TimerUImaze").GetComponent<Text>().text = "Time:"+ minutes + ":" +  seconds;//tijd in de UI weergeven.
        if (time>0){//tijd is boven 0.
            time = time - Time.deltaTime;//tijd wordt afgetrokken.
        if (time < 150){//wanneer de tijd halverwege is zal er een bericht in de UI weergeven worden.
            GameObject.Find("usermessageUImaze").GetComponent<Text>().text = "Time Almost Up Hurry!";//UI bericht wordt weergeven door bovenstaande conditie.
            startDeleteMessage = true;//Bool om bericht te verwijderen.
        }
        if (startDeleteMessage == true){//bool is true.
            timer = timer - Time.deltaTime;//tijd wordt afgetrokken.
            if (timer<1){//wanneer de tijd kleiner dan 1 is wordt het bericht verwijderd.
                GameObject.Find("usermessageUImaze").GetComponent<Text>().text = "";//UI wordt leeggemaakt.
                timer = 0.0f;//timer wordt weer op 0 gezet.
                startDeleteMessage = false;//bool wordt weer op false gezet.
            }
        }
        }
        
        if (time < 1){//als de tijd voorbij is en het level niet is gehaald wordt de scene herladen.
            SceneManager.LoadScene("maze");
        }

        }
        
    }
    
 


