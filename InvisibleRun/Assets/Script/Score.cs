using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public float TimeScore;
    public GameObject Player;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        TimeScore += 2f;

        ScoreText.text = "ÉXÉRÉA"+ TimeScore;

        if(Player.GetComponent<Invisible>().ItemUse ==  false)
        {
            TimeScore += 10f;
        }

 
    }
}
