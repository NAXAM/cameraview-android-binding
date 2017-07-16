using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Google.Android.Cameraview;
using Java.Lang;

namespace GoogleCameraView
{
    public interface Listener
    {
        void OnAspectRatioSelected(AspectRatio ratio);
    }

    public class AspectRatioFragment : Android.Support.V4.App.DialogFragment
    {

        private const string ARG_ASPECT_RATIOS = "aspect_ratios";
        private const string ARG_CURRENT_ASPECT_RATIO = "current_aspect_ratio";

        private Listener mListener;

        public static AspectRatioFragment NewInstance(IList<AspectRatio> ratios, AspectRatio currentRatio)
        {
            AspectRatioFragment fragment = new AspectRatioFragment();
            Bundle args = new Bundle();

            args.PutParcelableArray(ARG_ASPECT_RATIOS, ratios.ToArray());
            args.PutParcelable(ARG_CURRENT_ASPECT_RATIO, currentRatio);
            fragment.Arguments = args;

            return fragment;
        }

        public override void OnAttach(Context context)
        {
            base.OnAttach(context);

            mListener = (Listener)context;
        }

        public override void OnDetach()
        {
            mListener = null;

            base.OnDetach();
        }

        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            Bundle args = Arguments;
            var items = args.GetParcelableArray(ARG_ASPECT_RATIOS);
            
            if (items == null)
            {
                throw new InvalidDataException("No ratios");
            }

            AspectRatio[] ratios = new AspectRatio[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                ratios[i] = items[i].JavaCast<AspectRatio>();
            }

            AspectRatio current = args.GetParcelable(ARG_CURRENT_ASPECT_RATIO) as AspectRatio;

            AspectRatioAdapter adapter = new AspectRatioAdapter(ratios, current);

            return new AlertDialog.Builder(Activity).SetAdapter(adapter, (sender, eargs) =>
                {
                    mListener.OnAspectRatioSelected(ratios[eargs.Which]);
                }).Create();
        }
    }
}