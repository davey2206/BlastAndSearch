using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : MonoBehaviour
{
    [SerializeField] List<Transform> Spots;
    [SerializeField] GameObject Cube;
    [SerializeField] Rigidbody Rb;
    [SerializeField] GameObject VFX;

    public void Hide()
    {
        int rng = Random.Range(0, Spots.Count);
        Cube.transform.position = Spots[rng].transform.position;
    }

    public void FindObject()
    {
        Hide();
        Rb.useGravity = true;
        Instantiate(VFX, Cube.transform.position, Quaternion.identity);
    }
}
