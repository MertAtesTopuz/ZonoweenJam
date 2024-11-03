using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class Elevator : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SceneChanger()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void bruh()
    {
        animator.SetTrigger("Elevator");
    }
}
