using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the paddle left and right based on user input
        transform.Translate(Time.deltaTime * Input.GetAxis("Horizontal") * 20.0f, 0, 0);
    }
}
