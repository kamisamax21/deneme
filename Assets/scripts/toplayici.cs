 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    


public class toplayici : MonoBehaviour
{ public GameObject kup;
int yukseklik;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        kup.transform.position=new Vector3(transform.position.x, yukseklik + 1 ,transform.position.z);
    this.transform.localPosition = new Vector3 (0,-yukseklik,0);
        
    }
    public void yukseklikazalt()
    {
        yukseklik--;
    }
     private void OnTriggerEnter(Collider other)
      {
        if(other.gameObject.tag=="toplama"&&other.gameObject.GetComponent<topla>().GettopladiMi() == false) 
        {
            yukseklik += 1;
            other.gameObject.GetComponent<topla>().toplandiYap();
            other.gameObject.GetComponent<topla>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent=kup.transform;

        }
    }
}
