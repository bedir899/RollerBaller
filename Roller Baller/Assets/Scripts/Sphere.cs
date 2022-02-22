using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

    Rigidbody myBody;

    public float gravity = 100f;
    public float forwardSpeed = 10f;

    public float moveZ;
    public float moveSpeed = 10f;

    private RoadSpawner roadSpawner;

    void Awake() {
        myBody = GetComponent<Rigidbody>();

        // get road spawner
        roadSpawner = GameObject.Find("Road Spawner").GetComponent<RoadSpawner>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() {

        if(Input.GetAxisRaw("Horizontal") > 0f) {

            moveZ -= moveSpeed * Time.deltaTime;

        } else if (Input.GetAxisRaw("Horizontal") < 0f) {

            moveZ += moveSpeed * Time.deltaTime;

        } else {

            moveZ = 0f;
            
        }

        if(transform.position.y < -3f) {

            UnityEngine.SceneManagement.SceneManager.LoadScene(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);

        }

    }

    void FixedUpdate() {

        myBody.velocity = new Vector3(forwardSpeed, 0f, moveZ);
        myBody.AddForce(new Vector3(0f, -gravity, 0f) * myBody.mass);

    }

    void OnTriggerEnter(Collider target) {

        if(target.tag == "Create") {
            roadSpawner.MakeRoad();
        }

    }

    void OnCollisionEnter(Collision target) {


        if(target.gameObject.tag == "Cube") {

            UnityEngine.SceneManagement.SceneManager.LoadScene(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);

        }


    }


} // class
































