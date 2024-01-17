using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    bool isPressed;

    public Transform gate = null;
    public bool vertical;
    public float speed;
    public float xMax;
    public float yMax;
    public float xMin;
    public float yMin;
   
    void Start()
    {
        isPressed = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 position = gate.position;
        Debug.Log(position);
        if (isPressed && vertical && position.y > yMax)
        {
            position.y -= speed * Time.deltaTime;
            gate.position = position;
        }
        else if (isPressed && !vertical && position.x > xMax)
        {
            position.x -= speed * Time.deltaTime;
            gate.position = position;
        }
        else if (!isPressed && vertical && position.y < yMin)
        {
            position.y += speed * Time.deltaTime;
            gate.position = position;
        }
        else if (!isPressed && !vertical && position.x < xMin)
        {
            position.x += speed * Time.deltaTime;
            gate.position = position;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("button");
        isPressed = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isPressed = false;
    }
}
