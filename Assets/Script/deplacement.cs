﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour
{

  public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.Z))
      transform.Translate(Vector3.forward * Time.deltaTime * speed);

      if(Input.GetKey(KeyCode.S))
      transform.Translate( -1 * Vector3.forward * Time.deltaTime * speed);

      if(Input.GetKey(KeyCode.Q))
      transform.Rotate(0,-1,0);

      if(Input.GetKey(KeyCode.D))
      transform.Rotate(0,1,0);
    }
}
