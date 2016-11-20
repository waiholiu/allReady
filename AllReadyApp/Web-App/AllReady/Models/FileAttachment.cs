﻿namespace AllReady.Models
{
    /// <summary>
    ///     Data class responsible for keeping the attachment information.
    ///     We want to keep this separate from the content so we can retrieve the file information without retrieving the actual contents of the file.
    /// </summary>
    public class FileAttachment
    {
        /// <summary>ID of the object</summary>
        public int Id { get; set; }

        /// <summary>Name of the file</summary>
        public string Name { get; set; }

        /// <summary>Description of the file</summary>
        public string Description { get; set; }

        /// <summary>MIME type of the file</summary>
        public string MimeType { get; set; }

        /// <summary>The contents of the file</summary>
        public FileAttachmentContent Content { get; set; }

        /// <summary>Reference to the task where this file is attached to</summary>
        public AllReadyTask Task { get; set; }
    }
}
