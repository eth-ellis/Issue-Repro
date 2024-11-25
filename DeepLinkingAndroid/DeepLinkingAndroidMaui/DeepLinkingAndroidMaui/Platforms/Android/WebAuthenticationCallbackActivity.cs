using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace DeepLinkingAndroidMaui;

[Activity(
    NoHistory = true,
    LaunchMode = LaunchMode.SingleTop,
    Exported = true)]
[IntentFilter(
    [Intent.ActionView],
    Categories = [Intent.CategoryDefault, Intent.CategoryBrowsable],
    DataScheme = "oauth")]
public class WebAuthenticationCallbackActivity : WebAuthenticatorCallbackActivity;