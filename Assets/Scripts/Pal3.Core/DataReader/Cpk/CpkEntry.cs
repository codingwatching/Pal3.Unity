// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2025, Jiaqi (0x7c13) Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Pal3.Core.DataReader.Cpk
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// CpkEntry model
    /// </summary>
    public sealed class CpkEntry
    {
        /// <summary>
        /// Virtualized file system path within the CPK archive.
        /// Example: music\pi10a.mp3
        /// </summary>
        public string VirtualPath { get; }

        /// <summary>
        /// True if current entry is a directory,
        /// False if current entry is a file.
        /// </summary>
        public bool IsDirectory { get; }

        /// <summary>
        /// Non-empty child nodes if current CpkEntry is a directory.
        /// </summary>
        public IEnumerable<CpkEntry> Children { get; }

        public CpkEntry(string virtualPath, bool isDirectory)
        {
            VirtualPath = virtualPath;
            IsDirectory = isDirectory;
            Children = Array.Empty<CpkEntry>();
        }

        public CpkEntry(string virtualPath, bool isDirectory, IEnumerable<CpkEntry> children)
        {
            VirtualPath = virtualPath;
            IsDirectory = isDirectory;
            Children = children;
        }
    }
}