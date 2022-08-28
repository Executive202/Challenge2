using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab; //prefab of gameObject to be spawned
    public float horizontalInput; //refrence the input system
    public float speed = 10.0f; //speed of the player
    private float xRange = 15; //range of area to restrict player
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            //if range is less than the Xrange dont allow player to move anymove
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);//make the player move

        if((Input.GetKeyDown(KeyCode.Space)))
        {
            //Launch Projectile..we use instantiate here though its not the best for memory
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
