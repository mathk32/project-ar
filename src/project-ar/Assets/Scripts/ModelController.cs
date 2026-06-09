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
        if (modelTransform != null)
        {
            modelTransform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
        }
    }

    public void RotateModel(float yRotation)
    {
        if (modelTransform != null)
        {
            modelTransform.localRotation = Quaternion.Euler(0f, yRotation, 0f);
        }
    }

    public void ChangeColor(string colorName)
    {
        Color newColor = Color.white; 

        switch (colorName.ToLower())
        {
            case "blue": newColor = Color.blue; break;
            case "red": newColor = Color.red; break;
            case "green": newColor = Color.green; break;
            case "yellow": newColor = Color.yellow; break;
        }

        if (modelRenderer != null)
        {
            foreach (Material mat in modelRenderer.materials)
            {
                mat.color = newColor;
            }
        }
    }

    [ContextMenu("Test: Double Scale")]
    private void TestScale() => SetScale(0.6f);

    [ContextMenu("Test: Rotate 45 degrees")]
    private void TestRotation() => RotateModel(45f);

    [ContextMenu("Test: Turn Blue")]
    private void TestColor() => ChangeColor("blue");

}
