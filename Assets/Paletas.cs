using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float speed =7f;
    [SerializeField] private bool palaD;

    // Update is called once per frame
    void Update()
    {

        float movement;
        if (palaD)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        transform.position += new Vector3(0, movement * speed * Time.deltaTime, 0);
       
        
    }
}
