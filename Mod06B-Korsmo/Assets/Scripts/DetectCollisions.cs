using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 30)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < -10)
        {
            Debug.Log("Game Over!");
            //Destroy(GameObject);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
