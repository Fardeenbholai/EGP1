using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
Hieronder is de code weergeven die nodig was om een quiz met vragen te maken en te kunnen laten beantwoorden.
In totaal zijn er 3 scripts geschreven namelijk gamemanager, gamemanager2 en gamemanager3. Alle 3 de scripts hebben de zelfde werking.
En daarbij dus ook dezelfde comments.



*/
public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Levels;//array om alle scenes in bij te houden.
    int currentlevel;//integer om te ittereren over de array.
    public void correctAnswer(){
        if (currentlevel + 1 != Levels.Length){//level is ongelijk aan de lengte van de levels.
            Levels[currentlevel].SetActive(false);//Vraag 1 in de quiz wordt op false gezet nadat hij beantwoord is.
            currentlevel++;//vervolgens waarde opgehoogd.
            Levels[currentlevel].SetActive(true);//de tweede vraag in de quiz wordt nu weergeven.
            if (currentlevel == 3){//wanneer alle vragen zijn beantwoord mag je naar de volgende level gaan.
            SceneManager.LoadScene("maze");
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
