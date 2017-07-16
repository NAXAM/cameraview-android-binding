using System;
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Google.Android.Cameraview;
using Java.IO;
using Java.Lang;
using static Android.Support.V4.App.ActivityCompat;
using Exception = Java.Lang.Exception;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using System.IO;
using Android.Graphics;
using System.Collections.Generic;
using System.Linq;
using Android.Content.PM;
using Android.Support.V4.App;
using Android.Support.V4.Content;
using Android;

namespace GoogleCameraView
{
    [Activity(Label = "GoogleCameraView", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.Demo")]
    public class MainActivity : AppCompatActivity, IOnRequestPermissionsResultCallback, Listener
    {

        private const string TAG = "MainActivity";

        private const int REQUEST_CAMERA_PERMISSION = 1;

        private const string FRAGMENT_DIALOG = "dialog";

        private int[] FLASH_OPTIONS =
        {
            CameraView.FlashAuto,
            CameraView.FlashOff,
            CameraView.FlashOn
        };
        
        private int[] FLASH_ICONS = {
            Resource.Drawable.ic_flash_auto,
            Resource.Drawable.ic_flash_off,
            Resource.Drawable.ic_flash_on
        };

        private  int[] FLASH_TITLES = {
            Resource.String.flash_auto,
            Resource.String.flash_off,
            Resource.String.flash_on,
        };

        private int mCurrentFlash;

        private CameraView mCameraView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView (Resource.Layout.Main);

            mCameraView = FindViewById<CameraView>(Resource.Id.camera);
            if (mCameraView != null)
            {
                mCameraView.AddCallback(new CameraViewCallback(mCameraView));
            }
            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.take_picture);
            if (fab != null)
            {
                fab.SetOnClickListener(new ClickListener(mCameraView));
            }
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            if (SupportActionBar != null)
            {
                SupportActionBar.SetDisplayShowTitleEnabled(false);
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.main, menu);

            return true;
        }

        protected override void OnResume()
        {
            base.OnResume();

            if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.Camera) == Permission.Granted)
            {
                mCameraView.Start();
            }
            else if (ActivityCompat.ShouldShowRequestPermissionRationale(this,
                Manifest.Permission.Camera))
            {
                ConfirmationDialogFragment.NewInstance(
                    Resource.String.camera_permission_confirmation, 
                    new string[] { Manifest.Permission.Camera },
                    REQUEST_CAMERA_PERMISSION,
                    Resource.String.camera_permission_not_granted).Show(SupportFragmentManager, FRAGMENT_DIALOG);
            }
            else
            {
                ActivityCompat.RequestPermissions(this, new string[] { Manifest.Permission.Camera },
                    REQUEST_CAMERA_PERMISSION);
            }
        }

        protected override void OnPause()
        {
            mCameraView.Stop();

            base.OnPause();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            switch (requestCode)
            {
                case REQUEST_CAMERA_PERMISSION:
                    if (permissions.Length != 1 || grantResults.Length != 1)
                    {
                        throw new RuntimeException("Error on requesting camera permission.");
                    }
                    if (grantResults[0] != Permission.Granted)
                    {
                        Toast.MakeText(this, Resource.String.camera_permission_not_granted, ToastLength.Short).Show();
                    }

                    // No need to start camera here; it is handled by onResume

                    break;
            }
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.aspect_ratio:
                    if (mCameraView != null && SupportFragmentManager.FindFragmentByTag(FRAGMENT_DIALOG) == null)
                    {
                        AspectRatio[] ratios = mCameraView.SupportedAspectRatios.ToArray();
                        AspectRatio currentRatio = mCameraView.AspectRatio;

                        AspectRatioFragment.NewInstance(ratios, currentRatio).Show(SupportFragmentManager, FRAGMENT_DIALOG);
                    }
                    return true;
                case Resource.Id.switch_flash:
                    if (mCameraView != null)
                    {
                        mCurrentFlash = (mCurrentFlash + 1) % FLASH_OPTIONS.Length;
                        item.SetTitle(FLASH_TITLES[mCurrentFlash]);
                        item.SetIcon(FLASH_ICONS[mCurrentFlash]);
                        mCameraView.Flash = FLASH_OPTIONS[mCurrentFlash];
                    }
                    return true;
                case Resource.Id.switch_camera:
                    if (mCameraView != null)
                    {
                        int facing = mCameraView.Facing;
                        mCameraView.Facing = facing == CameraView.FacingFront ?
                            CameraView.FacingBack : CameraView.FacingFront;
                    }
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }
        
        public void OnAspectRatioSelected(AspectRatio ratio)
        {
            if (mCameraView != null)
            {
                Toast.MakeText(this, ratio.ToString(), ToastLength.Short).Show();
                mCameraView.AspectRatio = ratio;
            }
        }

        class ClickListener : Java.Lang.Object, View.IOnClickListener
        {

            private CameraView mCameraView;

            public ClickListener(CameraView mCameraView)
            {
                this.mCameraView = mCameraView;
            }
            public void OnClick(View v)
            {
                switch (v.Id)
                {
                    case Resource.Id.take_picture:
                        if (mCameraView != null)
                        {
                            mCameraView.TakePicture();
                        }
                        break;
                }
            }
        }

        class CameraViewCallback : CameraView.Callback
        {

            private CameraView mCameraView;

            public CameraViewCallback(CameraView mCameraView)
            {
                this.mCameraView = mCameraView;
            }

            public override async void OnPictureTaken(CameraView p0, byte[] p1)
            {
                Toast.MakeText(mCameraView.Context, Resource.String.picture_taken, ToastLength.Short).Show();

                var path = System.IO.Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath.ToString(), "Test");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                var filename = System.IO.Path.Combine(path, "test.jpg");

                if (System.IO.File.Exists(filename))
                {
                    System.IO.File.Delete(filename);
                }
                
                try
                {
                    //Bitmap aoOriginalImage = await BitmapFactory.DecodeByteArrayAsync(p1, 0, p1.Length);

                    //using (Stream aoStream = System.IO.File.Create(filename))
                    //{
                    //    await aoOriginalImage.CompressAsync(Bitmap.CompressFormat.Jpeg, 90, aoStream);

                    //    aoOriginalImage.Dispose();
                    //}
                    FileOutputStream outStream = new FileOutputStream(path + "/" + "pic.jpg");
                    outStream.Write(p1);
                    outStream.Close();
                }
                catch (Exception e)
                {
                    throw new IllegalArgumentException();
                }
            }
        }
    }
}

