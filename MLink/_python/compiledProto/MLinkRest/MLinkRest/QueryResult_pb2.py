# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: MLinkRest/QueryResult.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\x1bMLinkRest/QueryResult.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\"\xe8\x01\n\x0bQueryResult\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x16\n\x0enum_bytes_sent\x18\x64 \x01(\x03\x12\x19\n\x11num_messages_sent\x18g \x01(\x03\x12\x1c\n\x14num_messages_scanned\x18j \x01(\x03\x12\x15\n\rquery_elapsed\x18m \x01(\x02\x12,\n\x06result\x18p \x01(\x0e\x32\x1c.spiderrock.protobuf.QResult\x12\x0e\n\x06\x64\x65tail\x18s \x01(\tb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'MLinkRest.QueryResult_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_QUERYRESULT']._serialized_start=78
  _globals['_QUERYRESULT']._serialized_end=310
# @@protoc_insertion_point(module_scope)
