using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System.Runtime.InteropServices;

namespace NotiXamarinAndroid_5._0
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var newsTitle = FindViewById<TextView>(Resource.Id.newsTitle);
            var newsBody = FindViewById<TextView>(Resource.Id.newsBody);
            var newsImage = FindViewById<ImageView>(Resource.Id.newsImage);

            newsTitle.Text = "Este es un Título";
            newsBody.Text = "Xamarin es una compañía de software estadounidense";
            var icon = GetDrawable(Resource.Drawable.computadora);
            newsImage.SetImageDrawable(icon);
            
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        }
    }
}