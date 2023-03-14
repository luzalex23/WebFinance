using System;

public class ApplicationUser : IdentityUser
{
    [Column("USR_CPF")]
    public string CPF { get; set; }
}
