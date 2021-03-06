﻿using System.Collections.Generic;
using System.Threading.Tasks;
using LibSpeedLoad.Core.Download.Events;

namespace LibSpeedLoad.Core.Download
{
    /**
     * A downloader source.
     * 
     * A source is responsible for using a given URL
     * to download files.
     */
    public abstract class DownloaderSource
    {
        public List<VerificationProgressUpdated> VerificationProgressUpdated { get; } = new List<VerificationProgressUpdated>();
        public List<VerificationFailed> VerificationFailed { get; } = new List<VerificationFailed>();
        
        /// <summary>
        /// Begin the download process.
        /// </summary>
        /// <returns>The downloader task.</returns>
        public abstract Task Download();

        /// <summary>
        /// Begin the process of verifying files.
        /// </summary>
        /// <returns>The verifier task.</returns>
        public abstract Task VerifyHashes();
    }
}