using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorApp
{

    [Activity(Label = "tipCalcActivity")]
    public class tipCalcActivity : Activity
    {       
            TextView _billTotalText;
            TextView _tipTotalText;
            EditText _subTotalEditText;
            TextView _tipViewText;
            SeekBar _tipSeekBar;

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.TipCalc_Layout);
            // Create your application here
            _subTotalEditText = FindViewById<EditText>(Resource.Id.subTotalEditText);
            _tipViewText = FindViewById<TextView>(Resource.Id.tipViewText);
            _tipSeekBar = FindViewById<SeekBar>(Resource.Id.tipSeekBar);
            _billTotalText = FindViewById<TextView>(Resource.Id.billTotalText);
            _tipTotalText = FindViewById<TextView>(Resource.Id.tipTotalText);


            _tipSeekBar.ProgressChanged += tipSeekBar_ProgressChanged;


        }



        private void tipSeekBar_ProgressChanged(object sender, SeekBar.ProgressChangedEventArgs e)
        {
            _tipViewText.Text = e.Progress.ToString();
            calcSubTotal();
            calcTip();
        }

        private void calcSubTotal()
        {
            var answer = float.Parse(_subTotalEditText.Text) * (1 +float.Parse(_tipViewText.Text)/100);
            _billTotalText.Text = answer.ToString();
        }
        private void calcTip()
        {
            var answer = float.Parse(_billTotalText.Text) - float.Parse(_subTotalEditText.Text);
            _tipTotalText.Text = answer.ToString();
        }
    }
}