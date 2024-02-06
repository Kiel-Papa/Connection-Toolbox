// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/OptionDefinition/OptExpiryDefinition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/OptionDefinition/OptExpiryDefinition.proto</summary>
  public static partial class OptExpiryDefinitionReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/OptionDefinition/OptExpiryDefinition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OptExpiryDefinitionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNQcm90b2J1Zi9PcHRpb25EZWZpbml0aW9uL09wdEV4cGlyeURlZmluaXRp",
            "b24ucHJvdG8SE3NwaWRlcnJvY2sucHJvdG9idWYaF3NwaWRlcnJvY2tfY29t",
            "bW9uLnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvIt4F",
            "ChNPcHRFeHBpcnlEZWZpbml0aW9uEjMKBV9tZXRhGAEgASgLMiQuc3BpZGVy",
            "cm9jay5wcm90b2J1Zi5NZXNzYWdlTWV0YWRhdGESOwoEcGtleRgCIAEoCzIt",
            "LnNwaWRlcnJvY2sucHJvdG9idWYuT3B0RXhwaXJ5RGVmaW5pdGlvbi5QS2V5",
            "Ei4KBnRpY2tlchhkIAEoCzIeLnNwaWRlcnJvY2sucHJvdG9idWYuVGlja2Vy",
            "S2V5EiwKBGZrZXkYZyABKAsyHi5zcGlkZXJyb2NrLnByb3RvYnVmLkV4cGly",
            "eUtleRI4ChB1X3ByY19kcml2ZXJfa2V5GGogASgLMh4uc3BpZGVycm9jay5w",
            "cm90b2J1Zi5FeHBpcnlLZXkSPwoVdV9wcmNfZHJpdmVyX2tleV90eXBlGG0g",
            "ASgOMiAuc3BpZGVycm9jay5wcm90b2J1Zi5TcGRyS2V5VHlwZRI4ChB1X3By",
            "Y19ib3VuZF9mS2V5GHAgASgLMh4uc3BpZGVycm9jay5wcm90b2J1Zi5FeHBp",
            "cnlLZXkSLgoKZXhwaXJhdGlvbhhzIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5U",
            "aW1lc3RhbXASMQoNbWF0dXJpdHlfZGF0ZRh2IAEoCzIaLmdvb2dsZS5wcm90",
            "b2J1Zi5UaW1lc3RhbXASFgoOZGlzcGxheV9mYWN0b3IYeSABKAESEQoJY2Fi",
            "X3ByaWNlGHwgASgBEjYKDHByaWNlX2Zvcm1hdBh/IAEoDjIgLnNwaWRlcnJv",
            "Y2sucHJvdG9idWYuUHJpY2VGb3JtYXQSFgoNbWluX3RpY2tfc2l6ZRiCASAB",
            "KAESLgoJdGltZXN0YW1wGIUBIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1l",
            "c3RhbXAaNAoEUEtleRIsCgRla2V5GAogASgLMh4uc3BpZGVycm9jay5wcm90",
            "b2J1Zi5FeHBpcnlLZXliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.OptExpiryDefinition), global::Spiderrock.Protobuf.OptExpiryDefinition.Parser, new[]{ "Meta", "Pkey", "Ticker", "Fkey", "UPrcDriverKey", "UPrcDriverKeyType", "UPrcBoundFKey", "Expiration", "MaturityDate", "DisplayFactor", "CabPrice", "PriceFormat", "MinTickSize", "Timestamp" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.OptExpiryDefinition.Types.PKey), global::Spiderrock.Protobuf.OptExpiryDefinition.Types.PKey.Parser, new[]{ "Ekey" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  ///This table maps option root/expiration combinations to their deliverable future.  Mappings are sourced fromm listing exchange product definitions.
  ///BaseObj:Root
  /// </summary>
  public sealed partial class OptExpiryDefinition : pb::IMessage<OptExpiryDefinition>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OptExpiryDefinition> _parser = new pb::MessageParser<OptExpiryDefinition>(() => new OptExpiryDefinition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OptExpiryDefinition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.OptExpiryDefinitionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OptExpiryDefinition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OptExpiryDefinition(OptExpiryDefinition other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      pkey_ = other.pkey_ != null ? other.pkey_.Clone() : null;
      ticker_ = other.ticker_ != null ? other.ticker_.Clone() : null;
      fkey_ = other.fkey_ != null ? other.fkey_.Clone() : null;
      uPrcDriverKey_ = other.uPrcDriverKey_ != null ? other.uPrcDriverKey_.Clone() : null;
      uPrcDriverKeyType_ = other.uPrcDriverKeyType_;
      uPrcBoundFKey_ = other.uPrcBoundFKey_ != null ? other.uPrcBoundFKey_.Clone() : null;
      expiration_ = other.expiration_ != null ? other.expiration_.Clone() : null;
      maturityDate_ = other.maturityDate_ != null ? other.maturityDate_.Clone() : null;
      displayFactor_ = other.displayFactor_;
      cabPrice_ = other.cabPrice_;
      priceFormat_ = other.priceFormat_;
      minTickSize_ = other.minTickSize_;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OptExpiryDefinition Clone() {
      return new OptExpiryDefinition(this);
    }

    /// <summary>Field number for the "_meta" field.</summary>
    public const int MetaFieldNumber = 1;
    private global::Spiderrock.Protobuf.MessageMetadata Meta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.MessageMetadata Meta {
      get { return Meta_; }
      set {
        Meta_ = value;
      }
    }

    /// <summary>Field number for the "pkey" field.</summary>
    public const int PkeyFieldNumber = 2;
    private global::Spiderrock.Protobuf.OptExpiryDefinition.Types.PKey pkey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.OptExpiryDefinition.Types.PKey Pkey {
      get { return pkey_; }
      set {
        pkey_ = value;
      }
    }

    /// <summary>Field number for the "ticker" field.</summary>
    public const int TickerFieldNumber = 100;
    private global::Spiderrock.Protobuf.TickerKey ticker_;
    /// <summary>
    /// master ticker
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.TickerKey Ticker {
      get { return ticker_; }
      set {
        ticker_ = value;
      }
    }

    /// <summary>Field number for the "fkey" field.</summary>
    public const int FkeyFieldNumber = 103;
    private global::Spiderrock.Protobuf.ExpiryKey fkey_;
    /// <summary>
    /// settlement future (if any)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.ExpiryKey Fkey {
      get { return fkey_; }
      set {
        fkey_ = value;
      }
    }

    /// <summary>Field number for the "u_prc_driver_key" field.</summary>
    public const int UPrcDriverKeyFieldNumber = 106;
    private global::Spiderrock.Protobuf.ExpiryKey uPrcDriverKey_;
    /// <summary>
    /// underlier price driver for this option expiry (default is fkey; if it exists)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.ExpiryKey UPrcDriverKey {
      get { return uPrcDriverKey_; }
      set {
        uPrcDriverKey_ = value;
      }
    }

    /// <summary>Field number for the "u_prc_driver_key_type" field.</summary>
    public const int UPrcDriverKeyTypeFieldNumber = 109;
    private global::Spiderrock.Protobuf.SpdrKeyType uPrcDriverKeyType_ = global::Spiderrock.Protobuf.SpdrKeyType.Unspecified;
    /// <summary>
    /// Stock or Future
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.SpdrKeyType UPrcDriverKeyType {
      get { return uPrcDriverKeyType_; }
      set {
        uPrcDriverKeyType_ = value;
      }
    }

    /// <summary>Field number for the "u_prc_bound_fKey" field.</summary>
    public const int UPrcBoundFKeyFieldNumber = 112;
    private global::Spiderrock.Protobuf.ExpiryKey uPrcBoundFKey_;
    /// <summary>
    /// underlier price bounding future (if any) for this option expiry
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.ExpiryKey UPrcBoundFKey {
      get { return uPrcBoundFKey_; }
      set {
        uPrcBoundFKey_ = value;
      }
    }

    /// <summary>Field number for the "expiration" field.</summary>
    public const int ExpirationFieldNumber = 115;
    private global::Google.Protobuf.WellKnownTypes.Timestamp expiration_;
    /// <summary>
    /// option expiration date and time
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Expiration {
      get { return expiration_; }
      set {
        expiration_ = value;
      }
    }

    /// <summary>Field number for the "maturity_date" field.</summary>
    public const int MaturityDateFieldNumber = 118;
    private global::Google.Protobuf.WellKnownTypes.Timestamp maturityDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp MaturityDate {
      get { return maturityDate_; }
      set {
        maturityDate_ = value;
      }
    }

    /// <summary>Field number for the "display_factor" field.</summary>
    public const int DisplayFactorFieldNumber = 121;
    private double displayFactor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double DisplayFactor {
      get { return displayFactor_; }
      set {
        displayFactor_ = value;
      }
    }

    /// <summary>Field number for the "cab_price" field.</summary>
    public const int CabPriceFieldNumber = 124;
    private double cabPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double CabPrice {
      get { return cabPrice_; }
      set {
        cabPrice_ = value;
      }
    }

    /// <summary>Field number for the "price_format" field.</summary>
    public const int PriceFormatFieldNumber = 127;
    private global::Spiderrock.Protobuf.PriceFormat priceFormat_ = global::Spiderrock.Protobuf.PriceFormat.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.PriceFormat PriceFormat {
      get { return priceFormat_; }
      set {
        priceFormat_ = value;
      }
    }

    /// <summary>Field number for the "min_tick_size" field.</summary>
    public const int MinTickSizeFieldNumber = 130;
    private double minTickSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double MinTickSize {
      get { return minTickSize_; }
      set {
        minTickSize_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 133;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OptExpiryDefinition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OptExpiryDefinition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (!object.Equals(Pkey, other.Pkey)) return false;
      if (!object.Equals(Ticker, other.Ticker)) return false;
      if (!object.Equals(Fkey, other.Fkey)) return false;
      if (!object.Equals(UPrcDriverKey, other.UPrcDriverKey)) return false;
      if (UPrcDriverKeyType != other.UPrcDriverKeyType) return false;
      if (!object.Equals(UPrcBoundFKey, other.UPrcBoundFKey)) return false;
      if (!object.Equals(Expiration, other.Expiration)) return false;
      if (!object.Equals(MaturityDate, other.MaturityDate)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DisplayFactor, other.DisplayFactor)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CabPrice, other.CabPrice)) return false;
      if (PriceFormat != other.PriceFormat) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MinTickSize, other.MinTickSize)) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (pkey_ != null) hash ^= Pkey.GetHashCode();
      if (ticker_ != null) hash ^= Ticker.GetHashCode();
      if (fkey_ != null) hash ^= Fkey.GetHashCode();
      if (uPrcDriverKey_ != null) hash ^= UPrcDriverKey.GetHashCode();
      if (UPrcDriverKeyType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) hash ^= UPrcDriverKeyType.GetHashCode();
      if (uPrcBoundFKey_ != null) hash ^= UPrcBoundFKey.GetHashCode();
      if (expiration_ != null) hash ^= Expiration.GetHashCode();
      if (maturityDate_ != null) hash ^= MaturityDate.GetHashCode();
      if (DisplayFactor != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DisplayFactor);
      if (CabPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CabPrice);
      if (PriceFormat != global::Spiderrock.Protobuf.PriceFormat.Unspecified) hash ^= PriceFormat.GetHashCode();
      if (MinTickSize != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MinTickSize);
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Meta_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Meta);
      }
      if (pkey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pkey);
      }
      if (ticker_ != null) {
        output.WriteRawTag(162, 6);
        output.WriteMessage(Ticker);
      }
      if (fkey_ != null) {
        output.WriteRawTag(186, 6);
        output.WriteMessage(Fkey);
      }
      if (uPrcDriverKey_ != null) {
        output.WriteRawTag(210, 6);
        output.WriteMessage(UPrcDriverKey);
      }
      if (UPrcDriverKeyType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
        output.WriteRawTag(232, 6);
        output.WriteEnum((int) UPrcDriverKeyType);
      }
      if (uPrcBoundFKey_ != null) {
        output.WriteRawTag(130, 7);
        output.WriteMessage(UPrcBoundFKey);
      }
      if (expiration_ != null) {
        output.WriteRawTag(154, 7);
        output.WriteMessage(Expiration);
      }
      if (maturityDate_ != null) {
        output.WriteRawTag(178, 7);
        output.WriteMessage(MaturityDate);
      }
      if (DisplayFactor != 0D) {
        output.WriteRawTag(201, 7);
        output.WriteDouble(DisplayFactor);
      }
      if (CabPrice != 0D) {
        output.WriteRawTag(225, 7);
        output.WriteDouble(CabPrice);
      }
      if (PriceFormat != global::Spiderrock.Protobuf.PriceFormat.Unspecified) {
        output.WriteRawTag(248, 7);
        output.WriteEnum((int) PriceFormat);
      }
      if (MinTickSize != 0D) {
        output.WriteRawTag(145, 8);
        output.WriteDouble(MinTickSize);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(170, 8);
        output.WriteMessage(Timestamp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Meta_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Meta);
      }
      if (pkey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pkey);
      }
      if (ticker_ != null) {
        output.WriteRawTag(162, 6);
        output.WriteMessage(Ticker);
      }
      if (fkey_ != null) {
        output.WriteRawTag(186, 6);
        output.WriteMessage(Fkey);
      }
      if (uPrcDriverKey_ != null) {
        output.WriteRawTag(210, 6);
        output.WriteMessage(UPrcDriverKey);
      }
      if (UPrcDriverKeyType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
        output.WriteRawTag(232, 6);
        output.WriteEnum((int) UPrcDriverKeyType);
      }
      if (uPrcBoundFKey_ != null) {
        output.WriteRawTag(130, 7);
        output.WriteMessage(UPrcBoundFKey);
      }
      if (expiration_ != null) {
        output.WriteRawTag(154, 7);
        output.WriteMessage(Expiration);
      }
      if (maturityDate_ != null) {
        output.WriteRawTag(178, 7);
        output.WriteMessage(MaturityDate);
      }
      if (DisplayFactor != 0D) {
        output.WriteRawTag(201, 7);
        output.WriteDouble(DisplayFactor);
      }
      if (CabPrice != 0D) {
        output.WriteRawTag(225, 7);
        output.WriteDouble(CabPrice);
      }
      if (PriceFormat != global::Spiderrock.Protobuf.PriceFormat.Unspecified) {
        output.WriteRawTag(248, 7);
        output.WriteEnum((int) PriceFormat);
      }
      if (MinTickSize != 0D) {
        output.WriteRawTag(145, 8);
        output.WriteDouble(MinTickSize);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(170, 8);
        output.WriteMessage(Timestamp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Meta_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Meta);
      }
      if (pkey_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pkey);
      }
      if (ticker_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Ticker);
      }
      if (fkey_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Fkey);
      }
      if (uPrcDriverKey_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(UPrcDriverKey);
      }
      if (UPrcDriverKeyType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) UPrcDriverKeyType);
      }
      if (uPrcBoundFKey_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(UPrcBoundFKey);
      }
      if (expiration_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Expiration);
      }
      if (maturityDate_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(MaturityDate);
      }
      if (DisplayFactor != 0D) {
        size += 2 + 8;
      }
      if (CabPrice != 0D) {
        size += 2 + 8;
      }
      if (PriceFormat != global::Spiderrock.Protobuf.PriceFormat.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) PriceFormat);
      }
      if (MinTickSize != 0D) {
        size += 2 + 8;
      }
      if (timestamp_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OptExpiryDefinition other) {
      if (other == null) {
        return;
      }
      if (other.Meta_ != null) {
        if (Meta_ == null) {
          Meta = new global::Spiderrock.Protobuf.MessageMetadata();
        }
        Meta.MergeFrom(other.Meta);
      }
      if (other.pkey_ != null) {
        if (pkey_ == null) {
          Pkey = new global::Spiderrock.Protobuf.OptExpiryDefinition.Types.PKey();
        }
        Pkey.MergeFrom(other.Pkey);
      }
      if (other.ticker_ != null) {
        if (ticker_ == null) {
          Ticker = new global::Spiderrock.Protobuf.TickerKey();
        }
        Ticker.MergeFrom(other.Ticker);
      }
      if (other.fkey_ != null) {
        if (fkey_ == null) {
          Fkey = new global::Spiderrock.Protobuf.ExpiryKey();
        }
        Fkey.MergeFrom(other.Fkey);
      }
      if (other.uPrcDriverKey_ != null) {
        if (uPrcDriverKey_ == null) {
          UPrcDriverKey = new global::Spiderrock.Protobuf.ExpiryKey();
        }
        UPrcDriverKey.MergeFrom(other.UPrcDriverKey);
      }
      if (other.UPrcDriverKeyType != global::Spiderrock.Protobuf.SpdrKeyType.Unspecified) {
        UPrcDriverKeyType = other.UPrcDriverKeyType;
      }
      if (other.uPrcBoundFKey_ != null) {
        if (uPrcBoundFKey_ == null) {
          UPrcBoundFKey = new global::Spiderrock.Protobuf.ExpiryKey();
        }
        UPrcBoundFKey.MergeFrom(other.UPrcBoundFKey);
      }
      if (other.expiration_ != null) {
        if (expiration_ == null) {
          Expiration = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Expiration.MergeFrom(other.Expiration);
      }
      if (other.maturityDate_ != null) {
        if (maturityDate_ == null) {
          MaturityDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        MaturityDate.MergeFrom(other.MaturityDate);
      }
      if (other.DisplayFactor != 0D) {
        DisplayFactor = other.DisplayFactor;
      }
      if (other.CabPrice != 0D) {
        CabPrice = other.CabPrice;
      }
      if (other.PriceFormat != global::Spiderrock.Protobuf.PriceFormat.Unspecified) {
        PriceFormat = other.PriceFormat;
      }
      if (other.MinTickSize != 0D) {
        MinTickSize = other.MinTickSize;
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Timestamp.MergeFrom(other.Timestamp);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (Meta_ == null) {
              Meta = new global::Spiderrock.Protobuf.MessageMetadata();
            }
            input.ReadMessage(Meta);
            break;
          }
          case 18: {
            if (pkey_ == null) {
              Pkey = new global::Spiderrock.Protobuf.OptExpiryDefinition.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            if (ticker_ == null) {
              Ticker = new global::Spiderrock.Protobuf.TickerKey();
            }
            input.ReadMessage(Ticker);
            break;
          }
          case 826: {
            if (fkey_ == null) {
              Fkey = new global::Spiderrock.Protobuf.ExpiryKey();
            }
            input.ReadMessage(Fkey);
            break;
          }
          case 850: {
            if (uPrcDriverKey_ == null) {
              UPrcDriverKey = new global::Spiderrock.Protobuf.ExpiryKey();
            }
            input.ReadMessage(UPrcDriverKey);
            break;
          }
          case 872: {
            UPrcDriverKeyType = (global::Spiderrock.Protobuf.SpdrKeyType) input.ReadEnum();
            break;
          }
          case 898: {
            if (uPrcBoundFKey_ == null) {
              UPrcBoundFKey = new global::Spiderrock.Protobuf.ExpiryKey();
            }
            input.ReadMessage(UPrcBoundFKey);
            break;
          }
          case 922: {
            if (expiration_ == null) {
              Expiration = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Expiration);
            break;
          }
          case 946: {
            if (maturityDate_ == null) {
              MaturityDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(MaturityDate);
            break;
          }
          case 969: {
            DisplayFactor = input.ReadDouble();
            break;
          }
          case 993: {
            CabPrice = input.ReadDouble();
            break;
          }
          case 1016: {
            PriceFormat = (global::Spiderrock.Protobuf.PriceFormat) input.ReadEnum();
            break;
          }
          case 1041: {
            MinTickSize = input.ReadDouble();
            break;
          }
          case 1066: {
            if (timestamp_ == null) {
              Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Timestamp);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (Meta_ == null) {
              Meta = new global::Spiderrock.Protobuf.MessageMetadata();
            }
            input.ReadMessage(Meta);
            break;
          }
          case 18: {
            if (pkey_ == null) {
              Pkey = new global::Spiderrock.Protobuf.OptExpiryDefinition.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            if (ticker_ == null) {
              Ticker = new global::Spiderrock.Protobuf.TickerKey();
            }
            input.ReadMessage(Ticker);
            break;
          }
          case 826: {
            if (fkey_ == null) {
              Fkey = new global::Spiderrock.Protobuf.ExpiryKey();
            }
            input.ReadMessage(Fkey);
            break;
          }
          case 850: {
            if (uPrcDriverKey_ == null) {
              UPrcDriverKey = new global::Spiderrock.Protobuf.ExpiryKey();
            }
            input.ReadMessage(UPrcDriverKey);
            break;
          }
          case 872: {
            UPrcDriverKeyType = (global::Spiderrock.Protobuf.SpdrKeyType) input.ReadEnum();
            break;
          }
          case 898: {
            if (uPrcBoundFKey_ == null) {
              UPrcBoundFKey = new global::Spiderrock.Protobuf.ExpiryKey();
            }
            input.ReadMessage(UPrcBoundFKey);
            break;
          }
          case 922: {
            if (expiration_ == null) {
              Expiration = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Expiration);
            break;
          }
          case 946: {
            if (maturityDate_ == null) {
              MaturityDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(MaturityDate);
            break;
          }
          case 969: {
            DisplayFactor = input.ReadDouble();
            break;
          }
          case 993: {
            CabPrice = input.ReadDouble();
            break;
          }
          case 1016: {
            PriceFormat = (global::Spiderrock.Protobuf.PriceFormat) input.ReadEnum();
            break;
          }
          case 1041: {
            MinTickSize = input.ReadDouble();
            break;
          }
          case 1066: {
            if (timestamp_ == null) {
              Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Timestamp);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the OptExpiryDefinition message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class PKey : pb::IMessage<PKey>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<PKey> _parser = new pb::MessageParser<PKey>(() => new PKey());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<PKey> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Spiderrock.Protobuf.OptExpiryDefinition.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey(PKey other) : this() {
          ekey_ = other.ekey_ != null ? other.ekey_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey Clone() {
          return new PKey(this);
        }

        /// <summary>Field number for the "ekey" field.</summary>
        public const int EkeyFieldNumber = 10;
        private global::Spiderrock.Protobuf.ExpiryKey ekey_;
        /// <summary>
        /// option root+expiration
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Spiderrock.Protobuf.ExpiryKey Ekey {
          get { return ekey_; }
          set {
            ekey_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as PKey);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(PKey other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(Ekey, other.Ekey)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (ekey_ != null) hash ^= Ekey.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (ekey_ != null) {
            output.WriteRawTag(82);
            output.WriteMessage(Ekey);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (ekey_ != null) {
            output.WriteRawTag(82);
            output.WriteMessage(Ekey);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          if (ekey_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ekey);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(PKey other) {
          if (other == null) {
            return;
          }
          if (other.ekey_ != null) {
            if (ekey_ == null) {
              Ekey = new global::Spiderrock.Protobuf.ExpiryKey();
            }
            Ekey.MergeFrom(other.Ekey);
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 82: {
                if (ekey_ == null) {
                  Ekey = new global::Spiderrock.Protobuf.ExpiryKey();
                }
                input.ReadMessage(Ekey);
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 82: {
                if (ekey_ == null) {
                  Ekey = new global::Spiderrock.Protobuf.ExpiryKey();
                }
                input.ReadMessage(Ekey);
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
