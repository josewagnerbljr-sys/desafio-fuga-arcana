using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject obstaculoPrefab;
    public float tempoSpawn = 1.5f;
    private float timer = 0f;
    private int pontos = 0;
    
    public Text textoPontos; 

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > tempoSpawn)
        {
            float posicaoY = Random.Range(-2f, 2f);
            Instantiate(obstaculoPrefab, new Vector3(8f, posicaoY, 0), Quaternion.identity);
            timer = 0;
        }
    }

    public void AdicionarPonto()
    {
        pontos++;
        textoPontos.text = "Sigilos: " + pontos;
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
