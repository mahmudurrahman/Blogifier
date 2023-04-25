using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blogifier.Shared;

public class Post
{
  [Key]
  public int Id { get; set; }
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public DateTime CreatedAt { get; set; }
  [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
  public DateTime UpdatedAt { get; set; }
  public int AuthorId { get; set; }
  public PostType PostType { get; set; }
  [Required]
  [StringLength(160)]
  public string Title { get; set; } = default!;
  [Required]
  [StringLength(160)]
  public string Slug { get; set; } = default!;
  [Required]
  [StringLength(450)]
  public string Description { get; set; } = default!;
  public string Content { get; set; } = default!;
  [StringLength(160)]
  public string? Cover { get; set; }
  public int PostViews { get; set; }
  public double Rating { get; set; }
  public bool IsFeatured { get; set; }
  public bool Selected { get; set; }
  public DateTime Published { get; set; }
  public Blog? Blog { get; set; }
  public List<PostCategory>? PostCategories { get; set; }
}
