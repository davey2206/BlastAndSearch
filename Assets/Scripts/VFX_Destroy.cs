using UnityEngine;

public class VFX_Destroy : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 1.5f);
    }
}
