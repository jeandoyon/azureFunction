using System;

namespace SQLManagedIdentityFunction
{
  public class Matiere
  {
    public string Id { get; set; }
    public string Nom { get; set; }
    public int Actif { get; set; }
    public int IsSystem { get; set; }
    public DateTime DateCreation { get; set; }
    public DateTime DateModification { get; set; }
    public Guid UID { get; set; }

  }
}