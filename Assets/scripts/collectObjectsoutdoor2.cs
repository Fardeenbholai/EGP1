using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //Library om ervoor te zorgen dat er overgang mogelijk is naar een andere scene.
using UnityEngine.UI;               //Library om ervoor te zorgen dat er berichten naar de UI geschreven kunnen worden.
public class collectObjectsoutdoor2 : MonoBehaviour
{
    int score;
    GameObject hiddenPlane;
    int canscollected;
    bool startTimer;

    float timer;
    private void OnControllerColliderHit(ControllerColliderHit hit) {
        string objectthatwearecollidingwith = hit.collider.name;
        string tagoftheobject = hit.collider.tag;
        if (tagoftheobject == "plane"){ //interactie met het vliegtuig.
            if(canscollected<4){//wanneer interactie met het vliegtuig plaatsvind en je niet de vaten hebt opgepakt komt er een bericht in de UI.
                GameObject.Find("usermessageUI").GetComponent<Text>().text = "sorry you need 4 cans!";
                startTimer = true;//Bool om bericht in de UI te kunnen verwijderen.
            }
            else{
                hiddenPlane.SetActive(true);//tweede vliegtuig wordt actief.
                GameObject.Find("plane").SetActive(false);  //eerste vliegtuig wordt gedeactiveerd.
                gameObject.SetActive(false);//FPScontroller wordt uitgeschakeld anders kan er niet gevlogen worden.
               
                

            }
        }
        if (tagoftheobject == "pick_me"){//Oppakken van de vaten.
            canscollected = canscollected + 1;//Score bijhouden.
            Destroy(hit.collider.gameObject);//Collision met gameobject.
            print("collected" + canscollected + "cans");//Print naar de Console.
            GameObject.Find("usermessageUI").GetComponent<Text>().text = "you have collected" + " " + canscollected + " " + "can(s)";//Geeft dit bericht in de UI weer.
        }
        //
    }
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;//timer bijhouden wanneer UI bericht verwijderd moet worden.
        score = 0;//score bijhouden voor de vaten.
        canscollected = 0;//aantal vaten bijhouden.
        GameObject.Find("usermessageUI").GetComponent<Text>().text = "";//UI bij start van de game leegmaken.
        hiddenPlane = GameObject.Find("hiddenplane");//tag van gameobject van het vliegtuig.
        hiddenPlane.SetActive(false);//Vliegtuig bij het begin als inactive zetten zodat deze niet direct wegvliegt.
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer){//Bool is true.
            timer = timer + Time.deltaTime;//telt timer op.
            if(timer>=3){//timer heeft waarde boven of gelijk aan 3 bereikt.
                GameObject.Find("usermessageUI").GetComponent<Text>().text = "";//UI wordt vervolgens weer leeggemaakt zodat er geen bericht meer is.
                startTimer = false;//Timer wordt vervolgens weer op false gezet.
                timer = 0;//Timer wordt weer terug naar 0 gezet.
                
            }
        }

    }
}
