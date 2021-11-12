using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class speedrunfinished : MonoBehaviour
{
  
    private void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.collider.gameObject.tag == "pick_me"){
            Destroy (hit.collider.gameObject);
            SceneManager.LoadScene("questionsspeedrun");

        }

        
    }
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
