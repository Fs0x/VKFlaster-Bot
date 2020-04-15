using System.Drawing;
using System.IO;

public class Skins
{
    public bool skinLoader = false;
    protected IniFiles ini;

    public Color BackGround_Color;

    public Color Panel_Color;

    public Color Font_Color;

    public Color Button_Color;
    public Color Button_Color_focus;
    public Color Button_Color_click;
    public Color Button_Color_Font;

    public Color Edit_Color;
    public Color Edit_Color_Font;

    public Color MenuStrip_Color;
    public Color MenuStrip_Color_Font;

    public Skins()
    {
        string file = "skin.ini";
        if (File.Exists(file))
        {
            try
            {
                ini = new IniFiles(file);

                BackGround_Color = ColorTranslator.FromHtml(ini.ReadINI("BackGround", "color"));
                Panel_Color = ColorTranslator.FromHtml(ini.ReadINI("Panel", "color"));
                Font_Color = ColorTranslator.FromHtml(ini.ReadINI("Font", "color"));

                Button_Color = ColorTranslator.FromHtml(ini.ReadINI("Button", "color"));
                Button_Color_focus = ColorTranslator.FromHtml(ini.ReadINI("Button", "color_focus"));
                Button_Color_click = ColorTranslator.FromHtml(ini.ReadINI("Button", "color_click"));
                Button_Color_Font = ColorTranslator.FromHtml(ini.ReadINI("Button", "color_font"));

                Edit_Color = ColorTranslator.FromHtml(ini.ReadINI("Edit", "color"));
                Edit_Color_Font = ColorTranslator.FromHtml(ini.ReadINI("Edit", "color_font"));

                MenuStrip_Color = ColorTranslator.FromHtml(ini.ReadINI("MenuStrip", "color"));
                MenuStrip_Color_Font = ColorTranslator.FromHtml(ini.ReadINI("MenuStrip", "color_font"));

                skinLoader = !skinLoader;
            }
            catch { }
        }
    }
}
