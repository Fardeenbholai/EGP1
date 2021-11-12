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
        GameObject.Find("TimerUI").GetComponent<Text>().text = "";
        time = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        
        //time = time - Time.deltaTime;
        int seconds = (int) (time%60);
        int minutes = (int) (time/60);
        
        GameObject.Find("TimerUI").GetComponent<Text>().text = "Time:"+ minutes + ":" +  seconds;
        if (time>0){
            time = time - Time.deltaTime;
        }
        //if (time < 30){
         //   GameObject.Find("usermessageUI").GetComponent<Text>().text = "Time Almost Up Hurry!";
            
        //}
        //if (time < 25){
        //    GameObject.Find("usermessageUI").GetComponent<Text>().text = "";
        //}
        
        if (time < 1){
            SceneManager.LoadScene("Speedrun");
        }

        }
        
    }
    
 


