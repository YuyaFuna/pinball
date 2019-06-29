using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int loop;
    private const int SPAN = 120;
    // Start is called before the first frame update
    void Start()
    {
        loop = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (loop >= SPAN)
        { 
            GameObject prefab = null;
            //座標の変換.
            Vector3 create_shoter_vec = new Vector3(
                2.05f,
                4.2f,
                -0.4f
                );

            // Objectsフォルダ内のBallオブジェクトを参照 
            prefab = (GameObject)Resources.Load("Objects/bullet");

            if (prefab != null)
            {

                // オブジェクト生成 
                GameObject ini_ball = Instantiate(prefab,
                                             create_shoter_vec, Quaternion.identity);


                Vector3 ball_vec = new Vector3(
                    0.0f,
                    -5.0f,
                    0.0f
                    );

                // ボール生成時に速度を持たせる 
                ini_ball.GetComponent<Rigidbody>().velocity = ball_vec;

            }
            loop = 0;
        }
        //Debug.Log(loop);
        loop = (loop % SPAN) + 1;
    }

}
