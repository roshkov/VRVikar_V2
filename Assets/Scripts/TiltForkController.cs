using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltForkController : MonoBehaviour
{


    public Transform topOfLever;

    private float forwardBackwardTilt = 0;


    public Transform fork; 

    
    public float speedRotate;

    public float maxRotate;
    public float minRotate;



    void FixedUpdate () {
      
        //28 because NormalLever is rotated -28 on X axis. P.s that is no good
         forwardBackwardTilt = topOfLever.rotation.eulerAngles.x + 28;

        if  (forwardBackwardTilt < 355 && forwardBackwardTilt > 290  )
        {
                if (fork.rotation.x >= maxRotate/100) {
                     fork.Rotate(Vector3.left * speedRotate * Time.deltaTime);
                  
                } ;      
      
        }  else {
        
            if (forwardBackwardTilt >= 360) { forwardBackwardTilt = forwardBackwardTilt - 360 ; }
            
            if (forwardBackwardTilt > 5 && forwardBackwardTilt < 74)
            {
                
                if (fork.rotation.x <= minRotate/100) {
                        fork.Rotate(Vector3.right * speedRotate * Time.deltaTime);
                    
                    } ; 


            }

        }
     


    }
}
