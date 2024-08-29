/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Logging;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ZKEACMS.Common.Service
{
    public class EventViewerService : IEventViewerService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private const string LoggerFoler = "Logs";
        public EventViewerService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public void Delete(string id)
        {
            var filePath = GetLogFilePath(id);
            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                }
                catch { }
            }
        }

        public IEnumerable<FileInfo> Get()
        {
            var dir = new DirectoryInfo(Path.Combine(_hostingEnvironment.ContentRootPath, LoggerFoler));
            if (dir.Exists)
            {
                return dir.GetFiles("*.log").OrderByDescending(m => m.Name);
            }
            return Enumerable.Empty<FileInfo>();
        }

        public void DeleteAll()
        {
            foreach (var item in Get())
            {
                Delete(item.Name);
            }
        }

        public Stream GetStream(string id)
        {
            return new FileStream(GetLogFilePath(id), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        }

        public IEnumerable<LogEntry> Take(string id, long position, int take)
        {
            using (LogReader reader = new LogReader(GetLogFilePath(id), Encoding.UTF8))
            {
                reader.SetPosition(position);
                return reader.Take(take).ToList();
            }
        }
        private string GetLogFilePath(string id)
        {
            return Path.Combine(_hostingEnvironment.ContentRootPath, LoggerFoler, id);
        }
    }
}
