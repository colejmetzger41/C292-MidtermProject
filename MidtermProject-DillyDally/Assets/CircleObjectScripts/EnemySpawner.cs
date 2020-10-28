using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{

    float _xMin;
    float _xMax;
    float _yMin;
    float _yMax;

    [SerializeField] GameObject _enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        _xMin = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0)).x;
        _xMax = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0)).x;
        _yMin = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0)).y;
        _yMax = Camera.main.ViewportToWorldPoint(new Vector3(0,1,0)).y;

        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Gameplay") {
            InvokeRepeating("SpawnEnemy", 2f, 3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy() {
        float randX = Random.Range(_xMin, _xMax);
        float randY = Random.Range(_yMin, _yMax);
        Instantiate(_enemyPrefab, new Vector3(randX, randY, 0), Quaternion.identity);
    }
}
