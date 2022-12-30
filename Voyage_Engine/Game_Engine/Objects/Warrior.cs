﻿using Voyage_Engine.Console;
using Voyage_Engine.Game_Engine.Assest.Sprites;
using Voyage_Engine.Game_Engine.GameObjectSystem;

namespace Voyage_Engine.Game_Engine.Objects
{
    public class Warrior : GameObject
    {
        public override void Start()
        {
            Debug.Log(Name + " is in position " + Transform.Position + " and scale of " + Transform.Scale + " " + InstanceId);
            AddComponent<WarriorSprite>();
            base.Start();
        }
    }
}