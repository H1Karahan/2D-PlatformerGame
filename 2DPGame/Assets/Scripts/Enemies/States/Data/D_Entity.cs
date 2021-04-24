﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newEntityData", menuName = "Data/Entity Data/Base Data")]
public class D_Entity : ScriptableObject
{
    public float maxHealth = 30f;
    public float DamageHopSpeed = 3f;

    public float wallCheckDistance = 2f;
    public float ledgeCheckDistance = 0.4f;
    public float groundCheckRadius = 0.3f;

    public float maxAgroDistance = 4;
    public float minAgroDistance = 3;

    public float stunResistance = 3f;
    public float stunRecoveryTime = 2f;

    public float closeRangeActionDistance = 1f;

    public LayerMask whatIsGround;
    public LayerMask whatIsPlayer;

    public GameObject hitParticle;


}
