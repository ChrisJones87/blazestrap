namespace Blazestrap.UI.Components
{
   public class BadgeType
   {
      public static readonly BadgeType Primary = new BadgeType("primary");
      public static readonly BadgeType Secondary = new BadgeType("secondary");
      public static readonly BadgeType Success = new BadgeType("success");
      public static readonly BadgeType Danger = new BadgeType("danger");
      public static readonly BadgeType Warning = new BadgeType("warning");
      public static readonly BadgeType Info = new BadgeType("info");
      public static readonly BadgeType Light = new BadgeType("light");
      public static readonly BadgeType Dark = new BadgeType("dark");

      private readonly string _value;

      public BadgeType(string value)
      {
         _value = value;
      }

      public string Value => _value;

      public static implicit operator BadgeType(string b) => new BadgeType(b);
   }
}