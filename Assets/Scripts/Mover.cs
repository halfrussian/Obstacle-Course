using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
   [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    // only happen once 
    void Start()
    {
       PrintInstructions();
    }

    // Update is called once per frame after start
    void Update()
    {
        MovePlayer();
    } 


    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game");
        Debug.Log("Move your player with Arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer () {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue); 
    }

}
