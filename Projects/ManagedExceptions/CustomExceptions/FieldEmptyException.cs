using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Dynamics.Ax.Xpp;
using System.Runtime.Serialization;

namespace Goshoom.DynamicsAX
{
    /// <summary>
    /// The exception is thrown when a table field is empty, but the logic requires that the field
    /// must have a value filled in.
    /// </summary>
    [Serializable]
    public class FieldEmptyException : CustomXppException
    {
        /// <summary>
        /// Gets the name of the field that cuases this exception.
        /// </summary>
        public string FieldName { get; private set; }
        /// <summary>
        /// Gets the data record (if provided) that causes this exception.
        /// </summary>
        public Common Record { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <c>FieldEmptyException</c> class.
        /// </summary>
        public FieldEmptyException() : this("@SYS26333", true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <c>FieldEmptyException</c> class with the name of the field
        /// that causes this exception.
        /// </summary>
        /// <param name="fieldName">The name of the field that caused the exception.</param>
        public FieldEmptyException(string fieldName) : this(InterpretLabel("@SYS26332", fieldName), true)
        {
            FieldName = fieldName;
        }

        /// <summary>
        /// Initializes a new instance of the <c>FieldEmptyException</c> class with the name of the field
        /// and the data record that cause this exception.
        /// </summary>
        /// <param name="fieldName">The name of the field that caused the exception.</param>
        /// <param name="record">The data record that causes this exception</param>
        public FieldEmptyException(string fieldName, Common record) : this(InterpretLabel("@SYS26332", fieldName), true)
        {
            FieldName = fieldName;
            Record = record;
        }

        /// <summary>
        /// Initializes a new instance of the <c>FieldEmptyException</c> class with a specified error message
        /// and a flag indicating whether it should be displayed in infolog.
        /// </summary>
        /// <param name="message">The error message that explains the reason for this exception.</param>
        /// <param name="sendToInfolog">Indicates whether the error message should be displayed in infolog.</param>
        public FieldEmptyException(string message, bool sendToInfolog) : base(message, sendToInfolog)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <c>FieldEmptyException</c> class with a specified error message
        /// and the exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for this exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception,
        /// or a null reference if no inner exception is specified.</param>
        public FieldEmptyException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <c>FieldEmptyException</c> class with serialized data.
        /// </summary>
        protected FieldEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
