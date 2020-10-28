using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Runtime Data")]
public class RuntimeData : ScriptableObject
{
   public Vector3 PlayerPosition;

   public int Score;

   public int HighScore;

   public string GameOverOccurrence;

   public float StartTime;

   public float EndTime; 

}
