using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_flipper : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0, 0, -90);    
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            transform.Rotate(0, 0, 90);
        }
    }
}
