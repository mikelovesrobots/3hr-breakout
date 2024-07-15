using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
  public GameObject ballPrefab;
  public Transform spawnPoint;

  public void LaunchBall()
  {
    Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
  }
}
