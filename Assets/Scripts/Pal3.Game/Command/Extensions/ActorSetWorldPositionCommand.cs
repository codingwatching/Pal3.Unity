﻿// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2025, Jiaqi (0x7c13) Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Pal3.Game.Command.Extensions
{
    using Core.Command;

    [AvailableInConsole]
    public sealed class ActorSetWorldPositionCommand : ICommand
    {
        public ActorSetWorldPositionCommand(int actorId, float xPosition, float zPosition)
        {
            ActorId = actorId;
            XPosition = xPosition;
            ZPosition = zPosition;
        }

        [SceActorId] public int ActorId { get; set; }
        public float XPosition { get; }
        public float ZPosition { get; }
    }
}