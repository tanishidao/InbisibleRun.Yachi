using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvisibleSircle : MonoBehaviour
{
    public Image image;


    private void Start()
    {
        
    }
    void Update()
    {
        image.fillAmount -= Time.deltaTime;
    }
}
