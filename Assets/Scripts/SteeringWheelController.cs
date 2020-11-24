using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringWheelController : MonoBehaviour
{
    //Vehicle
    public GameObject vehicle;
    private Rigidbody rb;
    //turn damping, higher number reponds more accurately to wheel rotation.
    public float turnDampening ;
    private float turn, baseTurn;
    private bool handOnWheel;

    void Start()
    {
        rb = vehicle.GetComponent<Rigidbody>();
        baseTurn = this.transform.rotation.eulerAngles.z;
        handOnWheel = false;
    }

    


    void Update()
    {
        TurnVehicle();
    }

    private void TurnVehicle() { 

        // if-else statement is commented due to incorrect behaviour of steering wheel

        // if(handOnWheel){
                turn = this.transform.rotation.eulerAngles.z;
           
                if ( turn > 100 ) 
                      turn = turn - 360f; // because EulerAngles
                

               Debug.Log ("turn steering:  "+  turn );


                if (turn > 5  || turn < -5)
                     vehicle.transform.Rotate(0.0f, 1f * (-turn/turnDampening ), 0.0f, Space.Self);
               
        // }
        // else 
            // this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.transform.rotation.eulerAngles.x,this.transform.rotation.eulerAngles.y,baseTurn), 0.1f);
    }


    void OnTriggerStay(Collider other){
        if(other.tag == "PlayerHand")
            handOnWheel = true;
    }    

    void OnTriggerExit(Collider other){
        if(other.tag == "PlayerHand")
            handOnWheel = false;
    }

}
