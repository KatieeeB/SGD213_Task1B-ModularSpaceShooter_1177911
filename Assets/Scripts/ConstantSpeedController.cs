using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpeedController : MonoBehaviour
{
    //Direction the object is moving in, SerializeField allows it to be changed in the editor.
    [SerializeField]
    private Vector2 direction;

    private Movement movement;

    // Start is called before the first frame update
    void Start()
    {
        //Getting a reference to movement script
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.Move(direction);
    }
}
