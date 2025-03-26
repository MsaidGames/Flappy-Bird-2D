using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;

    void Start()
    {
        StartCoroutine(SpawnPipes());
    }


    IEnumerator SpawnPipes()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            float rand = Random.Range(-4f, 2f);
            GameObject newPipe = Instantiate(Pipes, new Vector3(2, rand, 0), Quaternion.identity);
            Destroy(newPipe, 10);
        }
    }
}
