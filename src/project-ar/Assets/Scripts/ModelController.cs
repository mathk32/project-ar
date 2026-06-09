using UnityEngine;

public class ModelController : MonoBehaviour
{
    [Header("Model Reference")]
    [Tooltip("Drag the parent object (ex: FishFather) here to control its position/scale.")]
    [SerializeField] private Transform modelTransform;


    [Tooltip("Drag the child object containing the mesh to control the color or material.")]
    [SerializeField] private MeshRenderer modelRenderer;


    public void SetScale(float scaleValue)
    {

    }

    public void RotateModel(float yRotation)
    {

    }

    public void ChangeColor(Color newColor)
    {

    }

}
