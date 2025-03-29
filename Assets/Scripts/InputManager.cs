using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Movement movement;
    private Shooting shooting;

    
    void Start()
    {
        //getting a reference to the movement and shooting
        movement = GetComponent<Movement>();
        shooting = GetComponent<Shooting>();
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        
        movement.Move(Vector2.right * input);

        if (Input.GetButton("Fire1"))
        {
            shooting.Shoot();
        }
    }
}
