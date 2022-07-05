using System.Collections;
using UnityEngine;
using TMPro;

public class DragNDropItem : MonoBehaviour
{
    public string itemName;
    private bool dragging;
    private Vector2 firstPos;
    private Color spriteRenderer;
    [SerializeField] private float speed = 3;
    [SerializeField] private GameObject boiler;
    public TMP_Text itemNameText;
    private BoilerScript boilerScript;
    public AudioSource drop;

    void Awake()
    {
        // E�yan�n ilk konumu
        firstPos = transform.position;
        boiler = GameObject.FindGameObjectWithTag("Boiler");
        boilerScript = boiler.GetComponent<BoilerScript>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>().color;

    }
    void OnMouseDown()
    {
        dragging = true;
    }
    void OnMouseUp()
    {
        dragging = false;
        if (Vector2.Distance(transform.position, boiler.transform.position) < 0.7f) // Collider kullanmadan e�ya ve kazan aras�ndaki mesafeyi kontrol ediyoruz.
        {
            itemNameText.text = itemName;
            boilerScript.Potion(); // Her e�ya yerle�ti�inde tarifin tamamlanma durumunu kontrol eder.
            spriteRenderer.a = 0f;
            gameObject.GetComponent<SpriteRenderer>().color = spriteRenderer;
            StartCoroutine(Alpha());
        }
        else drop.Play(); // E�ya b�rak�l�rsa
    }

    void Update()
    {
        if (dragging) // Mouse ile e�yaya t�kland��� anda e�ya mouse'� takip eder.
        {
            Vector2 mousePosition = MousePos();
            transform.position = Vector2.Lerp(transform.position, mousePosition, speed * Time.deltaTime);
        } else if (!dragging && (Vector2)transform.position != firstPos) // T�klamay� b�rakt���m�z anda eski yerine g�t�r�r. E�ya orjinal konumundayken s�rekli kodun �al��mas�n� engelliyoruz.
        {
            transform.position = Vector2.Lerp(transform.position, firstPos, speed * Time.deltaTime);
        }
    }

    Vector2 MousePos() // Mouse'�n konumu
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private IEnumerator Alpha() // Bir saniye sonra e�ya g�r�n�r oluyor.
    {
        spriteRenderer.a = 1f;
        yield return new WaitForSeconds(0.6f);
        gameObject.GetComponent<SpriteRenderer>().color = spriteRenderer;
    }

}
