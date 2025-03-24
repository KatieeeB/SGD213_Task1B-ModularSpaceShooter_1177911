using UnityEngine;
using System.Collections;

public class DestroyedOnExit : MonoBehaviour
{
    // Called when the object leaves the viewport
    void OnBecameInvisible() //when the object is nolonger rendered it is destroyed
    {
        Destroy(gameObject);
    }
}
