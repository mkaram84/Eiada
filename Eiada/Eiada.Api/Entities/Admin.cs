namespace Eiada.Api.Entities;

public class Admin
{
    public required int AdminId { get; set; }
    public required string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public virtual IEnumerable<Notification> Notifications { get; set; }

}
