// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/MLinkWs/MLinkStream.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/MLinkWs/MLinkStream.proto</summary>
  public static partial class MLinkStreamReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/MLinkWs/MLinkStream.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MLinkStreamReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQcm90b2J1Zi9NTGlua1dzL01MaW5rU3RyZWFtLnByb3RvEhNzcGlkZXJy",
            "b2NrLnByb3RvYnVmGhdzcGlkZXJyb2NrX2NvbW1vbi5wcm90byLcAwoLTUxp",
            "bmtTdHJlYW0SMwoFX21ldGEYASABKAsyJC5zcGlkZXJyb2NrLnByb3RvYnVm",
            "Lk1lc3NhZ2VNZXRhZGF0YRIQCghtc2dfbmFtZRhkIAEoCRINCgV3aGVyZRhn",
            "IAEoCRIMCgR2aWV3GGogASgJEi8KC3Vuc3Vic2NyaWJlGG0gASgOMhouc3Bp",
            "ZGVycm9jay5wcm90b2J1Zi5ZZXNObxISCgpzZXNzaW9uX2lEGHAgASgFEhAK",
            "CHF1ZXJ5X2lEGHMgASgDEhMKC3F1ZXJ5X2xhYmVsGHYgASgJEhYKDmFjdGl2",
            "ZV9sYXRlbmN5GHkgASgFEjwKD3N5c19lbnZpcm9ubWVudBh8IAEoDjIjLnNw",
            "aWRlcnJvY2sucHJvdG9idWYuU3lzRW52aXJvbm1lbnQSMAoJc3lzX3JlYWxt",
            "GH8gASgOMh0uc3BpZGVycm9jay5wcm90b2J1Zi5TeXNSZWFsbRIVCgxoaWdo",
            "d2F0ZXJfdHMYggEgASgDEhYKDXN0cmlwZV9maWx0ZXIYhQEgASgJEhQKC3Nj",
            "aGVtYV9oYXNoGIgBIAEoAxIXCg5sb2NhbF9tc2dfdHlwZRiLASABKA0SFwoO",
            "bG9jYWxfbXNnX25hbWUYjgEgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.MLinkStream), global::Spiderrock.Protobuf.MLinkStream.Parser, new[]{ "Meta", "MsgName", "Where", "View", "Unsubscribe", "SessionID", "QueryID", "QueryLabel", "ActiveLatency", "SysEnvironment", "SysRealm", "HighwaterTs", "StripeFilter", "SchemaHash", "LocalMsgType", "LocalMsgName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MLinkStream : pb::IMessage<MLinkStream>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MLinkStream> _parser = new pb::MessageParser<MLinkStream>(() => new MLinkStream());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MLinkStream> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.MLinkStreamReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MLinkStream() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MLinkStream(MLinkStream other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      msgName_ = other.msgName_;
      where_ = other.where_;
      view_ = other.view_;
      unsubscribe_ = other.unsubscribe_;
      sessionID_ = other.sessionID_;
      queryID_ = other.queryID_;
      queryLabel_ = other.queryLabel_;
      activeLatency_ = other.activeLatency_;
      sysEnvironment_ = other.sysEnvironment_;
      sysRealm_ = other.sysRealm_;
      highwaterTs_ = other.highwaterTs_;
      stripeFilter_ = other.stripeFilter_;
      schemaHash_ = other.schemaHash_;
      localMsgType_ = other.localMsgType_;
      localMsgName_ = other.localMsgName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MLinkStream Clone() {
      return new MLinkStream(this);
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

    /// <summary>Field number for the "msg_name" field.</summary>
    public const int MsgNameFieldNumber = 100;
    private string msgName_ = "";
    /// <summary>
    /// (required) a SpiderRock message name (topic channel) (can be string name or protobuf message number)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MsgName {
      get { return msgName_; }
      set {
        msgName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "where" field.</summary>
    public const int WhereFieldNumber = 103;
    private string where_ = "";
    /// <summary>
    /// (optional) where clause; eg. "(bidexch:eq:AMEX | bidexch:eq:CBOE) &amp; bidsize:ge:100"  (default is all records)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Where {
      get { return where_; }
      set {
        where_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "view" field.</summary>
    public const int ViewFieldNumber = 106;
    private string view_ = "";
    /// <summary>
    /// (optional) list (subset) of field names to return with this message (eg. bidprice,askprice,bidsize,asksize) (default is all names)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string View {
      get { return view_; }
      set {
        view_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unsubscribe" field.</summary>
    public const int UnsubscribeFieldNumber = 109;
    private global::Spiderrock.Protobuf.YesNo unsubscribe_ = global::Spiderrock.Protobuf.YesNo.Unspecified;
    /// <summary>
    /// (optional) if set to Yes the specified message type will be unsubscribed and thus no longer return
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.YesNo Unsubscribe {
      get { return unsubscribe_; }
      set {
        unsubscribe_ = value;
      }
    }

    /// <summary>Field number for the "session_iD" field.</summary>
    public const int SessionIDFieldNumber = 112;
    private int sessionID_;
    /// <summary>
    /// (optional) actions below apply only to the sessionID virtual session; should be zero for non-multiplexed web-socket connections.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SessionID {
      get { return sessionID_; }
      set {
        sessionID_ = value;
      }
    }

    /// <summary>Field number for the "query_iD" field.</summary>
    public const int QueryIDFieldNumber = 115;
    private long queryID_;
    /// <summary>
    /// (optional) queryID will be reflected back in the corresponding MLinkStreamAck message; nothing is assumed about structure of this number
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long QueryID {
      get { return queryID_; }
      set {
        queryID_ = value;
      }
    }

    /// <summary>Field number for the "query_label" field.</summary>
    public const int QueryLabelFieldNumber = 118;
    private string queryLabel_ = "";
    /// <summary>
    /// (optional) query label; used for logging and query tracking
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string QueryLabel {
      get { return queryLabel_; }
      set {
        queryLabel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "active_latency" field.</summary>
    public const int ActiveLatencyFieldNumber = 121;
    private int activeLatency_;
    /// <summary>
    /// (optional) number of milliseconds between active send attempts (1 = minimum delay, 0 = wait for SignalReady) [default = 0]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ActiveLatency {
      get { return activeLatency_; }
      set {
        activeLatency_ = value;
      }
    }

    /// <summary>Field number for the "sys_environment" field.</summary>
    public const int SysEnvironmentFieldNumber = 124;
    private global::Spiderrock.Protobuf.SysEnvironment sysEnvironment_ = global::Spiderrock.Protobuf.SysEnvironment.Unspecified;
    /// <summary>
    /// (optional) records cannot have [sysEnvironment + sysRealm] in their route history (no loops)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.SysEnvironment SysEnvironment {
      get { return sysEnvironment_; }
      set {
        sysEnvironment_ = value;
      }
    }

    /// <summary>Field number for the "sys_realm" field.</summary>
    public const int SysRealmFieldNumber = 127;
    private global::Spiderrock.Protobuf.SysRealm sysRealm_ = global::Spiderrock.Protobuf.SysRealm.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.SysRealm SysRealm {
      get { return sysRealm_; }
      set {
        sysRealm_ = value;
      }
    }

    /// <summary>Field number for the "highwater_ts" field.</summary>
    public const int HighwaterTsFieldNumber = 130;
    private long highwaterTs_;
    /// <summary>
    /// (optional) records must have a header.sentTs that is later than this value (nanoseconds after the UNIX epoch) [-1 means start from current server side highwaterTs]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long HighwaterTs {
      get { return highwaterTs_; }
      set {
        highwaterTs_ = value;
      }
    }

    /// <summary>Field number for the "stripe_filter" field.</summary>
    public const int StripeFilterFieldNumber = 133;
    private string stripeFilter_ = "";
    /// <summary>
    /// (optional) if supplied records must be within the specified stripe
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StripeFilter {
      get { return stripeFilter_; }
      set {
        stripeFilter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "schema_hash" field.</summary>
    public const int SchemaHashFieldNumber = 136;
    private long schemaHash_;
    /// <summary>
    /// (optional) message schema hash [if supplied and matches server schema hash for this message binary encoding will be used]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long SchemaHash {
      get { return schemaHash_; }
      set {
        schemaHash_ = value;
      }
    }

    /// <summary>Field number for the "local_msg_type" field.</summary>
    public const int LocalMsgTypeFieldNumber = 139;
    private uint localMsgType_;
    /// <summary>
    /// (optional) if != 0 the msgType number will be translated from msgType to localMsgType in the mlink server (protobuf and binary messages)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LocalMsgType {
      get { return localMsgType_; }
      set {
        localMsgType_ = value;
      }
    }

    /// <summary>Field number for the "local_msg_name" field.</summary>
    public const int LocalMsgNameFieldNumber = 142;
    private string localMsgName_ = "";
    /// <summary>
    /// (optional) if exists the message name will be translated from msgName to localMsgName in the mlink server (json messages)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LocalMsgName {
      get { return localMsgName_; }
      set {
        localMsgName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MLinkStream);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MLinkStream other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (MsgName != other.MsgName) return false;
      if (Where != other.Where) return false;
      if (View != other.View) return false;
      if (Unsubscribe != other.Unsubscribe) return false;
      if (SessionID != other.SessionID) return false;
      if (QueryID != other.QueryID) return false;
      if (QueryLabel != other.QueryLabel) return false;
      if (ActiveLatency != other.ActiveLatency) return false;
      if (SysEnvironment != other.SysEnvironment) return false;
      if (SysRealm != other.SysRealm) return false;
      if (HighwaterTs != other.HighwaterTs) return false;
      if (StripeFilter != other.StripeFilter) return false;
      if (SchemaHash != other.SchemaHash) return false;
      if (LocalMsgType != other.LocalMsgType) return false;
      if (LocalMsgName != other.LocalMsgName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (MsgName.Length != 0) hash ^= MsgName.GetHashCode();
      if (Where.Length != 0) hash ^= Where.GetHashCode();
      if (View.Length != 0) hash ^= View.GetHashCode();
      if (Unsubscribe != global::Spiderrock.Protobuf.YesNo.Unspecified) hash ^= Unsubscribe.GetHashCode();
      if (SessionID != 0) hash ^= SessionID.GetHashCode();
      if (QueryID != 0L) hash ^= QueryID.GetHashCode();
      if (QueryLabel.Length != 0) hash ^= QueryLabel.GetHashCode();
      if (ActiveLatency != 0) hash ^= ActiveLatency.GetHashCode();
      if (SysEnvironment != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) hash ^= SysEnvironment.GetHashCode();
      if (SysRealm != global::Spiderrock.Protobuf.SysRealm.Unspecified) hash ^= SysRealm.GetHashCode();
      if (HighwaterTs != 0L) hash ^= HighwaterTs.GetHashCode();
      if (StripeFilter.Length != 0) hash ^= StripeFilter.GetHashCode();
      if (SchemaHash != 0L) hash ^= SchemaHash.GetHashCode();
      if (LocalMsgType != 0) hash ^= LocalMsgType.GetHashCode();
      if (LocalMsgName.Length != 0) hash ^= LocalMsgName.GetHashCode();
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
      if (MsgName.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(MsgName);
      }
      if (Where.Length != 0) {
        output.WriteRawTag(186, 6);
        output.WriteString(Where);
      }
      if (View.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(View);
      }
      if (Unsubscribe != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        output.WriteRawTag(232, 6);
        output.WriteEnum((int) Unsubscribe);
      }
      if (SessionID != 0) {
        output.WriteRawTag(128, 7);
        output.WriteInt32(SessionID);
      }
      if (QueryID != 0L) {
        output.WriteRawTag(152, 7);
        output.WriteInt64(QueryID);
      }
      if (QueryLabel.Length != 0) {
        output.WriteRawTag(178, 7);
        output.WriteString(QueryLabel);
      }
      if (ActiveLatency != 0) {
        output.WriteRawTag(200, 7);
        output.WriteInt32(ActiveLatency);
      }
      if (SysEnvironment != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        output.WriteRawTag(224, 7);
        output.WriteEnum((int) SysEnvironment);
      }
      if (SysRealm != global::Spiderrock.Protobuf.SysRealm.Unspecified) {
        output.WriteRawTag(248, 7);
        output.WriteEnum((int) SysRealm);
      }
      if (HighwaterTs != 0L) {
        output.WriteRawTag(144, 8);
        output.WriteInt64(HighwaterTs);
      }
      if (StripeFilter.Length != 0) {
        output.WriteRawTag(170, 8);
        output.WriteString(StripeFilter);
      }
      if (SchemaHash != 0L) {
        output.WriteRawTag(192, 8);
        output.WriteInt64(SchemaHash);
      }
      if (LocalMsgType != 0) {
        output.WriteRawTag(216, 8);
        output.WriteUInt32(LocalMsgType);
      }
      if (LocalMsgName.Length != 0) {
        output.WriteRawTag(242, 8);
        output.WriteString(LocalMsgName);
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
      if (MsgName.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(MsgName);
      }
      if (Where.Length != 0) {
        output.WriteRawTag(186, 6);
        output.WriteString(Where);
      }
      if (View.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(View);
      }
      if (Unsubscribe != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        output.WriteRawTag(232, 6);
        output.WriteEnum((int) Unsubscribe);
      }
      if (SessionID != 0) {
        output.WriteRawTag(128, 7);
        output.WriteInt32(SessionID);
      }
      if (QueryID != 0L) {
        output.WriteRawTag(152, 7);
        output.WriteInt64(QueryID);
      }
      if (QueryLabel.Length != 0) {
        output.WriteRawTag(178, 7);
        output.WriteString(QueryLabel);
      }
      if (ActiveLatency != 0) {
        output.WriteRawTag(200, 7);
        output.WriteInt32(ActiveLatency);
      }
      if (SysEnvironment != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        output.WriteRawTag(224, 7);
        output.WriteEnum((int) SysEnvironment);
      }
      if (SysRealm != global::Spiderrock.Protobuf.SysRealm.Unspecified) {
        output.WriteRawTag(248, 7);
        output.WriteEnum((int) SysRealm);
      }
      if (HighwaterTs != 0L) {
        output.WriteRawTag(144, 8);
        output.WriteInt64(HighwaterTs);
      }
      if (StripeFilter.Length != 0) {
        output.WriteRawTag(170, 8);
        output.WriteString(StripeFilter);
      }
      if (SchemaHash != 0L) {
        output.WriteRawTag(192, 8);
        output.WriteInt64(SchemaHash);
      }
      if (LocalMsgType != 0) {
        output.WriteRawTag(216, 8);
        output.WriteUInt32(LocalMsgType);
      }
      if (LocalMsgName.Length != 0) {
        output.WriteRawTag(242, 8);
        output.WriteString(LocalMsgName);
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
      if (MsgName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(MsgName);
      }
      if (Where.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Where);
      }
      if (View.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(View);
      }
      if (Unsubscribe != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) Unsubscribe);
      }
      if (SessionID != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(SessionID);
      }
      if (QueryID != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(QueryID);
      }
      if (QueryLabel.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(QueryLabel);
      }
      if (ActiveLatency != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(ActiveLatency);
      }
      if (SysEnvironment != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) SysEnvironment);
      }
      if (SysRealm != global::Spiderrock.Protobuf.SysRealm.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) SysRealm);
      }
      if (HighwaterTs != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(HighwaterTs);
      }
      if (StripeFilter.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(StripeFilter);
      }
      if (SchemaHash != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(SchemaHash);
      }
      if (LocalMsgType != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(LocalMsgType);
      }
      if (LocalMsgName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(LocalMsgName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MLinkStream other) {
      if (other == null) {
        return;
      }
      if (other.Meta_ != null) {
        if (Meta_ == null) {
          Meta = new global::Spiderrock.Protobuf.MessageMetadata();
        }
        Meta.MergeFrom(other.Meta);
      }
      if (other.MsgName.Length != 0) {
        MsgName = other.MsgName;
      }
      if (other.Where.Length != 0) {
        Where = other.Where;
      }
      if (other.View.Length != 0) {
        View = other.View;
      }
      if (other.Unsubscribe != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        Unsubscribe = other.Unsubscribe;
      }
      if (other.SessionID != 0) {
        SessionID = other.SessionID;
      }
      if (other.QueryID != 0L) {
        QueryID = other.QueryID;
      }
      if (other.QueryLabel.Length != 0) {
        QueryLabel = other.QueryLabel;
      }
      if (other.ActiveLatency != 0) {
        ActiveLatency = other.ActiveLatency;
      }
      if (other.SysEnvironment != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        SysEnvironment = other.SysEnvironment;
      }
      if (other.SysRealm != global::Spiderrock.Protobuf.SysRealm.Unspecified) {
        SysRealm = other.SysRealm;
      }
      if (other.HighwaterTs != 0L) {
        HighwaterTs = other.HighwaterTs;
      }
      if (other.StripeFilter.Length != 0) {
        StripeFilter = other.StripeFilter;
      }
      if (other.SchemaHash != 0L) {
        SchemaHash = other.SchemaHash;
      }
      if (other.LocalMsgType != 0) {
        LocalMsgType = other.LocalMsgType;
      }
      if (other.LocalMsgName.Length != 0) {
        LocalMsgName = other.LocalMsgName;
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
          case 802: {
            MsgName = input.ReadString();
            break;
          }
          case 826: {
            Where = input.ReadString();
            break;
          }
          case 850: {
            View = input.ReadString();
            break;
          }
          case 872: {
            Unsubscribe = (global::Spiderrock.Protobuf.YesNo) input.ReadEnum();
            break;
          }
          case 896: {
            SessionID = input.ReadInt32();
            break;
          }
          case 920: {
            QueryID = input.ReadInt64();
            break;
          }
          case 946: {
            QueryLabel = input.ReadString();
            break;
          }
          case 968: {
            ActiveLatency = input.ReadInt32();
            break;
          }
          case 992: {
            SysEnvironment = (global::Spiderrock.Protobuf.SysEnvironment) input.ReadEnum();
            break;
          }
          case 1016: {
            SysRealm = (global::Spiderrock.Protobuf.SysRealm) input.ReadEnum();
            break;
          }
          case 1040: {
            HighwaterTs = input.ReadInt64();
            break;
          }
          case 1066: {
            StripeFilter = input.ReadString();
            break;
          }
          case 1088: {
            SchemaHash = input.ReadInt64();
            break;
          }
          case 1112: {
            LocalMsgType = input.ReadUInt32();
            break;
          }
          case 1138: {
            LocalMsgName = input.ReadString();
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
          case 802: {
            MsgName = input.ReadString();
            break;
          }
          case 826: {
            Where = input.ReadString();
            break;
          }
          case 850: {
            View = input.ReadString();
            break;
          }
          case 872: {
            Unsubscribe = (global::Spiderrock.Protobuf.YesNo) input.ReadEnum();
            break;
          }
          case 896: {
            SessionID = input.ReadInt32();
            break;
          }
          case 920: {
            QueryID = input.ReadInt64();
            break;
          }
          case 946: {
            QueryLabel = input.ReadString();
            break;
          }
          case 968: {
            ActiveLatency = input.ReadInt32();
            break;
          }
          case 992: {
            SysEnvironment = (global::Spiderrock.Protobuf.SysEnvironment) input.ReadEnum();
            break;
          }
          case 1016: {
            SysRealm = (global::Spiderrock.Protobuf.SysRealm) input.ReadEnum();
            break;
          }
          case 1040: {
            HighwaterTs = input.ReadInt64();
            break;
          }
          case 1066: {
            StripeFilter = input.ReadString();
            break;
          }
          case 1088: {
            SchemaHash = input.ReadInt64();
            break;
          }
          case 1112: {
            LocalMsgType = input.ReadUInt32();
            break;
          }
          case 1138: {
            LocalMsgName = input.ReadString();
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
