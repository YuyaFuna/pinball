using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refect_cupsle : MonoBehaviour
{
    void OnTriggerEnter(Collider col_obj)
    {

        // ボールとの判定を取ります
        if (col_obj.gameObject.tag == "Ball")
        {

            GameObject o = col_obj.gameObject;
            // 反射した時のボールのベクトル 
            Vector3 ball_vec = new Vector3(
                Random.Range(3.0f, 5.0f),
                Random.Range(-5.0f, -3.0f),
                0.0f
                );

            // ボール生成時に速度を持たせる 
            o.GetComponent<Rigidbody>().velocity = ball_vec;

        }

    }
}
