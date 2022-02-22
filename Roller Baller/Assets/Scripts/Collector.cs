using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{


    void OnTriggerEnter(Collider target) {

        if(target.tag == "Road" || target.tag == "Cube") {
            target.gameObject.SetActive(false);
        }

    }


}
