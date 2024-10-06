using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float activateSpawnerTimer = 10f;

    public GameObject[] spawners;

    private bool spawner2;
    private bool spawner3;
    private bool spawner4;

    private void Update()
    {
        StartCoroutine(ActivateSpawnPointCounter());

        if (spawner2)
        {
            spawners[1].SetActive(true);
        }
        if (spawner3)
        {
            spawners[2].SetActive(true);
        }
        if (spawner4)
        {
            spawners[3].SetActive(true);
        }
    }

    IEnumerator ActivateSpawnPointCounter()
    {
        yield return new WaitForSeconds(activateSpawnerTimer);
        if (!spawner2)
        {
            spawner2 = true;
        }
        yield return new WaitForSeconds(activateSpawnerTimer);
        if (!spawner3)
        {
            spawner3 = true;
        }
        yield return new WaitForSeconds(activateSpawnerTimer);
        if (!spawner4)
        {
            spawner4 = true;
        }
    }
}
