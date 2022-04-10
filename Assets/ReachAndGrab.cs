using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ReachAndGrab : MonoBehaviour
{
    public GameObject userCamera;
    Vector2 self2dPosition; 
    Vector2 userCamera2dPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        self2dPosition = new Vector2(transform.position.x, transform.position.z);
        userCamera2dPosition = new Vector2(userCamera.transform.position.x, userCamera.transform.position.z);
        if(Vector2.Distance(self2dPosition, userCamera2dPosition) < 0.5){
            transform.position = new Vector3(7, 1, 2);
        }
    }
}
