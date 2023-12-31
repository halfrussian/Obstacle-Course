using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score= 0;
    
    void OnCollisionEnter(Collision other) {
       if(other.gameObject.tag != "Hit") {
        score++;
        Debug.Log("You've bumped into this many times: " +  score );
       } 
       
    }


}
