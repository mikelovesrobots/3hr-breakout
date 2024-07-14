using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public float blockWidth = 0.79875f;
    public float blockHeight = 0.3f;
    public float bottomRowY = -0.7770949f;
    public int blocksPerRow = 16;
    public Transform blockParent;

    private void Start()
    {
        SpawnBlocks();
    }

    public void SpawnBlocks()
    {
        var prefabs = new[]
        {
            PrefabRepository.instance.blueBlockPrefab,
            PrefabRepository.instance.greenBlockPrefab,
            PrefabRepository.instance.yellowBlockPrefab,
            PrefabRepository.instance.orangeBlockPrefab,
            PrefabRepository.instance.pinkBlockPrefab,
            PrefabRepository.instance.purpleBlockPrefab,
            PrefabRepository.instance.magentaBlockPrefab
        };

        for (int row = 0; row < prefabs.Length; row++)
        {
            var prefab = prefabs[row];
            for (int column = 0; column < blocksPerRow; column++)
            {
                var position = new Vector3(
                    column * blockWidth - ((blocksPerRow - 1) * blockWidth / 2),
                    bottomRowY + row * blockHeight,
                    0
                );
                var instance = Instantiate(prefab, position, Quaternion.identity);
                instance.transform.parent = blockParent;
            }
        }
    }
}
