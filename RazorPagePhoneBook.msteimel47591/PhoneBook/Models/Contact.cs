using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models;

public class Contact
{
    public int Id { get; set; }

    [Required]
    [RegularExpression(@"^[^\s]+(\s+[^\s]+)*$", ErrorMessage = "Name cannot start or end with whitespace.")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [RegularExpression(@"\(\d\d\d\)-\d\d\d-\d\d\d\d", ErrorMessage = "Expected format is (xxx)-xxx-xxxx.")]
    public string PhoneNumber { get; set; } = string.Empty;

    public string? Email { get; set; } = string.Empty;

}
