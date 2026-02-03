using UnityEngine;

public class MyCharacterScriptController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float speed = 5.0f;
    Vector3 movement;
    Animator animator;
    private CharacterController characterController;

    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if (movement.magnitude > 0)
        {
            Debug.Log("Walking");
            animator.SetFloat("Speed", 1f);
            //transform.rotation = Quaternion.LookRotation(movement);
            transform.Translate(movement.normalized * speed * Time.deltaTime, Space.World);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    animator.SetTrigger("Jump");
        //}
    }
}
