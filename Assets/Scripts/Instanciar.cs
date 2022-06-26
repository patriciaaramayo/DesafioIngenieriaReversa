using UnityEngine;

public class Instanciar : MonoBehaviour
{
    public GameObject prefabBala;
    public Transform positionTorreta;

    void Start()
    {     
    }

    void Update()
    {
        CrearProyectil();
    }

    void CrearProyectil()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(prefabBala, positionTorreta.position, transform.rotation);
        }   
        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(prefabBala, positionTorreta.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(prefabBala, positionTorreta.position, transform.rotation);
        } 
    }
}
