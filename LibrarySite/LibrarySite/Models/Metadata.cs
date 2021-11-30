using System;
using System.ComponentModel.DataAnnotations;

namespace LibrarySite.Models
{
    public class AuthorMetadata
    {
        [StringLength(50)]
        [Display(Name = "Author Name")]
        public string Name;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public Nullable<System.DateTime> DOB;
    }

    public class BookMetadata
    {
        [StringLength(50)]
        [Display(Name = "Title")]
        public string Title;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Published")]
        public Nullable<System.DateTime> DatePublished;
    }

    public class PublisherMetadata
    {
        [StringLength(50)]
        [Display(Name = "Publisher Name")]
        public string Name;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Founded")]
        public Nullable<System.DateTime> DateFounded;
    }

}