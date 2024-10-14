using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f; // Velocidad del auto
    public Transform leftWheel; // Referencia a la rueda izquierda
    public Transform rightWheel; // Referencia a la rueda derecha

    void Update()
    {
        // Mueve el auto en el eje X
        float move = speed * Time.deltaTime;
        transform.position += new Vector3(move, 0, 0);

        // Rota las ruedas
        RotateWheels(move);
    }

    void RotateWheels(float distance)
    {
        // Suponiendo que el radio de la rueda es 0.5 (ajusta según sea necesario)
        float wheelRadius = 0.5f;
        float rotationAngle = (distance / (2 * Mathf.PI * wheelRadius)) * 360;

        // Rota ambas ruedas
        leftWheel.Rotate(Vector3.right, rotationAngle);
        rightWheel.Rotate(Vector3.right, rotationAngle);
    }

}
