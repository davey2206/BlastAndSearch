using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController Player;
    [SerializeField] GameObject LHand;
    [SerializeField] GameObject RHand;
    [SerializeField] float Speed = 2;

    bool move = false;

    // Update is called once per frame
    void Update()
    {
        
        if (move)
        {
            Vector3 dir = RHand.transform.position - LHand.transform.position;
            dir.Normalize();
            dir = new Vector3(dir.x, 0, dir.z);

            Player.Move(dir * Time.deltaTime * Speed);
        }
    }

    public void EnableMove()
    {
        move = true;
    }

    public void DisableMove()
    {
        move = false;
    }
}
