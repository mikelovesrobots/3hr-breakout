using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabRepository : MonoBehaviour
{
    public static PrefabRepository instance;
    public GameObject ballPrefab;
    public GameObject blueBlockPrefab;
    public GameObject greenBlockPrefab;
    public GameObject yellowBlockPrefab;
    public GameObject orangeBlockPrefab;
    public GameObject pinkBlockPrefab;
    public GameObject purpleBlockPrefab;
    public GameObject magentaBlockPrefab;

    void Awake()
    {
        instance = this;
    }
}
