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
    [Activity(Label = "CalculatorActivity")]
    public class CalculatorActivity : Activity
    {

        EditText firstEditText;
        EditText secondEditText;
        TextView answerTextView;
        Button addButton;
        Button subButton;
        Button mulButton;
        Button divButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.calculator_layout);

            firstEditText = FindViewById<EditText>(Resource.Id.firstNumberEditText);

            secondEditText = FindViewById<EditText>(Resource.Id.secondNumberEditText);

            addButton = FindViewById<Button>(Resource.Id.addButton);

            subButton = FindViewById<Button>(Resource.Id.subButton);

            mulButton = FindViewById<Button>(Resource.Id.mulButton);

            divButton = FindViewById<Button>(Resource.Id.divButton);
            answerTextView = FindViewById<TextView>(Resource.Id.answerTextView);


            addButton.Click += (i, ee)=> calcHandler("add");
            divButton.Click += (i, ee) => calcHandler("div");
            subButton.Click += (i, ee) => calcHandler("sub");
            mulButton.Click += (i, ee) => calcHandler("mul");

        }

        private void calcHandler(string v)
        {
            switch (v)
            {
                case "add":
                    var answer = int.Parse(firstEditText.Text) + int.Parse(secondEditText.Text);
                    answerTextView.Text = answer.ToString();
                    //return null;
                    break;
                case "sub":
                    answer = int.Parse(firstEditText.Text) - int.Parse(secondEditText.Text);
                    answerTextView.Text = answer.ToString();
                    //return null;
                    break;
                case "div":
                    answer = int.Parse(firstEditText.Text) / int.Parse(secondEditText.Text);
                    answerTextView.Text = answer.ToString();
                    //return null;
                    break;
                case "mul":
                    answer = int.Parse(firstEditText.Text) * int.Parse(secondEditText.Text);
                    answerTextView.Text = answer.ToString();
                    //return null;
                    break;
            }
        }

        //private void calcHandler(object sender, EventArgs e)
        //{
        //    switch (sender)
        //    {
        //        case "add":
        //            var answer = int.Parse(firstEditText.Text) * int.Parse(secondEditText.Text);
        //            answerTextView.Text = answer.ToString();
        //            //return null;
        //            break;
        //        //case "mul":
        //        //    return;
        //        //    break;
        //        //case "div":
        //        //    return;
        //        //    break;
        //        //case "sub":
        //        //    return;
        //        //    break;
        //    }
        //}
        //private execCalc()
        //private void MulButton_Click(object sender, EventArgs e)
        //{
        //    var answer = int.Parse(firstEditText.Text) * int.Parse(secondEditText.Text);
        //    answerTextView.Text = answer.ToString();
        //}

        //private void SubButton_Click(object sender, EventArgs e)
        //{
        //    var answer = int.Parse(firstEditText.Text) - int.Parse(secondEditText.Text);
        //    answerTextView.Text = answer.ToString();
        //}

        //private void addButtonClick(object sender, EventArgs e)
        //{
        //    var answer = int.Parse(firstEditText.Text) + int.Parse(secondEditText.Text);
        //    answerTextView.Text = answer.ToString();

        //}

        //private void divButtonClick(object sender, EventArgs e) // Koma arvudega vastuseid antud juhul ei saa, aga see on kergesti prandatav muutes int floadiks, ei ole aga kindel kui pikkaid komaarve ta annak
        //{
        //    var answer = float.Parse(firstEditText.Text) / float.Parse(secondEditText.Text);
        //    answerTextView.Text = answer.ToString();

        //}

        //private void subButtonClick(object sender, EventArgs e)
        //{
        //    var answer = int.Parse(firstEditText.Text) - int.Parse(secondEditText.Text);
        //    answerTextView.Text = answer.ToString();

        //}

        //subButton.Click += delegate
        //{
        //    var answer = int.Parse(firstEditText.Text) - int.Parse(secondEditText.Text);
        //    answerText.Text = answer.ToString();
        //};
        //mulButton.Click += delegate
        //{
        //    var answer = int.Parse(firstEditText.Text) * int.Parse(secondEditText.Text);
        //    answerText.Text = answer.ToString();
        //};
        //divButton.Click += delegate
        //{
        //    var answer = int.Parse(firstEditText.Text) / int.Parse(secondEditText.Text);
        //    answerText.Text = answer.ToString();
        //};
    }
}
