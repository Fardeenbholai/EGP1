using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class collectObjectsoutdoor2 : MonoBehaviour
{
    int score;
    float endgame;
    GameObject hiddenPlane;
    int canscollected;
    bool startTimer;

    float timer;
    private void OnControllerColliderHit(ControllerColliderHit hit) {
        string objectthatwearecollidingwith = hit.collider.name;
        string tagoftheobject = hit.collider.tag;
        if (tagoftheobject == "plane"){
            if(canscollected<4){
                GameObject.Find("usermessageUI").GetComponent<Text>().text = "sorry you need 4 cans!";
                startTimer = true;
            }
            else{
                hiddenPlane.SetActive(true);
                GameObject.Find("plane").SetActive(false);  
                gameObject.SetActive(false);
               
                

            }
        }
        if (tagoftheobject == "pick_me"){
            canscollected = canscollected + 1;
            Destroy(hit.collider.gameObject);
            print("collected" + canscollected + "cans");
            GameObject.Find("usermessageUI").GetComponent<Text>().text = "you have collected" + " " + canscollected + " " + "can(s)";
        }
        //
    }
    // Start is called before the first frame update
    void Start()
    {
        endgame = 0;
        timer = 0;  
        score = 0;
        canscollected = 0;
        //startDeleteMessage = false;
        GameObject.Find("usermessageUI").GetComponent<Text>().text = "";
        hiddenPlane = GameObject.Find("hiddenplane");
        hiddenPlane.SetActive(false);
        //GameObject.Find("scoreUI").GetComponent<Text>().text = "Score: " + score;
        //score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer){
            timer = timer + Time.deltaTime;
            if(timer>=3){
                GameObject.Find("usermessageUI").GetComponent<Text>().text = "";
                startTimer = false;
                timer = 0;
                
            }
        }

    }
}
