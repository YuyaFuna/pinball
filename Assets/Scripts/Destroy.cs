using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void OnTriggerEnter(Collider col_obj)
    {
        if (Goal.success < 1)
        {
            return;
        }

        if (col_obj.gameObject.tag == "Ball")
        {
            //Debug.Log("destroy: " + col_obj.gameObject.tag);
            Destroy(col_obj.gameObject);
            Goal.success--;
        }
    }
}
