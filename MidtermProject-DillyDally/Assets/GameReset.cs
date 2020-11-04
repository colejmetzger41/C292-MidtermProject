using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReset : MonoBehaviour
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

    void OnApplicationQuit() {
        _runtimeData.HighScore = 0;
        _runtimeData.Score = 0;
        SceneManager.LoadScene("MainMenu");
    }
}
