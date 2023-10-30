using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject obj;
    public float timeLeft = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime; //gives the amount of time elapsed
        if (timeLeft < 0)
        {
            timeLeft = 2.0f; //make sure to reset the timer
            GameObject newObj = Instantiate(obj);
            newObj.transform.position = new Vector3(-Random.value * 3, Random.value * 3, Random.value * 7);
        }
    }
}
