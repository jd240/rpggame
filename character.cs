using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class character : MonoBehaviour
{
    protected Vector3 moveDelta;
    public Animator animate;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        if (moveDelta.x > 0)
            transform.localScale = Vector3.one;
        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);
        //making thing actually move
        transform.Translate(moveDelta * Time.deltaTime);
        //turn the character to face the correct way while iddle
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            animate.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            animate.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }

    }
}
