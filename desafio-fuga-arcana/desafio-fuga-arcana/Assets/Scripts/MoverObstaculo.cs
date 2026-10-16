using UnityEngine;

public class MoverObstaculo : MonoBehaviour
{
    public float velocidade = 3f;

    void Update()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;

        if (transform.position.x < -10f)
        {
            FindObjectOfType<GameManager>().AdicionarPonto();
            Destroy(gameObject);
        }
    }
}