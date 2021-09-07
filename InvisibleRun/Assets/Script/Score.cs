using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public readonly static Score Instance = new Score();
    public float Scores;


    public Text ScoreText;
    
    public GameObject Player;

    

    
    // Start is called before the first frame update
    void Start()
    {
        

    }
    // Update is called once per frame
    void Update()
    {
        Instance.Scores += 1f;
        

        ScoreText.text = "ÉXÉRÉA"+ Instance.Scores;

        if (Player.GetComponent<Invisible>().ItemUse ==  false)
        {
            Instance.Scores += 4f;
        }

 
    }
}
