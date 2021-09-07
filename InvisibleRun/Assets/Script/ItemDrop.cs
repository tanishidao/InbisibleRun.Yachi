using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public GameObject Item;

    private float time = 0f;
    private float DropInterval;
    private int LevelUp = 0;
    private bool cancel = false;
    public float MaxTime;
    public float MinTime;


    void Start()
    {
        DropInterval = GetRandomTime();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > DropInterval)
        {
            Debug.Log("ƒAƒCƒeƒ€‚Í‚Á‚¹‚¤");
            GameObject Items = Instantiate(Item);
            Item.transform.position = new Vector2(10f, 2f);

            time = 0f;
            DropInterval = GetRandomTime();
        }
        if (LevelUp == 0 && Score.Instance.Scores > 20000)
        {

            MaxTime = 12f;
            MinTime = 10f;
        }
        if (cancel == true && Score.Instance.Scores > 100000)
        {
            Debug.Log("levelUp2");
            MaxTime = 16f;
            MinTime = 15f;
            LevelUp = 1;
        }
        if (LevelUp > 1 && Score.Instance.Scores > 500000)
        {
            cancel = true;
            MaxTime = 21f;
            MinTime = 20f;
        }
    }

    private float GetRandomTime()
    {
        return Random.Range(MinTime, MaxTime);
    }



}
