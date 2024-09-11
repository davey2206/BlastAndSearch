using System.Collections;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;

public class Recenter : MonoBehaviour
{
    [SerializeField] XROrigin Origin;
    [SerializeField] Transform Target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        RecenterPlayer();
    }

    void RecenterPlayer()
    {
        Origin.MoveCameraToWorldLocation(Target.position);
        Origin.MatchOriginUpCameraForward(Target.up, Target.forward);
    }
}
