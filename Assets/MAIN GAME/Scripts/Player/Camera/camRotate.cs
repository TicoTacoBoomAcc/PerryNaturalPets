using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camRotate : MonoBehaviour
{
    public Vector2 turn;
    public float sensetivity = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turn.y += Input.GetAxis("Mouse Y") * sensetivity;
        turn.x += Input.GetAxis("Mouse X") * sensetivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
