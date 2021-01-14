using UnityEngine;
using UnityEngine.EventSystems;
public class Ships : MonoBehaviour,  IDragHandler
{
    public GameObject _ships;
    GameObject _ammo;
    public GameObject _Dozor;
    Vector3 std;
    float timerAmmo, TimerLaser=1f;
    private Rigidbody2D _rb;

   
    public void OnDrag(PointerEventData eventData)
    {
        std = Input.mousePosition;        
        std = Camera.main.ScreenToWorldPoint (std);
        std.z = 0f;
        _ships.transform.position = std;        
    }
    private void Update()
    { 
        if (timerAmmo <= 0 && money.ammo)
        {            
            _ammo.transform.position = new Vector3(_ships.transform.position.x-0.01f, _ships.transform.position.y + 1f);            
            Instantiate(_ammo).GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 1) * 0.05f);             
            timerAmmo = money.speedAmmo; 
        }
        else if (money.ammo)
            timerAmmo -= Time.deltaTime;
        if (money.TripleLaser && TimerLaser <= 0)
        {
            _ammo.transform.position = new Vector3(_ships.transform.position.x + 0.41f, _ships.transform.position.y+0.4f);
            Instantiate(_ammo).GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 1) * 0.1f);
            _ammo.transform.position = new Vector3(_ships.transform.position.x - 0.5f, _ships.transform.position.y+0.4f );
            Instantiate(_ammo).GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 1) * 0.1f);
            TimerLaser = money.SpeedLaser;
        }
        else if (money.TripleLaser)
            TimerLaser -= Time.deltaTime;
    }
    private void Start()
    {
        _ammo = money.Bullet;
    }
}
