namespace Blazestrap.UI.Components
{
   public class ButtonSize
   {
      public static readonly ButtonSize Regular = new ButtonSize(null);
      public static readonly ButtonSize Small = new ButtonSize("sm");
      public static readonly ButtonSize Large = new ButtonSize("lg");

      private readonly string _value;

      public ButtonSize(string value)
      {
         _value = value;
      }

      public string Value => _value;

      public static implicit operator ButtonSize(string b) => new ButtonSize(b);
   }
}