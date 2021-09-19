using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Invisible : MonoBehaviour
{
    public bool GetItem = false;
    public float InvisibleTime = 8f;

    

    public GameObject Drink;

    private GameObject DrinkBox;

    public GameObject StockItem;



    public Text ScoreUp;

    public float Scorespeed = 1f;

    private float ScoreTime;

    public bool ItemUse;

    public Image image;
    public AudioSource RIng;
   
   
   

    // Start is called before the first frame update
    void Start()
    {
        DrinkBox = Instantiate(Drink);

        ScoreUp.enabled = false;
        StockItem.SetActive(false);
        ItemUse = true;
        image.enabled = false;
       
        AudioSource audioSource = GetComponent<AudioSource>();
    

    }

    // Update is called once per frame
    void Update()
    {
       
        ScoreUp.color = GetAlphaColor(ScoreUp.color);
        if (GetItem == true && Input.GetKeyDown(KeyCode.C))
        {
            this.tag = "InvisibleNow";
            
            
           /// GetComponent<Renderer>().material.color = Color.red;
            ScoreUp.enabled = true;
            image.enabled = true;
            StockItem.SetActive(false);
            ItemUse = false;
            image.fillAmount += 8f;
            
            GetItem = false;
            RIng.PlayOneShot(RIng.clip);
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
        }
        if (image.fillAmount <= 0)
        {
            this.tag = "Player";

           /// GetComponent<Renderer>().material.color = Color.white;
            ScoreUp.enabled = false;
            ItemUse = true;
           /// InvisibleTime += 8f;
            image.enabled = true;
            
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
       
        if(ItemUse == false)
        {
            image.fillAmount -=  Time.deltaTime * 0.125f;
           /// InvisibleTime -= Time.deltaTime;
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
