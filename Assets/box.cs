using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class box : MonoBehaviour
{

    public float speed = -1;
    public float direction = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementSpeed = speed * Time.deltaTime * direction;
        transform.Translate(-movementSpeed, 0, 0); ;
    }
}
