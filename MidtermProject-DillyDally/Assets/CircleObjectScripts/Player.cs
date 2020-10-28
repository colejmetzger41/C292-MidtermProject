using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [SerializeField] int _speed;

    [SerializeField] RuntimeData _runtimeData;

    // Start is called before the first frame update
    void Start()
    {

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

        Movement(_speed);
        
        Vector3 newPosition = transform.position;
        _runtimeData.PlayerPosition = newPosition;
    }

    void Movement(int speedTemp) {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += Vector3.up * speedTemp * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position += Vector3.down * speedTemp * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += Vector3.left * speedTemp * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += Vector3.right * speedTemp * Time.deltaTime;
        }
    }


}
