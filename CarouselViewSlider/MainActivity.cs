using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Com.Gigamole.Infinitecycleviewpager;
using System.Collections.Generic;

namespace CarouselViewSlider
{
    [Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = true)]  //AppTheme
    public class MainActivity : AppCompatActivity
    {
        List<int> listImage = new List<int>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            InitData();
            HorizontalInfiniteCycleViewPager viewPager = FindViewById<HorizontalInfiniteCycleViewPager>(Resource.Id.horizontal_viewpager);
            MyAdapter adapter = new MyAdapter(listImage, BaseContext);
            viewPager.Adapter = adapter;

        }

        private void InitData()
        {
            listImage.Add(Resource.Drawable.intro1);
            listImage.Add(Resource.Drawable.intro2);
            listImage.Add(Resource.Drawable.intro3);


        }
    }
}