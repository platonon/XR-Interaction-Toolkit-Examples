using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float movementSpeed; // Скорость движения объекта
    public float returnPositionZ; // Координата Z, при достижении которой объект возвращается в начальную позицию

    private Vector3 initialPosition; // Начальная позиция объекта

    void Start()
    {
        initialPosition = transform.position; // Сохраняем начальную позицию объекта
    }

    void Update()
    {
        // Двигаем объект вправо по оси X
        transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);

        // Если координата Z выходит за пределы returnPositionZ, возвращаем объект в начальную позицию
        if (transform.position.z < returnPositionZ)
        {
            // Возвращаем объект в начальную позицию по X и Z
            transform.position = new Vector3(initialPosition.x, initialPosition.y, initialPosition.z);
        }
    }
}

