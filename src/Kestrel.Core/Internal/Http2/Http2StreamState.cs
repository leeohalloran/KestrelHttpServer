// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
    public enum Http2StreamState
    {
        Idle,
        Open,
        HalfClosedRemote,
        HalfClosedLocal,
        ReservedLocal,
        ReservedRemote,
        Closed
    }
}