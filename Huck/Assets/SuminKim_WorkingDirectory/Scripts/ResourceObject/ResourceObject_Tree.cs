using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceObject_Tree : BaseResourceObject
{
    public override void TakeDamage(DamageMessage message)
    {
        // Ÿ�Կ� ���� �߰� ó��
        // ������ ���� Ÿ���� ������ ��쿡�� �������� ����
        ItemData hitItem = message.item;
        float damageMultiplier_type = 0f;
        float damageMultiplier_level = 0f;


        if (hitItem != null && hitItem.ItemTool == EItemTool.AXE)
            damageMultiplier_type = 1f;

        if (hitItem != null && (int)hitItem.ItemLevel >= (int)resLevel)
            damageMultiplier_level = 1f;

        message.damageAmount = message.damageAmount * (int)damageMultiplier_type * (int)damageMultiplier_level;

        // ������ ó��
        base.TakeDamage(message);
    }
}