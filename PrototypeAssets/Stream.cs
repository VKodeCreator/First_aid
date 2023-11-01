using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class Stream : MonoBehaviour
{
    private LineRenderer lineRenderer = null;
    private Vector3 targetPosition = Vector3.zero;
    private Coroutine pourRoutine = null;
    private ParticleSystem splashPartice = null;
    public AudioSource waterSoundSource;
    public AudioClip waterSoundClip;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        splashPartice = GetComponentInChildren<ParticleSystem>();
        waterSoundSource = GetComponent<AudioSource>();
        waterSoundSource.clip = waterSoundClip; // ���������, ��� ��������� ��������� �� �����
        waterSoundSource.loop = true; // ��������� ������������ ����� (���� ���������)
    }

    // Start is called before the first frame update
    private void Start()
    {
        MoveToPosition(0,transform.position);
        MoveToPosition(1, transform.position);

    }

    public void Begin()
    {
        StartCoroutine(UpdateParticle());
        pourRoutine = StartCoroutine(BeginPour());
    }

    private IEnumerator BeginPour()
    {
        while (gameObject.activeSelf)
        {
            targetPosition = FindEndPoint();
            MoveToPosition(0, transform.position);
            AnimateToPosition(1, targetPosition);
            yield return null;
        }
    }
    public void End()
    {
        StopCoroutine(pourRoutine);
        pourRoutine = StartCoroutine(EndPour());
    }
    private IEnumerator EndPour()
    {
        while(!HasReachedPosition(0,targetPosition))
        {
            AnimateToPosition(0, targetPosition);
            AnimateToPosition(1, targetPosition);
            yield return null;
        }
        Destroy(gameObject);
    }

    private Vector3 FindEndPoint()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.down);

        Physics.Raycast(ray, out hit, 2.0f);
        Vector3 endPoint = hit.collider ? hit.point : ray.GetPoint(2.0f);

        return endPoint;
    }

    private void MoveToPosition(int index,Vector3 targetPosition)
    {
        lineRenderer.SetPosition(index, targetPosition);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void AnimateToPosition(int index, Vector3 targetPosition)
    {
        Vector3 currentPoint = lineRenderer.GetPosition(index);
        Vector3 newPosition = Vector3.MoveTowards(currentPoint, targetPosition, Time.deltaTime * 1.75f);
        lineRenderer.SetPosition(index,newPosition);

    }
    private bool HasReachedPosition(int index, Vector3 targetPosition)
    {
        Vector3 currentPosition = lineRenderer.GetPosition(index);
        return currentPosition == targetPosition;
    }
    private IEnumerator UpdateParticle()
    {
        while(gameObject.activeSelf)
        {
            splashPartice.gameObject.transform.position = targetPosition;
            bool isHitting = HasReachedPosition(1, targetPosition);
            splashPartice.gameObject.SetActive(isHitting);
            yield return null;
        }
        yield return null;
    }
}
