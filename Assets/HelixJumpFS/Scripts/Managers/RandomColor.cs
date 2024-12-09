
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColor : MonoBehaviour
{
    [SerializeField] private MeshRenderer axisMeshRenderer;
    [SerializeField] private MeshRenderer ballMeshRenderer;
    [SerializeField] private Image backgroundColor;
    [SerializeField] private Material defaultColor;
    [SerializeField] private SpriteRenderer blobColor;
    [SerializeField] private List<Color> colorList = new List<Color>();
    

    private void Start()
    {
        if (axisMeshRenderer != null)
        {
            int randomInt = Random.Range(0, colorList.Count);
            axisMeshRenderer.material.color = colorList[randomInt];
            
           
        }
        if (ballMeshRenderer != null)
        {
            int randomInt = Random.Range(0, colorList.Count);
            ballMeshRenderer.material.color = colorList[randomInt];
            blobColor.color = ballMeshRenderer.material.color;    
        }
        if (backgroundColor != null)
        {
            int randomInt = Random.Range(0, colorList.Count);
            backgroundColor.color = colorList[randomInt];
        }
        
        if (defaultColor != null)
        {
            int randomInt = Random.Range(0, colorList.Count);
            defaultColor.color = colorList[randomInt];
        }
    }
    
}
