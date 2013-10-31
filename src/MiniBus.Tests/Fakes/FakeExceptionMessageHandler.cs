﻿using MiniBus.Contracts;
using System;
using System.Messaging;

namespace MiniBus.Tests.Fakes
{
    internal sealed class FakeExceptionMessageHandler : IHandleMessage<Message>
    {
        public void Handle(Message msg)
        {
            throw new Exception("testing 1, 2, 3");
        }
    }
}
