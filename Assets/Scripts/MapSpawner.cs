using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> _mapVariants;

    private int _mapVariantIndex;

    public Transform _startSpawnPosition;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SpawnBoard")
        {
            SpawnMapPart();
        }
        if (other.gameObject.tag == "Destroyable")
        {
            Destroy(other.gameObject);
            Debug.Log("CanDestroy!");
        }
    }

    private void SpawnMapPart()
    {
        _mapVariantIndex = UnityEngine.Random.Range(0, _mapVariants.Count);
        GameObject mapObject = Instantiate(_mapVariants[_mapVariantIndex], _startSpawnPosition.transform.position, Quaternion.identity);
        _startSpawnPosition = mapObject.transform.Find("PointOfSpawn").transform;
        _mapVariants[_mapVariantIndex].transform.position = _startSpawnPosition.localPosition;
    }
}
