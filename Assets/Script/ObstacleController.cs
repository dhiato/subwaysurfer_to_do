using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleController : MonoBehaviour
{


    public float speed;
    private float m_TresholdPositionZ = -5.0f;
    private PlayerController m_Pc;

    private void Start()
    {
        m_Pc = GameObject
          .Find("Player")
          .GetComponent<PlayerController>();
    }

    private void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z - speed * Time.deltaTime);
       // if (Vector3.Distance(m_Pc.transform.position, transform.position) < 1.0f)
        //{
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

       // }
        //else 
        if (transform.position.z <= m_TresholdPositionZ)
        {
            Destroy(gameObject);
        }

        }
    }


