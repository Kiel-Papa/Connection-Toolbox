# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: OptMarkData/OptionOpenMark.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n OptMarkData/OptionOpenMark.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\x85\x06\n\x0eOptionOpenMark\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x36\n\x04pkey\x18\x02 \x01(\x0b\x32(.spiderrock.protobuf.OptionOpenMark.PKey\x12\x30\n\ntrade_date\x18\x64 \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12\r\n\x05u_bid\x18g \x01(\x01\x12\r\n\x05u_ask\x18j \x01(\x01\x12\x10\n\x08u_sr_cls\x18m \x01(\x01\x12\x0f\n\x07u_close\x18p \x01(\x01\x12\x0f\n\x07\x62id_prc\x18s \x01(\x02\x12\x0f\n\x07\x61sk_prc\x18v \x01(\x02\x12\x12\n\nsr_cls_prc\x18y \x01(\x01\x12\x11\n\tclose_prc\x18| \x01(\x01\x12\x0e\n\x06\x62id_iV\x18\x7f \x01(\x02\x12\x0f\n\x06\x61sk_iV\x18\x82\x01 \x01(\x02\x12\x0f\n\x06sr_prc\x18\x85\x01 \x01(\x02\x12\x0f\n\x06sr_vol\x18\x88\x01 \x01(\x02\x12\x30\n\x06sr_src\x18\x8b\x01 \x01(\x0e\x32\x1f.spiderrock.protobuf.MarkSource\x12\x0b\n\x02\x64\x65\x18\x8e\x01 \x01(\x02\x12\x0b\n\x02ga\x18\x91\x01 \x01(\x02\x12\x0b\n\x02th\x18\x94\x01 \x01(\x02\x12\x0b\n\x02ve\x18\x97\x01 \x01(\x02\x12\x0b\n\x02vo\x18\x9a\x01 \x01(\x02\x12\x0b\n\x02va\x18\x9d\x01 \x01(\x02\x12\x0b\n\x02rh\x18\xa0\x01 \x01(\x02\x12\x0b\n\x02ph\x18\xa3\x01 \x01(\x02\x12\x11\n\x08sr_slope\x18\xa6\x01 \x01(\x02\x12\x11\n\x08\x64\x65_decay\x18\xa9\x01 \x01(\x02\x12\r\n\x04sdiv\x18\xac\x01 \x01(\x02\x12\r\n\x04\x64\x64iv\x18\xaf\x01 \x01(\x02\x12\r\n\x04rate\x18\xb2\x01 \x01(\x02\x12\x0e\n\x05years\x18\xb5\x01 \x01(\x02\x12\x0e\n\x05\x65rror\x18\xb8\x01 \x01(\x05\x12\x14\n\x0b\x63orp_action\x18\xbb\x01 \x01(\t\x12.\n\ttimestamp\x18\xbe\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\x34\n\x04PKey\x12,\n\x04okey\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKeyb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'OptMarkData.OptionOpenMark_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_OPTIONOPENMARK']._serialized_start=116
  _globals['_OPTIONOPENMARK']._serialized_end=889
  _globals['_OPTIONOPENMARK_PKEY']._serialized_start=837
  _globals['_OPTIONOPENMARK_PKEY']._serialized_end=889
# @@protoc_insertion_point(module_scope)
