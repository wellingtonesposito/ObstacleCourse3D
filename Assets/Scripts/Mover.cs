using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float yValue = 0f;
    [SerializeField] float moveSpeed = 10f;


    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Move your player with WASD or Arrow keys");
        Debug.Log("Don't hit the walls");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(xValue, yValue, zValue);
    }

}
