// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/ClientConfig/UserMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/ClientConfig/UserMessage.proto</summary>
  public static partial class UserMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/ClientConfig/UserMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidQcm90b2J1Zi9DbGllbnRDb25maWcvVXNlck1lc3NhZ2UucHJvdG8SE3Nw",
            "aWRlcnJvY2sucHJvdG9idWYaF3NwaWRlcnJvY2tfY29tbW9uLnByb3RvGh9n",
            "b29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvIvIECgtVc2VyTWVzc2Fn",
            "ZRIzCgVfbWV0YRgBIAEoCzIkLnNwaWRlcnJvY2sucHJvdG9idWYuTWVzc2Fn",
            "ZU1ldGFkYXRhEjMKBHBrZXkYAiABKAsyJS5zcGlkZXJyb2NrLnByb3RvYnVm",
            "LlVzZXJNZXNzYWdlLlBLZXkSEQoJdXNlcl9uYW1lGGQgASgJEjgKDWRlbGl2",
            "ZXJ5X21vZGUYZyABKA4yIS5zcGlkZXJyb2NrLnByb3RvYnVmLkRlbGl2ZXJ5",
            "TW9kZRIXCg9jb250YWN0X2FkZHJlc3MYaiABKAkSDwoHc3ViamVjdBhtIAEo",
            "CRIPCgdtZXNzYWdlGHAgASgJEjQKC3NlbmRfcmVhc29uGHMgASgOMh8uc3Bp",
            "ZGVycm9jay5wcm90b2J1Zi5TZW5kUmVhc29uEhMKC3NlbmRfc291cmNlGHYg",
            "ASgJEjoKDmRlbGl2ZXJ5X3N0YXRlGHkgASgOMiIuc3BpZGVycm9jay5wcm90",
            "b2J1Zi5EZWxpdmVyeVN0YXRlEhYKDmRlbGl2ZXJ5X2Vycm9yGHwgASgJEjEK",
            "DWRlbGl2ZXJ5X2R0dG0YfyABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0",
            "YW1wEhQKC21vZGlmaWVkX2J5GIIBIAEoCRI5Cgttb2RpZmllZF9pbhiFASAB",
            "KA4yIy5zcGlkZXJyb2NrLnByb3RvYnVmLlN5c0Vudmlyb25tZW50Ei4KCXRp",
            "bWVzdGFtcBiIASABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wGh4K",
            "BFBLZXkSFgoObWVzc2FnZV9udW1iZXIYCiABKANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.UserMessage), global::Spiderrock.Protobuf.UserMessage.Parser, new[]{ "Meta", "Pkey", "UserName", "DeliveryMode", "ContactAddress", "Subject", "Message", "SendReason", "SendSource", "DeliveryState", "DeliveryError", "DeliveryDttm", "ModifiedBy", "ModifiedIn", "Timestamp" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.UserMessage.Types.PKey), global::Spiderrock.Protobuf.UserMessage.Types.PKey.Parser, new[]{ "MessageNumber" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UserMessage : pb::IMessage<UserMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserMessage> _parser = new pb::MessageParser<UserMessage>(() => new UserMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UserMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.UserMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserMessage(UserMessage other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      pkey_ = other.pkey_ != null ? other.pkey_.Clone() : null;
      userName_ = other.userName_;
      deliveryMode_ = other.deliveryMode_;
      contactAddress_ = other.contactAddress_;
      subject_ = other.subject_;
      message_ = other.message_;
      sendReason_ = other.sendReason_;
      sendSource_ = other.sendSource_;
      deliveryState_ = other.deliveryState_;
      deliveryError_ = other.deliveryError_;
      deliveryDttm_ = other.deliveryDttm_ != null ? other.deliveryDttm_.Clone() : null;
      modifiedBy_ = other.modifiedBy_;
      modifiedIn_ = other.modifiedIn_;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserMessage Clone() {
      return new UserMessage(this);
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
    private global::Spiderrock.Protobuf.UserMessage.Types.PKey pkey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.UserMessage.Types.PKey Pkey {
      get { return pkey_; }
      set {
        pkey_ = value;
      }
    }

    /// <summary>Field number for the "user_name" field.</summary>
    public const int UserNameFieldNumber = 100;
    private string userName_ = "";
    /// <summary>
    /// userConfig.userName
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserName {
      get { return userName_; }
      set {
        userName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "delivery_mode" field.</summary>
    public const int DeliveryModeFieldNumber = 103;
    private global::Spiderrock.Protobuf.DeliveryMode deliveryMode_ = global::Spiderrock.Protobuf.DeliveryMode.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.DeliveryMode DeliveryMode {
      get { return deliveryMode_; }
      set {
        deliveryMode_ = value;
      }
    }

    /// <summary>Field number for the "contact_address" field.</summary>
    public const int ContactAddressFieldNumber = 106;
    private string contactAddress_ = "";
    /// <summary>
    /// email address, phone #, or chat handle
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ContactAddress {
      get { return contactAddress_; }
      set {
        contactAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "subject" field.</summary>
    public const int SubjectFieldNumber = 109;
    private string subject_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Subject {
      get { return subject_; }
      set {
        subject_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 112;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "send_reason" field.</summary>
    public const int SendReasonFieldNumber = 115;
    private global::Spiderrock.Protobuf.SendReason sendReason_ = global::Spiderrock.Protobuf.SendReason.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.SendReason SendReason {
      get { return sendReason_; }
      set {
        sendReason_ = value;
      }
    }

    /// <summary>Field number for the "send_source" field.</summary>
    public const int SendSourceFieldNumber = 118;
    private string sendSource_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SendSource {
      get { return sendSource_; }
      set {
        sendSource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "delivery_state" field.</summary>
    public const int DeliveryStateFieldNumber = 121;
    private global::Spiderrock.Protobuf.DeliveryState deliveryState_ = global::Spiderrock.Protobuf.DeliveryState.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.DeliveryState DeliveryState {
      get { return deliveryState_; }
      set {
        deliveryState_ = value;
      }
    }

    /// <summary>Field number for the "delivery_error" field.</summary>
    public const int DeliveryErrorFieldNumber = 124;
    private string deliveryError_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DeliveryError {
      get { return deliveryError_; }
      set {
        deliveryError_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "delivery_dttm" field.</summary>
    public const int DeliveryDttmFieldNumber = 127;
    private global::Google.Protobuf.WellKnownTypes.Timestamp deliveryDttm_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp DeliveryDttm {
      get { return deliveryDttm_; }
      set {
        deliveryDttm_ = value;
      }
    }

    /// <summary>Field number for the "modified_by" field.</summary>
    public const int ModifiedByFieldNumber = 130;
    private string modifiedBy_ = "";
    /// <summary>
    /// user who last modified this recrd
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ModifiedBy {
      get { return modifiedBy_; }
      set {
        modifiedBy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "modified_in" field.</summary>
    public const int ModifiedInFieldNumber = 133;
    private global::Spiderrock.Protobuf.SysEnvironment modifiedIn_ = global::Spiderrock.Protobuf.SysEnvironment.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.SysEnvironment ModifiedIn {
      get { return modifiedIn_; }
      set {
        modifiedIn_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 136;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    /// <summary>
    /// timestamp of last modification
    /// </summary>
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
      return Equals(other as UserMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UserMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (!object.Equals(Pkey, other.Pkey)) return false;
      if (UserName != other.UserName) return false;
      if (DeliveryMode != other.DeliveryMode) return false;
      if (ContactAddress != other.ContactAddress) return false;
      if (Subject != other.Subject) return false;
      if (Message != other.Message) return false;
      if (SendReason != other.SendReason) return false;
      if (SendSource != other.SendSource) return false;
      if (DeliveryState != other.DeliveryState) return false;
      if (DeliveryError != other.DeliveryError) return false;
      if (!object.Equals(DeliveryDttm, other.DeliveryDttm)) return false;
      if (ModifiedBy != other.ModifiedBy) return false;
      if (ModifiedIn != other.ModifiedIn) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (pkey_ != null) hash ^= Pkey.GetHashCode();
      if (UserName.Length != 0) hash ^= UserName.GetHashCode();
      if (DeliveryMode != global::Spiderrock.Protobuf.DeliveryMode.Unspecified) hash ^= DeliveryMode.GetHashCode();
      if (ContactAddress.Length != 0) hash ^= ContactAddress.GetHashCode();
      if (Subject.Length != 0) hash ^= Subject.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (SendReason != global::Spiderrock.Protobuf.SendReason.Unspecified) hash ^= SendReason.GetHashCode();
      if (SendSource.Length != 0) hash ^= SendSource.GetHashCode();
      if (DeliveryState != global::Spiderrock.Protobuf.DeliveryState.Unspecified) hash ^= DeliveryState.GetHashCode();
      if (DeliveryError.Length != 0) hash ^= DeliveryError.GetHashCode();
      if (deliveryDttm_ != null) hash ^= DeliveryDttm.GetHashCode();
      if (ModifiedBy.Length != 0) hash ^= ModifiedBy.GetHashCode();
      if (ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) hash ^= ModifiedIn.GetHashCode();
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
      if (UserName.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(UserName);
      }
      if (DeliveryMode != global::Spiderrock.Protobuf.DeliveryMode.Unspecified) {
        output.WriteRawTag(184, 6);
        output.WriteEnum((int) DeliveryMode);
      }
      if (ContactAddress.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(ContactAddress);
      }
      if (Subject.Length != 0) {
        output.WriteRawTag(234, 6);
        output.WriteString(Subject);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(Message);
      }
      if (SendReason != global::Spiderrock.Protobuf.SendReason.Unspecified) {
        output.WriteRawTag(152, 7);
        output.WriteEnum((int) SendReason);
      }
      if (SendSource.Length != 0) {
        output.WriteRawTag(178, 7);
        output.WriteString(SendSource);
      }
      if (DeliveryState != global::Spiderrock.Protobuf.DeliveryState.Unspecified) {
        output.WriteRawTag(200, 7);
        output.WriteEnum((int) DeliveryState);
      }
      if (DeliveryError.Length != 0) {
        output.WriteRawTag(226, 7);
        output.WriteString(DeliveryError);
      }
      if (deliveryDttm_ != null) {
        output.WriteRawTag(250, 7);
        output.WriteMessage(DeliveryDttm);
      }
      if (ModifiedBy.Length != 0) {
        output.WriteRawTag(146, 8);
        output.WriteString(ModifiedBy);
      }
      if (ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        output.WriteRawTag(168, 8);
        output.WriteEnum((int) ModifiedIn);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(194, 8);
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
      if (UserName.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(UserName);
      }
      if (DeliveryMode != global::Spiderrock.Protobuf.DeliveryMode.Unspecified) {
        output.WriteRawTag(184, 6);
        output.WriteEnum((int) DeliveryMode);
      }
      if (ContactAddress.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(ContactAddress);
      }
      if (Subject.Length != 0) {
        output.WriteRawTag(234, 6);
        output.WriteString(Subject);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(Message);
      }
      if (SendReason != global::Spiderrock.Protobuf.SendReason.Unspecified) {
        output.WriteRawTag(152, 7);
        output.WriteEnum((int) SendReason);
      }
      if (SendSource.Length != 0) {
        output.WriteRawTag(178, 7);
        output.WriteString(SendSource);
      }
      if (DeliveryState != global::Spiderrock.Protobuf.DeliveryState.Unspecified) {
        output.WriteRawTag(200, 7);
        output.WriteEnum((int) DeliveryState);
      }
      if (DeliveryError.Length != 0) {
        output.WriteRawTag(226, 7);
        output.WriteString(DeliveryError);
      }
      if (deliveryDttm_ != null) {
        output.WriteRawTag(250, 7);
        output.WriteMessage(DeliveryDttm);
      }
      if (ModifiedBy.Length != 0) {
        output.WriteRawTag(146, 8);
        output.WriteString(ModifiedBy);
      }
      if (ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        output.WriteRawTag(168, 8);
        output.WriteEnum((int) ModifiedIn);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(194, 8);
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
      if (UserName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(UserName);
      }
      if (DeliveryMode != global::Spiderrock.Protobuf.DeliveryMode.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) DeliveryMode);
      }
      if (ContactAddress.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ContactAddress);
      }
      if (Subject.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Subject);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (SendReason != global::Spiderrock.Protobuf.SendReason.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) SendReason);
      }
      if (SendSource.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(SendSource);
      }
      if (DeliveryState != global::Spiderrock.Protobuf.DeliveryState.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) DeliveryState);
      }
      if (DeliveryError.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(DeliveryError);
      }
      if (deliveryDttm_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(DeliveryDttm);
      }
      if (ModifiedBy.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ModifiedBy);
      }
      if (ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) ModifiedIn);
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
    public void MergeFrom(UserMessage other) {
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
          Pkey = new global::Spiderrock.Protobuf.UserMessage.Types.PKey();
        }
        Pkey.MergeFrom(other.Pkey);
      }
      if (other.UserName.Length != 0) {
        UserName = other.UserName;
      }
      if (other.DeliveryMode != global::Spiderrock.Protobuf.DeliveryMode.Unspecified) {
        DeliveryMode = other.DeliveryMode;
      }
      if (other.ContactAddress.Length != 0) {
        ContactAddress = other.ContactAddress;
      }
      if (other.Subject.Length != 0) {
        Subject = other.Subject;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.SendReason != global::Spiderrock.Protobuf.SendReason.Unspecified) {
        SendReason = other.SendReason;
      }
      if (other.SendSource.Length != 0) {
        SendSource = other.SendSource;
      }
      if (other.DeliveryState != global::Spiderrock.Protobuf.DeliveryState.Unspecified) {
        DeliveryState = other.DeliveryState;
      }
      if (other.DeliveryError.Length != 0) {
        DeliveryError = other.DeliveryError;
      }
      if (other.deliveryDttm_ != null) {
        if (deliveryDttm_ == null) {
          DeliveryDttm = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        DeliveryDttm.MergeFrom(other.DeliveryDttm);
      }
      if (other.ModifiedBy.Length != 0) {
        ModifiedBy = other.ModifiedBy;
      }
      if (other.ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        ModifiedIn = other.ModifiedIn;
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
              Pkey = new global::Spiderrock.Protobuf.UserMessage.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            UserName = input.ReadString();
            break;
          }
          case 824: {
            DeliveryMode = (global::Spiderrock.Protobuf.DeliveryMode) input.ReadEnum();
            break;
          }
          case 850: {
            ContactAddress = input.ReadString();
            break;
          }
          case 874: {
            Subject = input.ReadString();
            break;
          }
          case 898: {
            Message = input.ReadString();
            break;
          }
          case 920: {
            SendReason = (global::Spiderrock.Protobuf.SendReason) input.ReadEnum();
            break;
          }
          case 946: {
            SendSource = input.ReadString();
            break;
          }
          case 968: {
            DeliveryState = (global::Spiderrock.Protobuf.DeliveryState) input.ReadEnum();
            break;
          }
          case 994: {
            DeliveryError = input.ReadString();
            break;
          }
          case 1018: {
            if (deliveryDttm_ == null) {
              DeliveryDttm = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DeliveryDttm);
            break;
          }
          case 1042: {
            ModifiedBy = input.ReadString();
            break;
          }
          case 1064: {
            ModifiedIn = (global::Spiderrock.Protobuf.SysEnvironment) input.ReadEnum();
            break;
          }
          case 1090: {
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
              Pkey = new global::Spiderrock.Protobuf.UserMessage.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 802: {
            UserName = input.ReadString();
            break;
          }
          case 824: {
            DeliveryMode = (global::Spiderrock.Protobuf.DeliveryMode) input.ReadEnum();
            break;
          }
          case 850: {
            ContactAddress = input.ReadString();
            break;
          }
          case 874: {
            Subject = input.ReadString();
            break;
          }
          case 898: {
            Message = input.ReadString();
            break;
          }
          case 920: {
            SendReason = (global::Spiderrock.Protobuf.SendReason) input.ReadEnum();
            break;
          }
          case 946: {
            SendSource = input.ReadString();
            break;
          }
          case 968: {
            DeliveryState = (global::Spiderrock.Protobuf.DeliveryState) input.ReadEnum();
            break;
          }
          case 994: {
            DeliveryError = input.ReadString();
            break;
          }
          case 1018: {
            if (deliveryDttm_ == null) {
              DeliveryDttm = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DeliveryDttm);
            break;
          }
          case 1042: {
            ModifiedBy = input.ReadString();
            break;
          }
          case 1064: {
            ModifiedIn = (global::Spiderrock.Protobuf.SysEnvironment) input.ReadEnum();
            break;
          }
          case 1090: {
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
    /// <summary>Container for nested types declared in the UserMessage message type.</summary>
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
          get { return global::Spiderrock.Protobuf.UserMessage.Descriptor.NestedTypes[0]; }
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
          messageNumber_ = other.messageNumber_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey Clone() {
          return new PKey(this);
        }

        /// <summary>Field number for the "message_number" field.</summary>
        public const int MessageNumberFieldNumber = 10;
        private long messageNumber_;
        /// <summary>
        /// SR Message Number (SR Guid)
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long MessageNumber {
          get { return messageNumber_; }
          set {
            messageNumber_ = value;
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
          if (MessageNumber != other.MessageNumber) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (MessageNumber != 0L) hash ^= MessageNumber.GetHashCode();
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
          if (MessageNumber != 0L) {
            output.WriteRawTag(80);
            output.WriteInt64(MessageNumber);
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
          if (MessageNumber != 0L) {
            output.WriteRawTag(80);
            output.WriteInt64(MessageNumber);
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
          if (MessageNumber != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(MessageNumber);
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
          if (other.MessageNumber != 0L) {
            MessageNumber = other.MessageNumber;
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
              case 80: {
                MessageNumber = input.ReadInt64();
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
              case 80: {
                MessageNumber = input.ReadInt64();
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
