// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNet.Http;

namespace Microsoft.AspNet.WebSockets.Server
{
    public class ExtendedWebSocketAcceptContext : WebSocketAcceptContext
    {
        public override string SubProtocol { get; set; }
        public int? ReceiveBufferSize { get; set; }
        public TimeSpan? KeepAliveInterval { get; set; }

        // public ArraySegment<byte>? Buffer { get; set; } // TODO
    }
}