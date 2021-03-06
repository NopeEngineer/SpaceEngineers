﻿namespace VRageRender.Messages
{
    public class MyRenderMessageRemoveRenderObject : MyRenderMessageBase
    {
        public uint ID;

        public override MyRenderMessageType MessageClass { get { return MyRenderMessageType.StateChangeOnce; } }
        public override MyRenderMessageEnum MessageType { get { return MyRenderMessageEnum.RemoveRenderObject; } }
    }
}
