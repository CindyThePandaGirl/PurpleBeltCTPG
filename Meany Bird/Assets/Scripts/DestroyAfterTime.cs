using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    //After this time, the object wi;; be destroyed
    [Header("Default Destruction Time")]
    public float timeToDestruction;

    // Start is called before the first frame update
    void Start()
    {
        //Execute Destroy Object function based on timeToDestruct
        Invoke("DestroyObject", timeToDestruction);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // This function will destroy this object
    void DestroyObject()
    {
        Destroy(gameObject);
    }
}

