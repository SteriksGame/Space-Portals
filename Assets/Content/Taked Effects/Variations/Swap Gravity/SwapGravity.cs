﻿using UnityEngine;

namespace SpacePortals
{
    public class SwapGravity : TakedEffect
    {
        protected override void ApplyEffectToBall(Ball ball)
        {
            ball.Rigidbody2D.velocity = Vector3.zero;
            ball.Rigidbody2D.gravityScale *= -1;
        }
    }
}