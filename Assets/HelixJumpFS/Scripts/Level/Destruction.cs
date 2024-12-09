using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : BallEvents
  {
    private Animator animator;
    
    private Transform ballTransform;

    protected override void Awake()
    {
        ballController = FindObjectOfType<BallController>();//������� ���������� �� �����
        base.Awake();
    }
    private void Start()
    {
        
        animator = GetComponent<Animator>();
        ballTransform = ballController.transform;
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type == SegmentType.Empty && ballTransform.position.y <= transform.position.y) // ��������� ������� ���� � �����
        {
            animator.enabled = true;
            Destroy(gameObject, 2f);
        }
    }
}
