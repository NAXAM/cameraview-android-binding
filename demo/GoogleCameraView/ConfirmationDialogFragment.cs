using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Java.Lang;
using String = System.String;

namespace GoogleCameraView
{
    public class ConfirmationDialogFragment : Android.Support.V4.App.DialogFragment
    {

        private const string ARG_MESSAGE = "message";
        private const string ARG_PERMISSIONS = "permissions";
        private const string ARG_REQUEST_CODE = "request_code";
        private const string ARG_NOT_GRANTED_MESSAGE = "not_granted_message";

        public static ConfirmationDialogFragment NewInstance(int message, String[] permissions, int requestCode, int notGrantedMessage)
        {
            ConfirmationDialogFragment fragment = new ConfirmationDialogFragment();
            Bundle args = new Bundle();
            args.PutInt(ARG_MESSAGE, message);
            args.PutStringArray(ARG_PERMISSIONS, permissions);
            args.PutInt(ARG_REQUEST_CODE, requestCode);
            args.PutInt(ARG_NOT_GRANTED_MESSAGE, notGrantedMessage);
            fragment.Arguments = args;

            return fragment;
        }

        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            Bundle args = Arguments;

            return new AlertDialog.Builder(Activity)
                .SetMessage(args.GetInt(ARG_MESSAGE))
                .SetPositiveButton(Android.Resource.String.Ok, (sender, eargs) =>
                {
                    String[] permissions = args.GetStringArray(ARG_PERMISSIONS);

                    if (permissions == null)
                    {
                        throw new IllegalArgumentException();
                    }

                    ActivityCompat.RequestPermissions(Activity,
                        permissions, args.GetInt(ARG_REQUEST_CODE));
                })
                .SetNegativeButton(Android.Resource.String.Cancel, (sender, eargs) =>
                {
                    Toast.MakeText(Activity,
                        args.GetInt(ARG_NOT_GRANTED_MESSAGE),
                        ToastLength.Short).Show();
                }).Create();
        }
    }
}