using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed = 4f;
    [SerializeField] private int _healthPoint = 3;
    [SerializeField] private GameObject _backGroundPreafab;
    
    private bool _isDeaed = false;

    float _move = 0f;
    private float _timeToHardUp = 15f;
    private Camera _camera;
    private int _points = 0;


 

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _camera = Camera.main;
        StartCoroutine(hardUp());
    }


    void Update()
    {
        _move = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        _camera.transform.position = new Vector3(transform.position.x, 0, -10);
        _rb.transform.position += new Vector3(1, 0, 0) * _speed * Time.fixedDeltaTime;
        _rb.transform.position += new Vector3(0, _move, 0) * _speed * Time.fixedDeltaTime;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "obstacle(Clone)" || hitInfo.name == "obstacle2(Clone)" || hitInfo.name == "Glass" || hitInfo.name == "Glass(Clone)" ||
                hitInfo.name == "obstacle")
        {
            //_isDeaed = true;
            //Destroy(gameObject);
            Die();
        }

        if (hitInfo.name == "bottle")
        {
            Destroy(hitInfo.gameObject);
            _points++;
        }
        else if (hitInfo.name == "enemy")
        {
            // load menu scene
            SceneManager.LoadScene("Death");
           

        }
        else if(hitInfo.name == "WhenCollisionSpawnPoint")
        {

            // этот else if это такой КОСТЫЛЬ что просто нахуй жопа, такого костыля я ещё не делал)
            Instantiate(_backGroundPreafab, new Vector3(transform.position.x + 18.48f, 0.2328765f, 0), Quaternion.identity);
        }
        
            
    }


    public void takeDamage(int damage)
    {
        _healthPoint -= damage;
        if (_healthPoint <= 0)
        {
            Die();
        }

    }

    private void Die()
    {
        _isDeaed = true;
        SceneManager.LoadScene("Death");
        Destroy(gameObject); 
    }

    public float getSpeed()
    {
        return _speed;
    }

    public float getPosition()
    {
        return transform.position.x;
    }

    IEnumerator hardUp()
    {
        yield return new WaitForSeconds(_timeToHardUp);
        while(true)
        {
            _speed += 1f;
            yield return new WaitForSeconds(_timeToHardUp);
        }
    }

    public int getPoints()
    {
        return _points;
    }

    public bool getState()
    {
        return _isDeaed;
    }

    public int getHp()
    {
        return _healthPoint;
    }

}
