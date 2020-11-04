using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoalSpawner : MonoBehaviour
{
    float _xMin;
    float _xMax;
    float _yMin;
    float _yMax;

    float _playerPositionX;
    float _playerPositionY;

    float _playerRadius;
    float _goalRadius;

    [SerializeField] GameObject _goalPrefab;

    // Start is called before the first frame update
    void Start()
    {
        _playerRadius = 1;
        _goalRadius = 2;
        _playerPositionX = 5;
        _playerPositionY = -2;

        _xMin = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0)).x;
        _xMax = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0)).x;
        _yMin = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0)).y;
        _yMax = Camera.main.ViewportToWorldPoint(new Vector3(0,1,0)).y;

        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Gameplay") {
            Invoke("SpawnGoal", 0);
        }
    }

    void SpawnGoal() {
        float randX = 0;
        float randY = 0;
        float buffer = 2;
        bool distanceFrom = false;
        while(!(distanceFrom)) {
            randX = Random.Range(_xMin, _xMax);
            randY = Random.Range(_yMin, _yMax);
            float distance = Mathf.Sqrt(Mathf.Pow(randX - _playerPositionX, 2) + Mathf.Pow(randY - _playerPositionY, 2));
            distanceFrom = distance > (_playerRadius + _goalRadius + buffer);
        }
        Instantiate(_goalPrefab, new Vector3(randX, randY, 0), Quaternion.identity);
    }
}
