﻿/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.Text;

namespace ZKEACMS.SSE
{
    public class ServerSendEvent
    {
        public static readonly ServerSendEvent End = new ServerSendEvent { Event = "end" };
        public string Id { get; set; }
        public string Event { get; set; }
        public string Data { get; set; }
        public int Retry { get; set; }
        public override string ToString()
        {
            var result = new StringBuilder();
            if (!string.IsNullOrEmpty(Id))
            {
                result.AppendLine($"id: {Id}");
            }
            if (!string.IsNullOrEmpty(Event))
            {
                result.AppendLine($"event: {Event}");
            }
            if (Retry > 0)
            {
                result.AppendLine($"retry: {Retry}");
            }
            result.AppendLine($"data: {Data}");
            result.AppendLine();
            return result.ToString();
        }
    }
}
