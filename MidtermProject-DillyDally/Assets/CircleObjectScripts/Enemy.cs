using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    [SerializeField] int _enemySpeed;

    [SerializeField] RuntimeData _runtimeData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Gameplay") {
            Vector3 position1 = _runtimeData.PlayerPosition - transform.position;
            position1 = position1.normalized;
            transform.position += position1 * _enemySpeed * Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.name == "Player") {
            _runtimeData.Score = 0;
            _runtimeData.GameOverOccurrence = "KilledByEnemy";
            SceneManager.LoadScene("GameOver");            
        }
    }
}
