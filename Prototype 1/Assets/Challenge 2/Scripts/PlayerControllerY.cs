using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerY : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool spawned = false;
    public float decay;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog, on a 1 second interval/delaytime
        Reset();
        if (Input.GetKeyDown(KeyCode.Space) && !spawned)
        {
            decay = 1.0f;
            spawned = true;
           Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
        }
        
    }
    
    private void Reset()
    {
        if(spawned && decay > 0)
        {
            decay -= Time.deltaTime;
        }
        if(decay < 0)
        {
            decay = 0;
            spawned = false;
        }
    }

    
 
   
    
    

   
}
