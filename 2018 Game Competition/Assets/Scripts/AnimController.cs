using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimController : MonoBehaviour
{

    public Animator anim;
    public GameObject overlay;
    public GameObject toDisable;
    public GameObject overlay2;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        overlay.SetActive(false);
        overlay2.SetActive(false);

    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            overlay.SetActive(true);

            if (overlay.activeInHierarchy == true && Input.GetKeyDown(KeyCode.E))
            {
                anim.Play("forestEndAnimation");
                toDisable.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                overlay.SetActive(false);
                overlay2.SetActive(true);  
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && overlay2.activeInHierarchy == true)
        {
            SceneManager.LoadScene("End");
        }
    }
}
