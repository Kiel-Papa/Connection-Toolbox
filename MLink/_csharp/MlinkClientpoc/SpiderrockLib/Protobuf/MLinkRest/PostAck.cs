// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/MLinkRest/PostAck.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/MLinkRest/PostAck.proto</summary>
  public static partial class PostAckReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/MLinkRest/PostAck.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PostAckReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQcm90b2J1Zi9NTGlua1Jlc3QvUG9zdEFjay5wcm90bxITc3BpZGVycm9j",
            "ay5wcm90b2J1ZhoXc3BpZGVycm9ja19jb21tb24ucHJvdG8iswEKB1Bvc3RB",
            "Y2sSMwoFX21ldGEYASABKAsyJC5zcGlkZXJyb2NrLnByb3RvYnVmLk1lc3Nh",
            "Z2VNZXRhZGF0YRIQCghtc2dfdHlwZRhkIAEoDRIPCgdzZW5kX3RzGGcgASgD",
            "EgwKBHBrZXkYaiABKAkSMgoGcmVzdWx0GG0gASgOMiIuc3BpZGVycm9jay5w",
            "cm90b2J1Zi5Qb3N0QWNrUmVzdWx0Eg4KBmRldGFpbBhwIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.PostAck), global::Spiderrock.Protobuf.PostAck.Parser, new[]{ "Meta", "MsgType", "SendTs", "Pkey", "Result", "Detail" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PostAck : pb::IMessage<PostAck>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PostAck> _parser = new pb::MessageParser<PostAck>(() => new PostAck());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PostAck> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.PostAckReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PostAck() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PostAck(PostAck other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      msgType_ = other.msgType_;
      sendTs_ = other.sendTs_;
      pkey_ = other.pkey_;
      result_ = other.result_;
      detail_ = other.detail_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PostAck Clone() {
      return new PostAck(this);
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

    /// <summary>Field number for the "msg_type" field.</summary>
    public const int MsgTypeFieldNumber = 100;
    private uint msgType_;
    /// <summary>
    /// message type of the data object being ack'd
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MsgType {
      get { return msgType_; }
      set {
        msgType_ = value;
      }
    }

    /// <summary>Field number for the "send_ts" field.</summary>
    public const int SendTsFieldNumber = 103;
    private long sendTs_;
    /// <summary>
    /// send timestamp of the data object being ack'd (note: MessageType + SendTimestamp should be unique)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long SendTs {
      get { return sendTs_; }
      set {
        sendTs_ = value;
      }
    }

    /// <summary>Field number for the "pkey" field.</summary>
    public const int PkeyFieldNumber = 106;
    private string pkey_ = "";
    /// <summary>
    /// pkey (string) of the message being ack'd
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Pkey {
      get { return pkey_; }
      set {
        pkey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 109;
    private global::Spiderrock.Protobuf.PostAckResult result_ = global::Spiderrock.Protobuf.PostAckResult.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.PostAckResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "detail" field.</summary>
    public const int DetailFieldNumber = 112;
    private string detail_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Detail {
      get { return detail_; }
      set {
        detail_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PostAck);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PostAck other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (MsgType != other.MsgType) return false;
      if (SendTs != other.SendTs) return false;
      if (Pkey != other.Pkey) return false;
      if (Result != other.Result) return false;
      if (Detail != other.Detail) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (MsgType != 0) hash ^= MsgType.GetHashCode();
      if (SendTs != 0L) hash ^= SendTs.GetHashCode();
      if (Pkey.Length != 0) hash ^= Pkey.GetHashCode();
      if (Result != global::Spiderrock.Protobuf.PostAckResult.Unspecified) hash ^= Result.GetHashCode();
      if (Detail.Length != 0) hash ^= Detail.GetHashCode();
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
      if (MsgType != 0) {
        output.WriteRawTag(160, 6);
        output.WriteUInt32(MsgType);
      }
      if (SendTs != 0L) {
        output.WriteRawTag(184, 6);
        output.WriteInt64(SendTs);
      }
      if (Pkey.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(Pkey);
      }
      if (Result != global::Spiderrock.Protobuf.PostAckResult.Unspecified) {
        output.WriteRawTag(232, 6);
        output.WriteEnum((int) Result);
      }
      if (Detail.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(Detail);
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
      if (MsgType != 0) {
        output.WriteRawTag(160, 6);
        output.WriteUInt32(MsgType);
      }
      if (SendTs != 0L) {
        output.WriteRawTag(184, 6);
        output.WriteInt64(SendTs);
      }
      if (Pkey.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(Pkey);
      }
      if (Result != global::Spiderrock.Protobuf.PostAckResult.Unspecified) {
        output.WriteRawTag(232, 6);
        output.WriteEnum((int) Result);
      }
      if (Detail.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(Detail);
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
      if (MsgType != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(MsgType);
      }
      if (SendTs != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(SendTs);
      }
      if (Pkey.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Pkey);
      }
      if (Result != global::Spiderrock.Protobuf.PostAckResult.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (Detail.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Detail);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PostAck other) {
      if (other == null) {
        return;
      }
      if (other.Meta_ != null) {
        if (Meta_ == null) {
          Meta = new global::Spiderrock.Protobuf.MessageMetadata();
        }
        Meta.MergeFrom(other.Meta);
      }
      if (other.MsgType != 0) {
        MsgType = other.MsgType;
      }
      if (other.SendTs != 0L) {
        SendTs = other.SendTs;
      }
      if (other.Pkey.Length != 0) {
        Pkey = other.Pkey;
      }
      if (other.Result != global::Spiderrock.Protobuf.PostAckResult.Unspecified) {
        Result = other.Result;
      }
      if (other.Detail.Length != 0) {
        Detail = other.Detail;
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
          case 800: {
            MsgType = input.ReadUInt32();
            break;
          }
          case 824: {
            SendTs = input.ReadInt64();
            break;
          }
          case 850: {
            Pkey = input.ReadString();
            break;
          }
          case 872: {
            Result = (global::Spiderrock.Protobuf.PostAckResult) input.ReadEnum();
            break;
          }
          case 898: {
            Detail = input.ReadString();
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
          case 800: {
            MsgType = input.ReadUInt32();
            break;
          }
          case 824: {
            SendTs = input.ReadInt64();
            break;
          }
          case 850: {
            Pkey = input.ReadString();
            break;
          }
          case 872: {
            Result = (global::Spiderrock.Protobuf.PostAckResult) input.ReadEnum();
            break;
          }
          case 898: {
            Detail = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
