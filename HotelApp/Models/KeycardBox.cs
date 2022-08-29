namespace HotelApp.Models
{
  internal class KeycardBox
  {
    private static KeycardBox _instance = new KeycardBox();
    public static KeycardBox Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new KeycardBox();
        }
        return _instance;
      }
    }

    public ICollection<Keycard> Keycards { get; private set; } = new SortedSet<Keycard>();

    private KeycardBox()
    {

    }

    public Keycard GetNewKeycard()
    {
      Keycard newKeycard = new Keycard();
      Keycards.Add(newKeycard);
      return newKeycard;
    }
  }
}
