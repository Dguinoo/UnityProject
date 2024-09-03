using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndNote : MonoBehaviour
{
    [SerializeField] GameObject Note;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Start the coroutine to wait and then show the note
            StartCoroutine(ShowNoteAfterDelay(3f));
        }
    }

    private IEnumerator ShowNoteAfterDelay(float delay)
    {
        // Wait for the 3 seconds to show the note
        yield return new WaitForSeconds(delay);

        Note.SetActive(true);

        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Main Menu");

    }
}
