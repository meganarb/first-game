using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    bool isPressed;
    Rigidbody2D rigidbody2d;

    public Transform gate;
    public bool vertical;
    public float speed;
    public float xMax;
    public float yMax;
   
    void Start()
    {
        isPressed = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 position = gate.position;
        if (isPressed && vertical && position.y > yMax)
        {
            position.y += speed * Time.deltaTime;
            gate.position = position;
        }
        else if (isPressed && !vertical && position.x > xMax)
        {
            position.x -= speed * Time.deltaTime;
            gate.position = position;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        isPressed = true;
    }
}
