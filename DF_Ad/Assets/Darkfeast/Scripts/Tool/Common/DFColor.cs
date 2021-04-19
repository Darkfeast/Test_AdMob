using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 颜色管理
/// </summary>
public class DFColor : MonoBehaviour {

    public enum E_ColorType
    {
        ClickLight,
        Glow,
        Dark,
        Combo,
        Idle,
        Trans,
        LightBg,
        SocketIn,
        SocketOut,
    }
   
    public Dictionary<int, string> dictColorClickLight = new Dictionary<int, string>();   //主副卡发光色块
    public Dictionary<int, string> dictColorGlow = new Dictionary<int, string>();         //主卡光晕色块
    public Dictionary<int, string> dictColorDark = new Dictionary<int, string>();         //暗幕条色块
    public Dictionary<int, string> dictColorCombo = new Dictionary<int, string>();         //合成卡色块(字卡发光色块)
    public Dictionary<int, string> dictColorIdleBreathe = new Dictionary<int, string>();         //主卡 idle 状态下呼吸色块
    public Dictionary<int, string> dictColorTrans = new Dictionary<int, string>();         // 过渡界面 光圈
    public Dictionary<int, string> dictColorLightBg = new Dictionary<int, string>();         // 测试 灯背景
    public Dictionary<int, string> dictColorSocketOut = new Dictionary<int, string>();         // 测试 凹槽外
    public Dictionary<int, string> dictColorSocketIn = new Dictionary<int, string>();         // 测试 

    void Awake()
    {
        InitClickLight();
        InitGlow();
        InitDark();
        InitCombo();
        dictColorIdleBreathe = dictColorClickLight;

        InitTrans();
        InitLightBg();
        InitSocketOut();
        InitSocketIn();
        //App.MgrData.themeColor = this;
        DontDestroyOnLoad(this);
    }

    public Color GetFontColor()
    {
        Color r;
        string fontLinkColor = "#293043";
        ColorUtility.TryParseHtmlString(fontLinkColor, out r);

        return r;
    }
     
    public Color ColorTool(string colorCode = "#000000", E_ColorType colorType=E_ColorType.Dark)
    {
        Color currentColor = Color.white;

        switch (colorType)
        {
            case E_ColorType.ClickLight:
                //ColorUtility.TryParseHtmlString(dictColorClickLight[App.MgrData.GetTheme()], out currentColor);
                ColorUtility.TryParseHtmlString(colorCode, out currentColor);
                break;
            case E_ColorType.Glow:
                ColorUtility.TryParseHtmlString(colorCode, out currentColor);
                break;
            case E_ColorType.Dark:
                ColorUtility.TryParseHtmlString(colorCode, out currentColor);
                break;
            case E_ColorType.Combo:
                ColorUtility.TryParseHtmlString(colorCode, out currentColor);
                break;
            case E_ColorType.Idle:
                ColorUtility.TryParseHtmlString(colorCode, out currentColor);
                break;
            case E_ColorType.Trans:
                ColorUtility.TryParseHtmlString(colorCode, out currentColor);
                break;
            case E_ColorType.LightBg:
                ColorUtility.TryParseHtmlString(colorCode, out currentColor);
                break;
            case E_ColorType.SocketOut:
                ColorUtility.TryParseHtmlString(colorCode, out currentColor);
                break;
            case E_ColorType.SocketIn:
                ColorUtility.TryParseHtmlString(colorCode, out currentColor);
                break;
            default:
                break;
        }
        return currentColor;
    }
    public static Color GetColor(string str)
    {
        Color c;
        ColorUtility.TryParseHtmlString(str, out c);
        if (c == null)
            return Color.white;
        return c;
    }
    void InitClickLight()
    {
        dictColorClickLight.Add(1, "#6df3f6");
        dictColorClickLight.Add(2, "#37ffe0");
        dictColorClickLight.Add(3, "#98f6f8");
        dictColorClickLight.Add(4, "#fdefc9");
        dictColorClickLight.Add(5, "#acaaff");
        dictColorClickLight.Add(6, "#ffe9d3");
        dictColorClickLight.Add(7, "#8ef6f2");
        dictColorClickLight.Add(8, "#f8f598");
        dictColorClickLight.Add(9, "#ffe9d3d4");
        dictColorClickLight.Add(10, "#e3fffd");
        dictColorClickLight.Add(11, "#fffbf2");
        dictColorClickLight.Add(12, "#cef9ff");
        dictColorClickLight.Add(13, "#e9cabd");
        dictColorClickLight.Add(14, "#947a93");
        dictColorClickLight.Add(15, "#d2abe8");
        dictColorClickLight.Add(16, "#f9f4df");
        dictColorClickLight.Add(17, "#f8f0bc");
        dictColorClickLight.Add(18, "#aef8ff");

    }
    void InitGlow()
    {
        dictColorGlow.Add(1, "#78eeff");
        dictColorGlow.Add(2, "#78eeff");
        dictColorGlow.Add(3, "#46d2e6");
        dictColorGlow.Add(4, "#f5e1ba");
        dictColorGlow.Add(5, "#b7b5fc");
        dictColorGlow.Add(6, "#fffde8");
        dictColorGlow.Add(7, "#b7b5fc");
        dictColorGlow.Add(8, "#abcec4");
        dictColorGlow.Add(9, "#78eeff");
        dictColorGlow.Add(10, "#fffde8");
        dictColorGlow.Add(11, "#a0eeff");
        dictColorGlow.Add(12, "#f4fdff");
        dictColorGlow.Add(13, "#fffde8");
        dictColorGlow.Add(14, "#fffde8");
        dictColorGlow.Add(15, "#fffde8");
        dictColorGlow.Add(16, "#fffde8");
        dictColorGlow.Add(17, "#fffde8");
        dictColorGlow.Add(18, "#af9eef");
   
    }
    void InitDark()
    {
        dictColorDark.Add(1, "#1e4098");
        dictColorDark.Add(2, "#243278");
        dictColorDark.Add(3, "#085b86");
        dictColorDark.Add(4, "#7870c9");
        dictColorDark.Add(5, "#321f64");
        dictColorDark.Add(6, "#fdd4dd");
        dictColorDark.Add(7, "#47add8");
        dictColorDark.Add(8, "#23799d");
        dictColorDark.Add(9, "#494287");
        dictColorDark.Add(10, "#d4a6db");
        dictColorDark.Add(11, "#716dbf");
        dictColorDark.Add(12, "#379bc5");
        dictColorDark.Add(13, "#4e313f");
        dictColorDark.Add(14, "#1c0f31");
        dictColorDark.Add(15, "#14294180");
        dictColorDark.Add(16, "#6d5c4c80");
        dictColorDark.Add(17, "#0f648bcc");
        dictColorDark.Add(18, "#070c2ecc");
    }
    void InitCombo()
    {
        dictColorCombo.Add(1, "#77f1f3");
        dictColorCombo.Add(2, "#c3f6ff");
        dictColorCombo.Add(3, "#c3f6ff");
        dictColorCombo.Add(4, "#ccfaf8");
        dictColorCombo.Add(5, "#acaaff");
        dictColorCombo.Add(6, "#8ef6f2");
        dictColorCombo.Add(7, "#8ef6f2");
        dictColorCombo.Add(8, "#c3f6ff");
        dictColorCombo.Add(9, "#c3f6ffb8");
        dictColorCombo.Add(10, "#e3fffd");
        dictColorCombo.Add(11, "#e3fffd");
        dictColorCombo.Add(12, "#ffe9d3");
        dictColorCombo.Add(13, "#e9cabd");
        dictColorCombo.Add(14, "#947a93");
        dictColorCombo.Add(15, "#d2abe8");
        dictColorCombo.Add(16, "#f9f4df");
        dictColorCombo.Add(17, "#f8f0bc");
        dictColorCombo.Add(18, "#aef8ff");
    }

    void InitTrans()
    {
        dictColorTrans.Add(1, "#80fcfc");
        dictColorTrans.Add(2, "#80fcfc");
        dictColorTrans.Add(3, "#73f4e7");
        dictColorTrans.Add(4, "#faffc8");
        dictColorTrans.Add(5, "#ffddcd");
        dictColorTrans.Add(6, "#ffffff");
        dictColorTrans.Add(7, "#fffcb7");
        dictColorTrans.Add(8, "#fffde1");
        dictColorTrans.Add(9, "#fba5b1");
        dictColorTrans.Add(10, "#ffffff");
        dictColorTrans.Add(11, "#eeffff");
        dictColorTrans.Add(12, "#f6ffff");
        dictColorTrans.Add(13, "#fff6b6");
        dictColorTrans.Add(14, "#b392f0");
        dictColorTrans.Add(15, "#fbf9c3");
        dictColorTrans.Add(16, "#ffffff");
        dictColorTrans.Add(17, "#fefffa");
        dictColorTrans.Add(18, "#c58ff7");
    }

    void InitLightBg()
    {
        dictColorLightBg.Add(1, "#666fa6ff");
        dictColorLightBg.Add(2, "#f3c052ff");
        dictColorLightBg.Add(3, "#716f9fff");
        dictColorLightBg.Add(4, "#8c8ab2ff");
        dictColorLightBg.Add(5, "#f3cf83ff");
        dictColorLightBg.Add(6, "#f8a26f");
        dictColorLightBg.Add(7, "#23ccbaff");
        dictColorLightBg.Add(8, "#6c84baff");
        dictColorLightBg.Add(9, "#845dc8ff");
        dictColorLightBg.Add(10, "#45c5caff");
        dictColorLightBg.Add(11, "#f0906eff");
        dictColorLightBg.Add(12, "#c290cdff");
        dictColorLightBg.Add(13, "#f4c767ff");
        dictColorLightBg.Add(14, "#f7a27dff");
        dictColorLightBg.Add(15, "#a3d587ff");
        dictColorLightBg.Add(16, "#2ba4b2");
        dictColorLightBg.Add(17, "#af83b7ff");
        dictColorLightBg.Add(18, "#358adaff");
    }
    void InitSocketOut()
    {
        dictColorSocketOut.Add(1, "#56c2e0ff");
        dictColorSocketOut.Add(2, "#32b8adff");
        dictColorSocketOut.Add(3, "#f18f9fff");
        dictColorSocketOut.Add(4, "#f18f9fff");
        dictColorSocketOut.Add(5, "#43b6c7ff");
        dictColorSocketOut.Add(6, "#39b1b6");
        dictColorSocketOut.Add(7, "#dc7494ff");
        dictColorSocketOut.Add(8, "#f19383ff");
        dictColorSocketOut.Add(9, "#39b1b6ff");
        dictColorSocketOut.Add(10, "#ffc2ddff");
        dictColorSocketOut.Add(11, "#939cf5ff");
        dictColorSocketOut.Add(12, "#ee905cff");
        dictColorSocketOut.Add(13, "#43b6c7ff");
        dictColorSocketOut.Add(14, "#5cbeb1ff");
        dictColorSocketOut.Add(15, "#91c374ff");
        dictColorSocketOut.Add(16, "#67e7ef");
        dictColorSocketOut.Add(17, "#d6adddff");
        dictColorSocketOut.Add(18, "#82cfe2ff");
    }
    void InitSocketIn()
    {
        dictColorSocketIn.Add(1, "#666fa6ff");
        dictColorSocketIn.Add(2, "#108d8bff");
        dictColorSocketIn.Add(3, "#d7728eff");
        dictColorSocketIn.Add(4, "#d7728eff");
        dictColorSocketIn.Add(5, "#148394ff");
        dictColorSocketIn.Add(6, "#148f94");
        dictColorSocketIn.Add(7, "#b56391ff");
        dictColorSocketIn.Add(8, "#ce6f5cff");
        dictColorSocketIn.Add(9, "#148f94ff");
        dictColorSocketIn.Add(10, "#ce7bb4ff");
        dictColorSocketIn.Add(11, "#6864b0ff");
        dictColorSocketIn.Add(12, "#a66e52ff");
        dictColorSocketIn.Add(13, "#148394ff");
        dictColorSocketIn.Add(14, "#1d92a7ff");
        dictColorSocketIn.Add(15, "#5c7e48ff");
        dictColorSocketIn.Add(16, "#489bc2");
        dictColorSocketIn.Add(17, "#9b8a70ff");
        dictColorSocketIn.Add(18, "#2d5e8bff");
    }
}
