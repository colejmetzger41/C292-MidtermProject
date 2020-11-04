using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestoryObstacle", 7f);
    }

    void DestoryObstacle() {
        Destroy(gameObject);
    }
}
