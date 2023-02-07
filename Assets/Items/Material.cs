using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material : MonoBehaviour
{

    public float fpower = 50f;

    public float power = 20f;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (power < 20)
        {
            Debug.Log("Hi");
        }
            
    }
}
