using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Invisible : MonoBehaviour
{
    public bool GetItem = false;
    public float InvisibleTime = 5f;

    private float time = 0f;

    public GameObject Drink;

    private GameObject DrinkBox;

    public GameObject StockItem;

    public Text ScoreUp;

    public float Scorespeed = 1f;

    private float ScoreTime;

    public bool ItemUse;
   
   
   

    // Start is called before the first frame update
    void Start()
    {
        DrinkBox = Instantiate(Drink);

        ScoreUp.enabled = false;
        StockItem.SetActive(false);
        ItemUse = true;
       
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        ScoreUp.color = GetAlphaColor(ScoreUp.color);
        if (GetItem == true && Input.GetKeyDown(KeyCode.C))
        {
            this.tag = "InvisibleNow";
            time = 0f;
            GetComponent<Renderer>().material.color = Color.red;
            ScoreUp.enabled = true;
            StockItem.SetActive(false);
            ItemUse = false;

        }
        if (InvisibleTime < time)
        {
            this.tag = "Player";

            GetComponent<Renderer>().material.color = Color.white;
            ScoreUp.enabled = false;
            ItemUse = true;
        }
       


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Drink"))
        {
            GetItem = true;
            Debug.Log("Drinksita");

            Destroy(DrinkBox);
            StockItem.SetActive(true);
        }
    }
    Color GetAlphaColor(Color color)
    {
        ScoreTime += Time.deltaTime * 5.0f * Scorespeed;
        color.a = Mathf.Sin(ScoreTime);

        return color;
    }

}
