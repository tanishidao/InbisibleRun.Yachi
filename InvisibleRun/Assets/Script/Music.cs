using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class Music : MonoBehaviour
{
    Slider slider;
    public bool isInput;
    public float ScroolSpeed = 1f;

    private void Awake()
    {
        slider = GetComponent<Slider>();
        slider.value = AudioListener.volume;
    }
    private void OnEnable()
    {
        slider.value = AudioListener.volume;
        slider.onValueChanged.AddListener((sliderValue) => AudioListener.volume = sliderValue);

    }
    private void OnDisable()
    {
        slider.onValueChanged.RemoveAllListeners();
    }
    private void Update()
    {
        float v = slider.value;
        if(isInput)
        {
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                v -= ScroolSpeed * Time.deltaTime;
            }
            if(Input.GetKey(KeyCode.RightArrow))
            {
                v += ScroolSpeed * Time.deltaTime;
            }
        }
        v = Mathf.Clamp(v, 0, 1);
        slider.value = v;
    }


}
