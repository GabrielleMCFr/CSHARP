using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CipherServices.Services;
using CipherServices.Data;
using CipherServices.Models;

namespace CipherServices.Pages
{
  public class IndexModel : PageModel
  {
    public Dictionary<string, string> Secrets { get; set; }
    [BindProperty]
    public Message NewMessage { get; set; }

    private readonly MessageContext _context;
    private readonly IDecrypter _decrypter;
    private readonly IEncrypter _encrypter;

    public IndexModel(IDecrypter decrypter, MessageContext context, IEncrypter encrypter)
    {
      _decrypter = decrypter;
      _context = context;
      _encrypter = encrypter;
    }

    public async Task<IActionResult> OnGetAsync()
    {
      await LoadSecretsAsync(_decrypter, _context);
      return Page();
    }

    public async Task<IActionResult> OnPostAsync() 
    {
      // check if the new message if valid
      if (ModelState.IsValid) {
        string cleanedMessage = NewMessage.Text.Trim().ToLower();
        string msg = _encrypter.Encrypt(cleanedMessage);

        Message EncryptedMsg = new Message { Text = msg };
        _context.Messages.Add(EncryptedMsg);
        await _context.SaveChangesAsync();
        return RedirectToPage("/Index");
      }

      else {
        await LoadSecretsAsync(_decrypter, _context);
        return Page();
      }
    }

    private async Task LoadSecretsAsync(IDecrypter decrypter, MessageContext context)
    {
      Secrets = new Dictionary<string, string>();
      var messages = await context.Messages.ToListAsync();

      foreach (Message m in messages)
      {
        Secrets.TryAdd(m.Text, decrypter.Decrypt(m.Text));
      }
    }
  }
}
