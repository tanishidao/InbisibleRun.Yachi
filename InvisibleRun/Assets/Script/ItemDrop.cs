using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public GameObject Item;

    private float time = 0f;
    private float DropInterval;

    public float MaxTime;
    public float MinTime = 5f;


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
    }

    private float GetRandomTime()
    {
        return Random.Range(MinTime, MaxTime);
    }



}
