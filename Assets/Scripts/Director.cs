using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Director : MonoBehaviour
{
    public Text scoreText; 

    void Start()
    {
        scoreText.text = "ALL shot ball : 0" + "\nsuccess        : 0"; 
    }

    void Update()
    {

    }
}
