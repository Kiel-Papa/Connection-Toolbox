# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientTrading/SpdrRiskGroupCancel.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\'ClientTrading/SpdrRiskGroupCancel.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xca\x03\n\x13SpdrRiskGroupCancel\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12;\n\x04pkey\x18\x02 \x01(\x0b\x32-.spiderrock.protobuf.SpdrRiskGroupCancel.PKey\x12<\n\x0fsys_environment\x18\x64 \x01(\x0e\x32#.spiderrock.protobuf.SysEnvironment\x12\x32\n\nrun_status\x18g \x01(\x0e\x32\x1e.spiderrock.protobuf.RunStatus\x12\x34\n\x0bspdr_source\x18j \x01(\x0e\x32\x1f.spiderrock.protobuf.SpdrSource\x12\x12\n\ncxl_reason\x18m \x01(\t\x12\x15\n\ralt_cancel_id\x18p \x01(\t\x12\x11\n\tuser_name\x18s \x01(\t\x12-\n\ttimestamp\x18v \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a,\n\x04PKey\x12\x15\n\rrisk_group_id\x18\n \x01(\x03\x12\r\n\x05\x61\x63\x63nt\x18\x0b \x01(\tb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientTrading.SpdrRiskGroupCancel_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_SPDRRISKGROUPCANCEL']._serialized_start=123
  _globals['_SPDRRISKGROUPCANCEL']._serialized_end=581
  _globals['_SPDRRISKGROUPCANCEL_PKEY']._serialized_start=537
  _globals['_SPDRRISKGROUPCANCEL_PKEY']._serialized_end=581
# @@protoc_insertion_point(module_scope)
