// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Server.Kestrel.Internal.System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
    public partial class Http2Frame
    {
        public Http2DataFrameFlags DataFlags
        {
            get => (Http2DataFrameFlags)Flags;
            set => Flags = (byte)value;
        }

        public void PrepareData(int streamId)
        {
            Length = DefaultFrameSize - HeaderLength;
            Type = Http2FrameType.DATA;
            Flags = 0;
            StreamId = streamId;
        }
    }
}
