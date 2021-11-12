using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] private Transform player;//positie van de speler.
   [SerializeField] private Transform respawnpoint;//positie van de respawn point.

   private void OnTriggerEnter(Collider other) {
       player.transform.position = respawnpoint.transform.position;//wanneer de speler collide met een onzichtbare plane (mesh) verandert de positie van de speler naar de respawnpositie.
       
   }
        
    
}
