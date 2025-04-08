using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet;

    private float lastFiredTime = 0f;

    [SerializeField]
    private float fireDelay = 1f;

    private float bulletOffset = 2f;

    

    void Start()
    {
        // Do some math to perfectly spawn bullets in front of us
        // Half our size + Half of the bullet size
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 + bullet.GetComponent<Renderer>().bounds.size.y / 2;
    }

    public void Shoot()
    {
    
        float currentTime = Time.time;

        // Have a delay so we don't shoot too many bullets
        if (currentTime - lastFiredTime > fireDelay)
        {  
            //spawn Position = players position + bulletOffset
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset); 
           
            //Spawns Bullet at spawnPosition
            Instantiate(bullet, spawnPosition, transform.rotation); 

            //set lastFiredTime to currentTime
            lastFiredTime = currentTime; 
        }
    }

}
