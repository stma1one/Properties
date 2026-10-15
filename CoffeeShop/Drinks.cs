using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop;

/// <summary>
/// מחלקת בסיס מופשטת (abstract) המייצגת משקה כללי במכונה.
/// </summary>
public abstract class Drink
{
    // שדות פרטיים
    private int price;
    private int volume;

    /// <summary>
    /// שם המשקה.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// מחיר המשקה בש"ח (חייב להיות חיובי).
    /// </summary>
    public int Price
    {
        get { return price; }
        set 
        { 
            if (value > 0)
                price = value;
        }
    }

    /// <summary>
    /// נפח המשקה במיליליטרים (חייב להיות חיובי).
    /// </summary>
    public int Volume
    {
        get { return volume; }
        set 
        { 
            if (value > 0)
                volume = value; 
        }
    }

    /// <summary>
    /// פעולה בונה (Constructor) למחלקה Drink.
    /// </summary>
    /// <param name="name">שם המשקה</param>
    /// <param name="price">מחיר בסיסי בש"ח</param>
    /// <param name="volume">נפח במיליליטר</param>
    public Drink(string name, int price, int volume)
    {
        this.Name = name;
        this.Price = price;
        this.Volume = volume;
    }
}


/// <summary>
/// מחלקה מופשטת המייצגת משקה חם, היורשת ממחלקת Drink.
/// </summary>
public abstract class HotDrink : Drink
{
    private double temperature;

    /// <summary>
    /// טמפרטורת המשקה במעלות צלזיוס (בין 30 ל-95).
    /// </summary>
    public double Temperature
    {
        get { return temperature; }
        set 
        { 
            if (value >= 30 && value <= 95)
                temperature = value; 
        }
    }

    /// <summary>
    /// פעולה בונה למשקה חם.
    /// </summary>
    /// <param name="name">שם המשקה</param>
    /// <param name="price">מחיר המשקה</param>
    /// <param name="volume">נפח במיליליטר</param>
    /// <param name="temperature">טמפרטורת המשקה</param>
    public HotDrink(string name, int price, int volume, double temperature)
        : base(name, price, volume)
    {
        Temperature = temperature;
    }

    /// <summary>
    /// מחושב מחדש בכל משקה.
    /// 
    /// הסבר כמורה - VIRTUAL:
    /// המילה VIRTUAL מגדירה שפעולה זו מעניקה חישוב ברירת מחדל (החזרת המחיר הבסיסי),
    /// אך היא נותנת "הרשאה" למחלקות בנות שיורשות מ-HotDrink לדרוס אותה לפי צורך.
    /// </summary>
    /// <returns>מחיר המשקה החם</returns>
    public virtual double CalculatePrice()
    {
        return Price;
    }
}


/// <summary>
/// מחלקה המייצגת קפה, היורשת ממחלקת HotDrink.
/// </summary>
public class Coffee : HotDrink
{
    private int espressoShots;

    /// <summary>
    /// מספר מנות האספרסו בקפה (חייב להיות חיובי).
    /// </summary>
    public int EspressoShots
    {
        get { return espressoShots; }
        set 
        { 
            if (value > 0) 
                espressoShots = value; 
        }
    }

    /// <summary>
    /// פעולה בונה לקפה.
    /// </summary>
    /// <param name="name">שם הקפה</param>
    /// <param name="price">מחיר בסיס</param>
    /// <param name="volume">נפח</param>
    /// <param name="temperature">טמפרטורה</param>
    /// <param name="espressoShots">מספר מנות אספרסו</param>
    public Coffee(string name, int price, int volume, double temperature, int espressoShots)
        : base(name, price, volume, temperature)
    {
        this.espressoShots = espressoShots;
    }
}


/// <summary>
/// מחלקה המייצגת אספרסו, היורשת ממחלקת Coffee.
/// </summary>
public class Espresso : Coffee
{
    /// <summary>
    /// פעולה בונה לאספרסו (קובעת כברירת מחדל מנת אספרסו אחת).
    /// </summary>
    /// <param name="name">שם</param>
    /// <param name="price">מחיר</param>
    /// <param name="volume">נפח</param>
    /// <param name="temperature">טמפרטורה</param>
    public Espresso(string name, int price, int volume, double temperature)
        : base(name, price, volume, temperature, 1)
    {
    }

    /// <summary>
    /// הסבר כמורה - OVERRIDE ו-BASE:
    /// 1. המילה OVERRIDE מציינת שאנו מממשים גרסה חדשה וייחודית לפעולה CalculatePrice עבור אספרסו.
    /// 2. הקריאה ל-base.CalculatePrice() קוראת לפעולה של מחלקת האב (HotDrink) כדי לקבל את המחיר הבסיסי,
    ///    ומתווספים אליה 5 ש"ח לכל מנת אספרסו.
    /// </summary>
    /// <returns>מחיר האספרסו המשוקלל</returns>
    public override double CalculatePrice()
    {
        return base.CalculatePrice() + (5 * EspressoShots);
    }
}


/// <summary>
/// מחלקה המייצגת אפוגטו (אספרסו עם כדורי גלידה), היורשת ממחלקת Espresso.
/// </summary>
public class Affogato : Espresso
{
    private int iceCreamScoops;

    /// <summary>
    /// כמות כדורי הגלידה באפוגטו (חייבת להיות גדולה מ-0).
    /// </summary>
    public int IceCreamScoops
    {
        get { return iceCreamScoops; }
        set 
        { 
            if (value > 0)
                iceCreamScoops = value; 
        }
    }

    /// <summary>
    /// פעולה בונה לאפוגטו.
    /// </summary>
    /// <param name="name">שם המשקה</param>
    /// <param name="price">מחיר בסיס</param>
    /// <param name="volume">נפח במיליליטר</param>
    /// <param name="temperature">טמפרטורה</param>
    /// <param name="iceCreamScoops">כמות כדורי גלידה</param>
    public Affogato(string name, int price, int volume, double temperature, int iceCreamScoops)
        : base(name, price, volume, temperature)
    {
        this.iceCreamScoops = iceCreamScoops;
    }

    /// <summary>
    /// הסבר כמורה - OVERRIDE בשרשרת ירושה:
    /// 1. הפעולה הזו דורסת את CalculatePrice של מחלקת האב הישירה (Espresso).
    /// 2. הקריאה ל-base.CalculatePrice() מפעילה את חישוב המחיר של Espresso (שכולל כבר את מחיר הבסיס והאספרסו),
    ///    ועל הסכום הזה מוסיפה 5 ש"ח לכל כדור גלידה.
    /// </summary>
    /// <returns>המחיר הכולל של האפוגטו</returns>
    public override double CalculatePrice()
    {
        return base.CalculatePrice() + (5 * IceCreamScoops);
    }
}