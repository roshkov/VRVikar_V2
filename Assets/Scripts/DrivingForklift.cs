using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingForklift : MonoBehaviour
{


 
    void Update () {

        float transSpeed = Input.GetAxis("Oculus_CrossPlatform_PrimaryThumbstickVertical");
        transform.Translate(Vector3.forward * (transSpeed/2) * Time.deltaTime );

    }

}
