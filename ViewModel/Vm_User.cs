using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ViewModel {
  public class Vm_User {
    [Key]

    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public string Address { get; set; }
    public string Codemeli { get; set; }
    public string image { get; set; }
    public IFormFile file { get; set; }
    public IFormFile FileUpload { get; set; }
    public string FileName { get; set; }
    public string VideoName { get; set; }
    public IFormFile Video { get; set; }
    public string Description { get; set; }
  }
}