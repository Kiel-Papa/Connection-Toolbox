# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: OptSurface/LiveSurfaceFixedGrid.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n%OptSurface/LiveSurfaceFixedGrid.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xf3\x06\n\x14LiveSurfaceFixedGrid\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12<\n\x04pkey\x18\x02 \x01(\x0b\x32..spiderrock.protobuf.LiveSurfaceFixedGrid.PKey\x12\x0c\n\x04\x64\x61te\x18\x64 \x01(\t\x12\x0c\n\x04time\x18g \x01(\t\x12\r\n\x05s_div\x18j \x01(\x02\x12\x10\n\x08\x66wd_uPrc\x18m \x01(\x02\x12\r\n\x05\x65_cnt\x18p \x01(\x05\x12\x0e\n\x06\x65_move\x18s \x01(\x02\x12\x13\n\x0b\x65_move_hist\x18v \x01(\x02\x12\x0f\n\x07vol_d45\x18y \x01(\x02\x12\x0f\n\x07vol_d40\x18| \x01(\x02\x12\x0f\n\x07vol_d35\x18\x7f \x01(\x02\x12\x10\n\x07vol_d30\x18\x82\x01 \x01(\x02\x12\x10\n\x07vol_d25\x18\x85\x01 \x01(\x02\x12\x10\n\x07vol_d20\x18\x88\x01 \x01(\x02\x12\x10\n\x07vol_d15\x18\x8b\x01 \x01(\x02\x12\x10\n\x07vol_d10\x18\x8e\x01 \x01(\x02\x12\x10\n\x07vol_d05\x18\x91\x01 \x01(\x02\x12\x10\n\x07vol_a00\x18\x94\x01 \x01(\x02\x12\x10\n\x07vol_u05\x18\x97\x01 \x01(\x02\x12\x10\n\x07vol_u10\x18\x9a\x01 \x01(\x02\x12\x10\n\x07vol_u15\x18\x9d\x01 \x01(\x02\x12\x10\n\x07vol_u20\x18\xa0\x01 \x01(\x02\x12\x10\n\x07vol_u25\x18\xa3\x01 \x01(\x02\x12\x10\n\x07vol_u30\x18\xa6\x01 \x01(\x02\x12\x10\n\x07vol_u35\x18\xa9\x01 \x01(\x02\x12\x10\n\x07vol_u40\x18\xac\x01 \x01(\x02\x12\x10\n\x07vol_u45\x18\xaf\x01 \x01(\x02\x12\x10\n\x07v_width\x18\xb2\x01 \x01(\x02\x12\x10\n\x07v_slope\x18\xb5\x01 \x01(\x02\x12\x11\n\x08lo_years\x18\xb8\x01 \x01(\x02\x12\x11\n\x08hi_years\x18\xbb\x01 \x01(\x02\x12\x12\n\tmin_delta\x18\xbe\x01 \x01(\x02\x12\x12\n\tmax_delta\x18\xc1\x01 \x01(\x02\x12.\n\ttimestamp\x18\xc4\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\x81\x01\n\x04PKey\x12.\n\x06ticker\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\x0c\n\x04\x64\x61ys\x18\x0b \x01(\x05\x12;\n\x0csurface_type\x18\x0c \x01(\x0e\x32%.spiderrock.protobuf.SurfaceCurveTypeb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'OptSurface.LiveSurfaceFixedGrid_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_LIVESURFACEFIXEDGRID']._serialized_start=121
  _globals['_LIVESURFACEFIXEDGRID']._serialized_end=1004
  _globals['_LIVESURFACEFIXEDGRID_PKEY']._serialized_start=875
  _globals['_LIVESURFACEFIXEDGRID_PKEY']._serialized_end=1004
# @@protoc_insertion_point(module_scope)
