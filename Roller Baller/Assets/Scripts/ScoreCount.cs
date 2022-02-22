using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {

    private Text scoreText;
    private int meters;

    void Awake() {
        scoreText = GameObject.Find("Score Text").GetComponent<Text>();
    }

    void Start() {
        StartCoroutine(CountScore());
    }

    IEnumerator CountScore() {

        yield return new WaitForSeconds(0.3f);

        meters++;

        scoreText.text = meters + "m";

        StartCoroutine(CountScore());

    }


}
