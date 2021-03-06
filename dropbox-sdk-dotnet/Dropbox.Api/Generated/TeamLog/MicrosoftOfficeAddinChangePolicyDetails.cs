// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Enabled or disabled the Microsoft Office add-in, which lets team members save
    /// files to Dropbox directly from Microsoft Office.</para>
    /// </summary>
    public class MicrosoftOfficeAddinChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MicrosoftOfficeAddinChangePolicyDetails> Encoder = new MicrosoftOfficeAddinChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MicrosoftOfficeAddinChangePolicyDetails> Decoder = new MicrosoftOfficeAddinChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="MicrosoftOfficeAddinChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New Microsoft Office addin policy.</param>
        /// <param name="previousValue">Previous Microsoft Office addin policy. Might be
        /// missing due to historical data gap.</param>
        public MicrosoftOfficeAddinChangePolicyDetails(EnableDisableChangePolicy newValue,
                                                       EnableDisableChangePolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="MicrosoftOfficeAddinChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MicrosoftOfficeAddinChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New Microsoft Office addin policy.</para>
        /// </summary>
        public EnableDisableChangePolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous Microsoft Office addin policy. Might be missing due to historical
        /// data gap.</para>
        /// </summary>
        public EnableDisableChangePolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MicrosoftOfficeAddinChangePolicyDetails" />.</para>
        /// </summary>
        private class MicrosoftOfficeAddinChangePolicyDetailsEncoder : enc.StructEncoder<MicrosoftOfficeAddinChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MicrosoftOfficeAddinChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.EnableDisableChangePolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.EnableDisableChangePolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MicrosoftOfficeAddinChangePolicyDetails" />.</para>
        /// </summary>
        private class MicrosoftOfficeAddinChangePolicyDetailsDecoder : enc.StructDecoder<MicrosoftOfficeAddinChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="MicrosoftOfficeAddinChangePolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MicrosoftOfficeAddinChangePolicyDetails Create()
            {
                return new MicrosoftOfficeAddinChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MicrosoftOfficeAddinChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.EnableDisableChangePolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.EnableDisableChangePolicy.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
