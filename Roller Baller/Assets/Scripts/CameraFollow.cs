using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    private GameObject player;
    public float offset = 3f;

    void Awake() {
        player = GameObject.FindWithTag("Player");
    }

    void FixedUpdate() {

        Vector3 temp = transform.position;
        temp.x = player.transform.position.x - offset;
        transform.position = temp;

    }



} // class



