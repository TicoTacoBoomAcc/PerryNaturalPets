using System.Collections;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public LayerMask solidObjectsLayer;

    Rigidbody rb;
    private bool isMoving;
    private Vector3 input;

    private Animator animator;

    private Vector3 _targetPos;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.z = Input.GetAxisRaw("Vertical");

            //remove diagonal shit
            if (input.x != 0) input.z = 0;

            if (input != Vector3.zero)
            {
                animator.SetFloat("moveX", input.x);
                animator.SetFloat("moveZ", input.z);

                var targetPos = transform.position;
                targetPos.x += input.x;
                targetPos.z += input.z;

                if (IsWalkable(targetPos)) StartCoroutine(Move(targetPos));
            }
            animator.SetBool("isMoving", isMoving);
        }
    }

    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;

        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;

        isMoving = false;
    }

    private bool IsWalkable(Vector3 targetPos)
    {
        _targetPos = targetPos;
        if (Physics.OverlapSphere(targetPos, 0.3f, solidObjectsLayer).Length > 0)
        {
            return false;
        }

        return true;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(_targetPos, 0.3f);
    }
}
