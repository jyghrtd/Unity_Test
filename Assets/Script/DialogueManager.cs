using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour, IPointerDownHandler
{
    public Text dialogueText;
    public GameObject NextText;
    public CanvasGroup dialogueGroup;

    public Queue<string> sentences;

    private string currentSentence;

    public float TypingSpeed = 0.01f;
    private bool isTyping;

    public static DialogueManager instance;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void Ondialogue(string[] lines)
    {
        sentences.Clear();
        foreach (string line in lines)
        {
            sentences.Enqueue(line);
        }
        dialogueGroup.alpha = 1;
        dialogueGroup.blocksRaycasts = true;

        NextSentence();
    }

    public void NextSentence()
    {
        if (sentences.Count != 0)
        {
            currentSentence = sentences.Dequeue();
            //코루틴.
            isTyping = true;
            NextText.SetActive(false);
            StartCoroutine(Typing(currentSentence));
        }

        else
        {
            dialogueGroup.alpha = 0;
            dialogueGroup.blocksRaycasts = false;
        }
    }

    IEnumerator Typing(string line)
    {
        dialogueText.text = "";
        foreach (char letter in line.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(TypingSpeed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueText.text.Equals(currentSentence))
        {
            NextText.SetActive(true);
            isTyping = false;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(!isTyping)
        NextSentence();
    }
}
