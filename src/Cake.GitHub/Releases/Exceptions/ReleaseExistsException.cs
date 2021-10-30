﻿#nullable enable

namespace Cake.GitHub
{
    /// <summary>
    /// Thrown when a GitHub Release with the same tag name already exists
    /// </summary>
    public class ReleaseExistsException : GitHubReleaseException
    {
        public ReleaseExistsException(string message) : base(message)
        { }
    }
}
