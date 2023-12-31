using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {

        if(other.gameObject.tag ==  "Player") {
            StartCoroutine(HighlightAndRevert());
            gameObject.tag = "Hit"; 
        }
    }


    IEnumerator HighlightAndRevert() {
   
    // Store the original color
    Color originalColor = GetComponent<MeshRenderer>().material.color;

    // Change the material color to red
    GetComponent<MeshRenderer>().material.color = Color.red;

    // Wait for 1 second
    yield return new WaitForSeconds(.5f);

    // Revert the material color back to the original color
    GetComponent<MeshRenderer>().material.color = originalColor;
}

}
