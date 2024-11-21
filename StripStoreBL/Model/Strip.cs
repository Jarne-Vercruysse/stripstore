using System.Collections.ObjectModel;
using StripStoreBL.Exceptions;

namespace StripStoreBL.Model;

public class Strip
{
    #region Fields

    private Reeks _reeks;
    private string _title;

    #endregion

    #region Properties

    public int Id { get; set; }

    public string Titel
    {
        get => _title;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new StripException("Title cannot be empty");
            }

            _title = value;
        }
    }

    public Uitgeverij Uitgeverij { get; set; }
    public ReadOnlyCollection<Auteur> Auteurs { get; set; }

    public Reeks Reeks
    {
        get => _reeks;
        set
        {
            if (value == null)
            {
                throw new StripException("Reeks can not be empty");
            }

            _reeks = value;
        }
    }

    public int ReeksNummer { get; set; }

    #endregion

    #region Methods

    public void ChangeReeks(Reeks reeks)
    {
        throw new NotImplementedException();
    }

    public void ChangeAuteur(Auteur auteur)
    {
        throw new NotImplementedException();
    }

    public void DeleteAuteur(int id)
    {
        throw new NotImplementedException();
    }

    public void ChangeUitgeverij(Uitgeverij uitgeverij)
    {
        throw new NotImplementedException();
    }

    public void ChangeTitle(string title)
    {
        throw new NotImplementedException();
    }
    #endregion
}

public class Uitgeverij
{
    #region Properties

    public int Id { get; set; }
    public string Naam { get; set; }
    public string Adres { get; set; }

    #endregion
}

public class Auteur
{
    #region Properties

    public int Id { get; set; }
    public string Naam { get; set; }
    public string Email { get; set; }

    #endregion
}

public class Reeks
{
    #region Properties

    public int Id { get; set; }
    public string Naam { get; set; }
    public ReadOnlyCollection<Strip> strips { get; set; }

    #endregion
}