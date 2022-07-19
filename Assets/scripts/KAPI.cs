using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KAPI : MonoBehaviour
{ public string sonrakiLevel;
    
   
    
     void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "carpısma"){
            PlayerPrefs.SetInt (sonrakiLevel,1);
            Debug.Log(sonrakiLevel+"Açıldı");
            SceneManager.LoadScene("GIRIS");        }
     }
    }

