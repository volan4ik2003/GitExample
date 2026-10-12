using System.Collections;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI DeadText;

    public CharacterCOntroller CC;

    void OnEnable()
    {
        CC.OnCharacterDied += ShowDeadText;
    }

    public void ShowDeadText()
    {
        StartCoroutine(ShowTextCoroutine());
    }

    private IEnumerator ShowTextCoroutine()
    {
        DeadText.gameObject.SetActive(true);

        yield return new WaitForSeconds(5);

        DeadText.gameObject.SetActive(false);
    }

    void OnDisable()
    {
        CC.OnCharacterDied -= ShowDeadText;
    }
}
