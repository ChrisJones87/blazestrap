namespace Blazestrap.UI.Components
{
   public class ButtonType
   {
      public static readonly ButtonType Primary = new ButtonType("primary");
      public static readonly ButtonType Secondary = new ButtonType("secondary");
      public static readonly ButtonType Success = new ButtonType("success");
      public static readonly ButtonType Danger = new ButtonType("danger");
      public static readonly ButtonType Warning = new ButtonType("warning");
      public static readonly ButtonType Info = new ButtonType("info");
      public static readonly ButtonType Light = new ButtonType("light");
      public static readonly ButtonType Dark = new ButtonType("dark");
      public static readonly ButtonType Link = new ButtonType("link");

      private readonly string _value;

      public ButtonType(string value)
      {
         _value = value;
      }

      public string Value => _value;

      public static implicit operator ButtonType(string b) => new ButtonType(b);
   }
}
