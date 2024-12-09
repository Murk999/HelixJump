using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BlobPrint : BallEvents
{
    [SerializeField] private GameObject blobPrefab; // добавл€етс€ префаб капли
    [SerializeField] private GameObject ball; // добавл€етс€ обьект м€ч
    [SerializeField] private GameObject level; // добавл€етс€ уровень 

    protected override void OnBallCollisionSegment(SegmentType type)
    {
       if (type != SegmentType.Empty) // если сегмент не пустота 
       {
            Instantiate(blobPrefab, new Vector3(ball.transform.position.x, ball.transform.position.y + 0.51f, ball.transform.position.z), Quaternion.Euler(90, Random.Range(0, 360), 0), level.transform); // public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)  
       }
    } 
}
