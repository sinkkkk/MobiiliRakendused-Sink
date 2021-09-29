using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace CalculatorApp
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

            var button = FindViewById<Button>(Resource.Id.toCalcButton);

            var tipButton = FindViewById<Button>(Resource.Id.tipCalcButton);



            button.Click += calcButton_Click;
            tipButton.Click += tipButton_Click;

        }

        private void tipButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(tipCalcActivity));
            StartActivity(intent);
        }
        private void calcButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(CalculatorActivity));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}