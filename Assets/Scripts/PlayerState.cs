using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
public class PlayerState : MonoBehaviour
{
    public bool isGrounded;
    public bool isMoving;
    public bool isFalling;
    private CapsuleCollider capsuleCollider;
    private void Awake()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
    }

    private void Update()
    {
        Ray ray = new(transform.position + Vector3.up * 0.25f, Vector3.down);
        if (Physics.Raycast(ray, out RaycastHit hit, 0.3f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        isFalling = !isGrounded;
    }
}
