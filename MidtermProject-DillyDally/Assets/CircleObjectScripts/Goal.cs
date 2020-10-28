using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

    [SerializeField] RuntimeData _runtimeData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.name == "Player") {
            _runtimeData.EndTime = Time.time;
            _runtimeData.Score = (int)(_runtimeData.EndTime - _runtimeData.StartTime);
            if (_runtimeData.Score > _runtimeData.HighScore) {
                _runtimeData.HighScore = _runtimeData.Score;
            }
            _runtimeData.GameOverOccurrence = "WonByReachingGoal";
            SceneManager.LoadScene("GameOver");
        }
    }
}
