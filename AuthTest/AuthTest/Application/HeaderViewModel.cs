using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AuthTest.Application;

public class HeaderViewModel
{
    //  [Required]
    // [JsonPropertyName("XInput")]
    [FromHeader]
    public string XInput { get; set; }

}