using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
  public float speed = 1000000;
  void FixedUpdate ()
  {
      //get the horizontal input
      float h = Input.GetAxisRaw("Horizontal");
      //now we are going to set the velocity
      GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;

  }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
