using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling_script : MonoBehaviour
{
    public float move_scale = 5f;
    Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp = transform.localScale;
        temp.x += Time.deltaTime;

        if (temp.x < 5)
        {
            transform.localScale = temp;
        }
        else
        {
            Debug.Log(transform.localScale.x);
        }
    }
}
