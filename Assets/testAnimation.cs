using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testAnimation : MonoBehaviour
{

   public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
      //anim = gameObject.GetComponent<Animation>();

    }

    // Update is called once per frame
    //petiteBoucle
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.M))
      {
      Debug.Log("Spinning");
      anim.Play("Sprint");
      }
    }
}
