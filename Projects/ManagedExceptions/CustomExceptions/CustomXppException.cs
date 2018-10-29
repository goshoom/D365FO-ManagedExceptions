using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Dynamics.Ax.Xpp; // Microsoft.Dynamics.AX.Server.Core.dll, Microsoft.Dynamics.AX.Xpp.Support.dll, Microsoft.Dynamics.AX.Xpp.AxShared.dll
using System.Runtime.Serialization;

namespace Goshoom.DynamicsAX
{
    /// <summary>
    /// The <c>CustomXppException</c> class is intended as the parent class of all custom managed exceptions
    /// used from Dynamics 365 for Finance and Operations. It provides coomon logic for handling labels.
    /// </summary>
    public abstract class CustomXppException : ErrorException
    {
        public CustomXppException() : this(null)
        {
        }

        public CustomXppException(string message, bool sendToInfolog) : base(InterpretLabel(message), sendToInfolog)
        {
        }

        public CustomXppException(string message) : base(InterpretLabel(message))
        {
        }

        public CustomXppException(string message, Exception inner) : base(InterpretLabel(message), inner)
        {
        }

        protected CustomXppException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        public static string InterpretLabel(string text, params object[] arguments)
        {
            string s = text;

            try
            {
                if (!String.IsNullOrEmpty(s) && LabelHelper.IsValidLabelId(s))
                {
                    s = LabelHelper.GetLabel(s);
                }

                if (arguments?.Length > 0)
                {
                    s = PredefinedFunctions.strfmt(s, arguments);
                }
            }
            catch {} // Do nothing, return the original text

            return s;
        }
    }
}
