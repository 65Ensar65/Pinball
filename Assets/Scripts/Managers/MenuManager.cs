using System.Collections;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] CanvasGroup TapToStart;
    private GameObject DynamicJoystick;
    [SerializeField] GameObject GamePanel;
    [SerializeField] GameObject WinPanel;
    [SerializeField] GameObject LosePanel;
    public static MenuManager Instance;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        ShowGamePanel();
    }

    public void HideTapToStart()
    {
        TapToStart.gameObject.SetActive(false);
       
    }


    public void LoadScene(int buildIndex)
    {
        LevelManager.Instance.LoadScene(buildIndex);
    }

    public void LoadScene(string name)
    {
        LevelManager.Instance.LoadScene(name);
    }

    public void LoadActiveScene()
    {
        LevelManager.Instance.LoadActiveScene();
    }

    public void ShowGamePanel()
    {
        GamePanel.SetActive(true);
        LosePanel.SetActive(false);
        WinPanel.SetActive(false);
    }public void HideGamePanel()
    {
        GamePanel.SetActive(false);
        LosePanel.SetActive(true);
        WinPanel.SetActive(true);
    }

    public void ShowWinPanel()
    {
        GamePanel.SetActive(false);
        LosePanel.SetActive(false);
        WinPanel.SetActive(true);
    }

    public void ShowLosePanel()
    {
        GamePanel.SetActive(false);
        LosePanel.SetActive(true);
        WinPanel.SetActive(false);
    }

    public void GetPanel(System.Action panelMethod, float time)
    {
        StartCoroutine(PanelDelay(panelMethod, time));
    }

    private IEnumerator PanelDelay(System.Action panelMethod, float time)
    {
        yield return new WaitForSeconds(time);
        panelMethod.Invoke();
    }
}