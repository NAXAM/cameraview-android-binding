using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Google.Android.Cameraview;
using Object = Java.Lang.Object;

namespace GoogleCameraView
{
    public class AspectRatioAdapter : BaseAdapter
    {

        private readonly AspectRatio[] mRatios;
        private readonly AspectRatio mCurrentRatio;

        public AspectRatioAdapter(AspectRatio[] ratios, AspectRatio current)
        {
            mRatios = ratios;
            mCurrentRatio = current;
        }

        public override int Count
        {
            get
            {
                return mRatios.Length;
            }
        }

        public override Object GetItem(int position)
        {
            return mRatios[position];
        }

        public override long GetItemId(int position)
        {
            return GetItem(position).GetHashCode();
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ViewHolder holder;

            if (convertView == null)
            {
                convertView = LayoutInflater.From(parent.Context).Inflate(Android.Resource.Layout.SimpleListItem1, parent, false);

                holder = new ViewHolder();
                holder.Text = convertView.FindViewById<TextView>(Android.Resource.Id.Text1);

                convertView.Tag = holder;
            }
            else
            {
                holder = convertView.Tag as ViewHolder;
            }

            AspectRatio ratio = GetItem(position) as AspectRatio;
            StringBuilder sb = new StringBuilder(ratio.ToString());

            if (ratio.Equals(mCurrentRatio))
            {
                sb.Append(" *");
            }

            holder.Text.Text = sb.ToString();

            return convertView;
        }
    }

    public class ViewHolder : Java.Lang.Object
    {
        public TextView Text { get; set; }
    }
}