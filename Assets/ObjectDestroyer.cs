using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    void OnBecameInvisible()
    {
        // �I�u�W�F�N�g���J�����̃r���[�|�[�g���猩���Ȃ��Ȃ�����j������
        Destroy(gameObject);

        Debug.Log("������֐��ʂ���");
    }
}
