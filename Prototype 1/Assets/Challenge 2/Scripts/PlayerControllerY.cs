using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerY : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool delayTime = false;
    public float delayTimeMax;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog, on a 1 second interval/delaytime
        Reset();
        if (Input.GetKeyDown(KeyCode.Space) && !delayTime)
        {
            delayTimeMax = 1.0f;
            delayTime = true;
           Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
        }
        
    }
    
    private void Reset()
    {
        if(delayTime && delayTimeMax > 0)
        {
            delayTimeMax -= Time.deltaTime;
        }
        if(delayTimeMax < 0)
        {
            delayTimeMax = 0;
            delayTime = false;
        }
    }

    
 
   
    
    

   
}
