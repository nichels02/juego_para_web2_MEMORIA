using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class winOrLose : MonoBehaviour
{
    [SerializeField] TMP_Text timeText;
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject panel_Lose;
    float time = 51;
    int regulador = 50;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.gano == false && regulador>0 )
        {
            time -= Time.deltaTime;
            if (time < regulador)
            {
                regulador -= 1;
                timeText.text = "" + regulador;
            }
        }
        if(regulador == 0)
        {
            panel_Lose.SetActive(true);
        }
    }
}
