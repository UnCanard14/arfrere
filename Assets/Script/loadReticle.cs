using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class loadReticle : MonoBehaviour
{
  public Camera cam;
  private float loadRe = 0.0f;
  public float loadReSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
      //UI.Image.fillAmount = 0.50;
    //  GetComponent<Image>().fillAmount = 0.50f;
    }

    // Update is called once per frame
    void Update()
    {
      Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
      RaycastHit hit;
      if (Physics.Raycast(ray, out hit)){
        print("I'm looking at " + hit.transform.name);
        if(loadRe <= 1){
          loadRe = (float) (loadRe + loadReSpeed);
          GetComponent<Image>().fillAmount = loadRe;
        }
      }else{
        print("I'm looking nothing");
        if(loadRe >= 0){
          loadRe = (float) (loadRe - loadReSpeed);
          GetComponent<Image>().fillAmount = loadRe;
        }
      }
    }
}
