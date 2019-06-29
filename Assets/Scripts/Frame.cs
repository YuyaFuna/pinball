using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame : MonoBehaviour
{
    void OnTriggerEnter(Collider col_obj)
    {
        if (col_obj.gameObject.tag == "Ball" || col_obj.gameObject.tag == "Bullet")
        {
            //Debug.Log("destroy: " + col_obj.gameObject.tag);
            Destroy(col_obj.gameObject);
            Shoter.shotcount++;
        }

        
    }
}
