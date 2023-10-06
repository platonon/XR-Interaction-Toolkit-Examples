using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float movementSpeed; // �������� �������� �������
    public float returnPositionZ; // ���������� Z, ��� ���������� ������� ������ ������������ � ��������� �������

    private Vector3 initialPosition; // ��������� ������� �������

    void Start()
    {
        initialPosition = transform.position; // ��������� ��������� ������� �������
    }

    void Update()
    {
        // ������� ������ ������ �� ��� X
        transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);

        // ���� ���������� Z ������� �� ������� returnPositionZ, ���������� ������ � ��������� �������
        if (transform.position.z < returnPositionZ)
        {
            // ���������� ������ � ��������� ������� �� X � Z
            transform.position = new Vector3(initialPosition.x, initialPosition.y, initialPosition.z);
        }
    }
}

