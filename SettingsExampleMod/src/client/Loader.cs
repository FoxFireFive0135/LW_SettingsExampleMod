using JimmysUnityUtilities;
using LogicAPI.Client;
using LogicSettings;
using System.Collections;

namespace FoxFireFive.SettingsExampleMod.Client
{
    public enum MyEnum
    {
        None, Hello, World, Lorem, Ipsum, Jimmy, Logic, CSharp
    }

    public class Loader : ClientMod
	{
        [Setting_Toggle("FoxFireFive.SettingsExampleMod.ToggleExample")]
        public static bool ToggleExample { get; set; } = false;

        [Setting_SliderFloat("FoxFireFive.SettingsExampleMod.SliderFloatExample")]
        public static float SliderFloatExample { get; set; } = 0;

        [Setting_SliderInt("FoxFireFive.SettingsExampleMod.SliderIntExample")]
        public static int SliderIntExample { get; set; } = 0;

        // This will create a secret setting in "settings_master.jecs"
        // The variable type can be anything, like an int, string, bool, etc.
        [Setting_Secret("FoxFireFive.SettingsExampleMod.Secret.SecretSettingExample")]
        public static int SecretSettingExample { get; set; } = 0;

        [Setting_TextBox("FoxFireFive.SettingsExampleMod.TextBoxExample")]
        public static string TextBoxExample { get; set; } = string.Empty;

        // Color24 is from JimmysUnityUtilities.dll
        [Setting_ColorPicker("FoxFireFive.SettingsExampleMod.ColorPickerExample")]
        public static Color24 ColorPickerExample { get; set; } = Color24.White;

        [Setting_TexturePicker("FoxFireFive.SettingsExampleMod.TexturePickerExample", "example_textures/*")]
        public static string TexturePickerExample { get; set; } = string.Empty;

        [Setting_DropdownEnum("FoxFireFive.SettingsExampleMod.DropdownEnumExample", typeof(MyEnum))]
        public static MyEnum DropdownEnumExample { get; set; } = MyEnum.None;

        [Setting_DropdownDynamic("FoxFireFive.SettingsExampleMod.DropdownDynamicExample", typeof(Loader), "GetDropdownItems")]
        public static string DropdownDynamicExample { get; set; } = string.Empty;

        public static string[] GetDropdownItems()
        {
            return ["hello", "bobby", "inverter", "peanut"];
        }

        protected override void Initialize()
        {

        }
    }
}