using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject targetPrefab;


    public void SpawnTarget()
    {
        Instantiate(targetPrefab, new Vector3(0, 20, 0), Quaternion.identity);
    }
}
