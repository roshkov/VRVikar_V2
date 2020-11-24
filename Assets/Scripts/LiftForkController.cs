using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftForkController : MonoBehaviour
{
 
    public Transform topOfLever;

    private float forwardBackwardTilt = 0;

    public Transform fork; 

    public float speedTranslate; //Platform travel speed
    public float maxY; //The maximum height of the platform
    public float minY; //The minimum height of the platform



    void FixedUpdate () {
      
            //Hardcoded '28' because NormalLever is rotated -28 on X axis. P.s that is not good
            forwardBackwardTilt = topOfLever.rotation.eulerAngles.x + 28;


            // Lift fork up
            if  (forwardBackwardTilt < 355 && forwardBackwardTilt > 290  )
            {
                    if (fork.transform.position.y <= maxY) {
                            forwardBackwardTilt = System.Math.Abs (forwardBackwardTilt - 360);    
                            fork.Translate(Vector3.up * speedTranslate/10 * Time.deltaTime);
                        } ; 
            
            }
            else {
                    if (forwardBackwardTilt >= 360) { forwardBackwardTilt = forwardBackwardTilt - 360 ; }
                
                    if (forwardBackwardTilt > 5 && forwardBackwardTilt < 74)
                    {
                            if (fork.transform.position.y >= minY) {
                                fork.Translate(Vector3.down * speedTranslate/10 * Time.deltaTime);
                            }

                    }

            }
        


    }

}
