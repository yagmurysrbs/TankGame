
using UnityEngine;

public class mermi : MonoBehaviour
{
    public float f�rlatmah�z� = 75.0f;

    public GameObject objectPrefab;

    public AudioClip atesSesi;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = atesSesi;
        audioSource.playOnAwake = false;
    }

    void Update()
    {

        if (Input.GetKeyDown("space"))
        {

            F�rtlatmaNesnesi();
            OynatAte�Sesi();
        }

    }



    void F�rtlatmaNesnesi()
    {


        Vector3 pozisyon = transform.position;
        Quaternion rotasyon = Quaternion.identity;

        Vector3 yerely�n = transform.TransformDirection(Vector3.forward);
        Vector3 h�z = yerely�n * f�rlatmah�z�;

        GameObject newObject = Instantiate(objectPrefab, pozisyon, rotasyon);
        Rigidbody rb = newObject.GetComponent<Rigidbody>();
        rb.velocity = h�z;


    }
  
        void OynatAte�Sesi()
       {
        audioSource.PlayOneShot(atesSesi);
        //AudioSource.PlayClipAtPoint(atesSesi, transform.position);
        
        }
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�arp��ma alg�land�");
        // �arp��an nesnenin etiketini kontrol et
        if (collision.gameObject.tag == "Asker")
        {
            // Asker nesnesini yok et veya ba�ka bir i�lem yap
            Destroy(gameObject);


        }

    }
}