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
        startDeleteMessage = false;
        timer = 5f;
        GameObject.Find("usermessageUImaze").GetComponent<Text>().text = "";
        GameObject.Find("TimerUImaze").GetComponent<Text>().text = "";
        time = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        
        //time = time - Time.deltaTime;
        int seconds = (int) (time%60);
        int minutes = (int) (time/60);
        
        GameObject.Find("TimerUImaze").GetComponent<Text>().text = "Time:"+ minutes + ":" +  seconds;
        if (time>0){
            time = time - Time.deltaTime;
        if (time < 150){
            GameObject.Find("usermessageUImaze").GetComponent<Text>().text = "Time Almost Up Hurry!";
            startDeleteMessage = true;
        }
        if (startDeleteMessage == true){
            timer = timer - Time.deltaTime;
            if (timer<1){
                GameObject.Find("usermessageUImaze").GetComponent<Text>().text = "";
                timer = 0.0f;
                startDeleteMessage = false;
            }
        }
        }
        //if (time < 30){
         //   GameObject.Find("usermessageUI").GetComponent<Text>().text = "Time Almost Up Hurry!";
            
        //}
        //if (time < 25){
        //    GameObject.Find("usermessageUI").GetComponent<Text>().text = "";
        //}
        
        if (time < 1){
            SceneManager.LoadScene("maze");
        }

        }
        
    }
    
 


