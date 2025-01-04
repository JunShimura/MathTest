using UnityEngine;

[ExecuteInEditMode]
public class TransformMatrixInspector : MonoBehaviour
{
    [Header("Local Matrix (4x4)")]
    [SerializeField, TextArea(5, 10)] private string localMatrixString;

    [Header("World Matrix (4x4)")]
    [SerializeField, TextArea(5, 10)] private string worldMatrixString;

    void Update()
    {
        Matrix4x4 localMatrix = transform.localToWorldMatrix;
        Matrix4x4 worldMatrix = transform.worldToLocalMatrix;

        localMatrixString = MatrixToString(localMatrix);
        worldMatrixString = MatrixToString(worldMatrix);
    }

    private string MatrixToString(Matrix4x4 matrix)
    {
        return string.Format(
            "{0:F3}, {1:F3}, {2:F3}, {3:F3}\n{4:F3}, {5:F3}, {6:F3}, {7:F3}\n{8:F3}, {9:F3}, {10:F3}, {11:F3}\n{12:F3}, {13:F3}, {14:F3}, {15:F3}",
            matrix.m00, matrix.m01, matrix.m02, matrix.m03,
            matrix.m10, matrix.m11, matrix.m12, matrix.m13,
            matrix.m20, matrix.m21, matrix.m22, matrix.m23,
            matrix.m30, matrix.m31, matrix.m32, matrix.m33
        );
    }
}
