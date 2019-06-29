using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoter : MonoBehaviour
{
    public static int shotcount;
    public static int total;
    // Start is called before the first frame update
    void Start()
    {
        total = 0;
        shotcount = 50;
    }

    // Update is called once per frame
    void Update()
    {
        // 左クリックがおされたら 
        if (Input.GetKeyDown(KeyCode.Return))
        {

            if (shotcount < 1) return;

            GameObject prefab = null;
            //座標の変換.
            Vector3 create_shoter_vec = new Vector3(
                2.05f,
                -4.6f,
                -0.4f
                );

            // Objectsフォルダ内のBallオブジェクトを参照 
            prefab = (GameObject)Resources.Load("Objects/Ball");

            if (prefab != null)
            {

                // オブジェクト生成 
                GameObject ini_ball = Instantiate(prefab,
                                             create_shoter_vec, Quaternion.identity);


                Vector3 ball_vec = new Vector3(
                    0.0f,
                    20.0f,
                    0.0f
                    );

                // ボール生成時に速度を持たせる 
                ini_ball.GetComponent<Rigidbody>().velocity = ball_vec;

            }

            total++;
            shotcount--;
        }
    }
}
