using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Levels;
    int currentlevel;
    public void correctAnswer(){
        if (currentlevel + 1 != Levels.Length){//level is ongelijk aan de lengte van de levels.
            Levels[currentlevel].SetActive(false);//Vraag 1 in de quiz wordt op false gezet nadat hij beantwoord is.
            currentlevel++;//vervolgens waarde opgehoogd.
            Levels[currentlevel].SetActive(true);//de tweede vraag in de quiz wordt nu weergeven.
            if (currentlevel == 3){//wanneer alle vragen zijn beantwoord mag je naar de volgende level gaan.
            SceneManager.LoadScene("Speedrun");
        }
        }
        
    }

    void Start()
    {
        currentlevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
