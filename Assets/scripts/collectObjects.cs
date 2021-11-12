using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Library om ervoor te zorgen dat er overgang mogelijk is naar een andere scene.
using UnityEngine.UI;              //Library om ervoor te zorgen dat er berichten naar de UI geschreven kunnen worden.
public class collectObjects : MonoBehaviour
{

    int score;
    bool startDeleteMessage;
    float timer;
    private void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.collider.gameObject.tag == "pick_me"){ //controleert of de speler botst met een gameobject met tag "pick_me".
            score = score+1;                           // score wordt verhoogd met 1
            GameObject.Find("scoreUI").GetComponent<Text>().text = "Score: " + score + "/3"; //score wordt weergeven in UI object.
            GameObject.Find("collectedobjectUI").GetComponent<Text>().text = "You Collected A Object!"; //UI geeft bericht weer.
            startDeleteMessage = true; //Bool om bij te houden wanneer bericht verwijderd moet worden.
            if (score>=3) SceneManager.LoadScene("questionsoutdoor"); //Volgende scene wordt geladen bij score van 3.
            Destroy (hit.collider.gameObject); //Gameobject verwijderen na interactie met speler.
        }
        if (startDeleteMessage == true){ //Bool is true.
            timer = timer - Time.deltaTime;//variabel timer telt af.
            if (timer<1){//
                GameObject.Find("collectedobjectUI").GetComponent<Text>().text = "";//bericht wordt na 5 seconden verwijderd van de UI.
                startDeleteMessage = false;//Bool wordt weer op false gezet.
                timer = 5f;//Timer wordt weer herstart.
            }
            
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        timer = 5f;//Variabel om UI bericht na 5 seconden te verwijderen.
        startDeleteMessage = false;//Bool op false.
        GameObject.Find("collectedobjectUI").GetComponent<Text>().text = "";//Bij start de UI object leeg maken.
        GameObject.Find("scoreUI").GetComponent<Text>().text = "Score: " + score;//Bij start huidige score weergeven.
        score = 0;//Bij start is de score 0.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
