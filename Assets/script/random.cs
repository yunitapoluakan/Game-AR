using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{

    public GameObject[] objects;

    void Start(){
        int rand = Random.Range(0,objects.Length);
    }
   
}
