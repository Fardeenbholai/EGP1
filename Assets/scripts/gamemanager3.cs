using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Levels;
    int currentlevel;
    public void correctAnswer(){
        if (currentlevel + 1 != Levels.Length){
            Levels[currentlevel].SetActive(false);
            currentlevel++;
            Levels[currentlevel].SetActive(true); 
            if (currentlevel == 1){
            SceneManager.LoadScene("outdoor 2");
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
