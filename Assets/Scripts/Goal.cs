using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public Text scoreText;
    public static int success = 0;
    private int total = 0;
    private int success_before = 0;

    void Update()
    {
        if(success > 0 && success % 5 == 0 && success > success_before)
        {
            success_before = success;
            GameObject prefab = (GameObject)Resources.Load("Objects/BonusEffect");
            if(prefab != null)
            {
                // 座標値0
                Vector3[] shotPos = new Vector3[] {
                        new Vector3( 7, -5, -0.5f),
                        new Vector3(-7, -5, -0.5f),
                    };

                //オブジェクトを作ると破棄.
                for(int i = 0; i < shotPos.Length; i++)
                {
                    GameObject instant_object = Instantiate(prefab, shotPos[i], Quaternion.identity);
                    // 削除までの時間
                    Destroy(instant_object, 3);
                }
            }
            Propera.Bonus();
        }
        total = Shoter.total;
        scoreText.text = "ALL shot ball : " +total.ToString() + 
                                "\nsuccess        : " + success.ToString() +
                                "\nsuccess  rate  : " +((float)success/total*100).ToString() + " %";
    }

    void OnTriggerEnter(Collider col_obj)
    {
        // Resorcesフォルダ下にあるGoalEffectのPrefabを読み込む
        GameObject prefab = (GameObject)Resources.Load("Objects/GoalEffect");

        if (prefab != null)
        {
            // 座標値0
            Vector3 create_shoter_vec = new Vector3(
                0, 0, 0
                );

            //オブジェクトを作ると破棄.
            GameObject instant_object =Instantiate(prefab,create_shoter_vec, Quaternion.identity);

            // 削除までの時間
            Destroy(instant_object, 5);

            if (col_obj.gameObject.tag == "Ball")
            {
                success++;
                Destroy(col_obj.gameObject, 2.0f);
                Shoter.shotcount++;
            }

        }
    }
}
