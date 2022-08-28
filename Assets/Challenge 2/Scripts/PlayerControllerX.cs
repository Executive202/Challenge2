using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float waitTime =2;
    private float counter = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (counter >=waitTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                counter = 0;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
        else counter+= Time.deltaTime;
        
    }
}
