using UnityEngine;
using UnityEngine.Animations;

public class Elevator : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void bruh()
    {
        animator.SetTrigger("Elevator");
    }
}
