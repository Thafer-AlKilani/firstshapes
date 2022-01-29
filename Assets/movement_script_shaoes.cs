using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_script_shaoes : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, speed * Time.deltaTime, 0);


        if (transform.position.x > 5 || transform.position.y > 7 )
        {
            Debug.Log(transform.position.x);
            transform.Translate(-10, -10, 0);
        }
    }
}
