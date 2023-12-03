
using UnityEngine;

public class mermi : MonoBehaviour
{
    public float fýrlatmahýzý = 75.0f;

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

            FýrtlatmaNesnesi();
            OynatAteþSesi();
        }

    }



    void FýrtlatmaNesnesi()
    {


        Vector3 pozisyon = transform.position;
        Quaternion rotasyon = Quaternion.identity;

        Vector3 yerelyön = transform.TransformDirection(Vector3.forward);
        Vector3 hýz = yerelyön * fýrlatmahýzý;

        GameObject newObject = Instantiate(objectPrefab, pozisyon, rotasyon);
        Rigidbody rb = newObject.GetComponent<Rigidbody>();
        rb.velocity = hýz;


    }
  
        void OynatAteþSesi()
       {
        audioSource.PlayOneShot(atesSesi);
        //AudioSource.PlayClipAtPoint(atesSesi, transform.position);
        
        }
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Çarpýþma algýlandý");
        // Çarpýþan nesnenin etiketini kontrol et
        if (collision.gameObject.tag == "Asker")
        {
            // Asker nesnesini yok et veya baþka bir iþlem yap
            Destroy(gameObject);


        }

    }
}