using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    Animator animator;
    public float time;
    AnimatorCullingMode cullingMode;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        if (time <= 0)
        {
            cullingMode= AnimatorCullingMode.CullCompletely;
            animator.cullingMode = cullingMode;
        }
    }
}
