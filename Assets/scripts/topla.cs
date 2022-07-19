using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topla : MonoBehaviour
{
    bool topladiMi;
    int index ;
    public toplayici toplayici;
    // Start is called before the first frame update
    void Start()
    {
        topladiMi = false;
    }

    // Update is called once per frame
    void Update()
    {if(topladiMi== true)
    {
        if(transform.parent != null)
        {
        
        transform.localPosition = new Vector3 (0, -index,0);
        }
       }
    }
    
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "engel"){
            toplayici.yukseklikazalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public bool GettopladiMi()
    {
        return topladiMi;
    }
    public void toplandiYap(){
     topladiMi = true ;
    } 
    public void IndexAyarla(int index){
        this.index = index;
    }
}
