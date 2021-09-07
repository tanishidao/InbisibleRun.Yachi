using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultScore : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
       text.text =  Score.Instance.Scores + "“_"; 
    }

   
}
