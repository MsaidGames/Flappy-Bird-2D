using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;

    void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator SpawnPipes()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            float rand = Random.Range(-3.5f, 1);
            GameObject newPipe = Instantiate(Pipes, new Vector3(2, rand, 0), Quaternion.identity);
            Destroy(newPipe, 10);
        }
    }
}
