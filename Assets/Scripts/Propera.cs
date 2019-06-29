using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propera : MonoBehaviour
{
    public static bool bonustime = false;
    private static int BONUSTIME = 600;
    private static int loop = 0;
    private static void Update()
    {
        Transform transform2 = FindObjectOfType<Transform>();
        if (!bonustime || loop > BONUSTIME)
        {
            Vector3 localScale = transform2.localScale;
            localScale.x = 0.5f; // ローカル座標を基準にした、x軸方向へ2倍のサイズ変更
            localScale.y = 0.5f; // ローカル座標を基準にした、y軸方向へ2倍のサイズ変更
            transform2.localScale = localScale;
            loop = 0;
            return;
        }
        transform2.Rotate(new Vector3(0, 0, 90));
        //Debug.Log("routating!");
        loop++;
    }

    public static void Bonus()
    {
        Transform transform1 = FindObjectOfType<Transform>();
        Vector3 localScale = transform1.localScale;
        localScale.x = 2.0f; // ローカル座標を基準にした、x軸方向へ2倍のサイズ変更
        localScale.y = 2.0f; // ローカル座標を基準にした、y軸方向へ2倍のサイズ変更
        transform1.localScale = localScale;
        bonustime = true;
        Update();
        bonustime = false;
        return;
    }
}
