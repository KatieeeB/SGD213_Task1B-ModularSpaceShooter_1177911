using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Acceleration indicates how fast something moves, Serializefield exposes this value to the editor.
    [SerializeField]
    private float acceleration = 5f;

    private Rigidbody2D rb;


    void Start()
    {
        //Get Rigidbody component when the game starts and store a reference to it.
        rb = GetComponent<Rigidbody2D>();
    }


    public void Move(Vector2 direction)
    {
        rb.velocity = direction * acceleration;
    }
}
