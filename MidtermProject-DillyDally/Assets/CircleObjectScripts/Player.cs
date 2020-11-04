using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [SerializeField] int _speed;

    [SerializeField] RuntimeData _runtimeData;

    Rigidbody2D _rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();

        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "MainMenu") {
            gameObject.SetActive(false);
        }
        Vector3 newPosition = transform.position;
        _runtimeData.PlayerPosition = newPosition;

        _runtimeData.StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "MainMenu") {
            gameObject.SetActive(false);
        }
        
        Vector3 newPosition = transform.position;
        _runtimeData.PlayerPosition = newPosition;
    }

    void FixedUpdate() {
        Movement(_speed);
    }

    void Movement(int speedTemp) {
        Vector2 newVelocity = Input.GetAxis("Horizontal") * Vector2.right * speedTemp + Input.GetAxis("Vertical") * Vector2.up * speedTemp;
        _rigidBody.velocity = newVelocity;
    }

}
