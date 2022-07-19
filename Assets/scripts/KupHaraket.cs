using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KupHaraket : MonoBehaviour
{
    [SerializeField]
    private float ileriHiz;
    [SerializeField]
    private float yanHiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal") * yanHiz * Time.deltaTime;
        this.transform.Translate (yatay,0,ileriHiz * Time.deltaTime);
    }
}
