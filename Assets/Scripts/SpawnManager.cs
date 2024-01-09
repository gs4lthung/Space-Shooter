using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    [SerializeField]
    private GameObject _enemyContainer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Instantiate(_enemyPrefab, new Vector3(Random.Range(-8f, 8f), 7f, 0), Quaternion.identity, _enemyContainer.transform);
            yield return new WaitForSeconds(5f);
        }
    }
}
