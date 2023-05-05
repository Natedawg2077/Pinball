using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    private float mouseposX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the paddle left and right based on user input
        //mouseposX = Input.mousePosition.x;
        //this.transform.position.x = mouseposX;
        this.Transform.position.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
    }
}
