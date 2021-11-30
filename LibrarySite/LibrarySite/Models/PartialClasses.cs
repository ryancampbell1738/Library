using System;
using System.ComponentModel.DataAnnotations;

namespace LibrarySite.Models
{
    [MetadataType(typeof(AuthorMetadata))]
    public partial class Author
    {
    }

    [MetadataType(typeof(BookMetadata))]
    public partial class Book
    {
    }

    [MetadataType(typeof(PublisherMetadata))]
    public partial class Publisher
    {
    }
}