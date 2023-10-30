using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2 : MonoBehaviour
{
    //above the start function, make a timer variable
    //public float timeLeft = 2.0f;

    //public global variables create assignable slots in the editor
    //use the inspector window to drag a prefab into the slot for obj
    //public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1 / 100, 0, Time.deltaTime*10);
        if (transform.position.z > 30)
        {
            Destroy(gameObject);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Saber")
        {
            Destroy(gameObject);
        }
    }

}