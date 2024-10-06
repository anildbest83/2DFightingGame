using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    public float timeBetweenSpawn = 2f;

    bool canSpawn = true;

    private void Update()
    {
        if (canSpawn)
        {
            StartCoroutine(Spawn());
        }
    }

    IEnumerator Spawn()
    {
        canSpawn = false;
        yield return new WaitForSeconds(timeBetweenSpawn);
        int enemySelected = Random.Range(1, 10);
        if (enemySelected >= 5)
            Instantiate(enemyPrefabs[0], transform.position, transform.rotation);
        else
            Instantiate(enemyPrefabs[1], transform.position, transform.rotation);
        canSpawn = true;
    }
}
