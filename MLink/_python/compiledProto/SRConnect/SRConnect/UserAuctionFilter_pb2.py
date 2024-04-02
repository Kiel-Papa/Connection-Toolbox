# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: SRConnect/UserAuctionFilter.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n!SRConnect/UserAuctionFilter.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\x9a\x14\n\x11UserAuctionFilter\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x39\n\x04pkey\x18\x02 \x01(\x0b\x32+.spiderrock.protobuf.UserAuctionFilter.PKey\x12\x13\n\x0b\x63lient_firm\x18\x64 \x01(\t\x12+\n\x07\x65nabled\x18\x65 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x33\n\x0finclude_covered\x18r \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x30\n\x0cinclude_eTFs\x18s \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x30\n\x0cinclude_aDRs\x18t \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x33\n\x0finclude_indexes\x18u \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x10\n\x08min_uPrc\x18v \x01(\x02\x12=\n\x19has_uAvg_daily_vlm_filter\x18w \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x1a\n\x12min_uAvg_daily_vlm\x18x \x01(\x02\x12\x1a\n\x12max_uAvg_daily_vlm\x18y \x01(\x02\x12\x10\n\x08min_size\x18z \x01(\x02\x12\x10\n\x08min_vega\x18{ \x01(\x02\x12\x38\n\x14has_abs_delta_filter\x18| \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x15\n\rmin_abs_delta\x18} \x01(\x02\x12\x15\n\rmax_abs_delta\x18~ \x01(\x02\x12\x35\n\x11has_xDelta_filter\x18\x7f \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x13\n\nmin_xDelta\x18\x80\x01 \x01(\x02\x12\x13\n\nmax_xDelta\x18\x81\x01 \x01(\x02\x12\x38\n\x13has_atm_sVol_filter\x18\x82\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x15\n\x0cmin_atm_sVol\x18\x83\x01 \x01(\x02\x12\x15\n\x0cmax_atm_sVol\x18\x84\x01 \x01(\x02\x12\x38\n\x13has_atm_sDiv_filter\x18\x85\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x15\n\x0cmin_atm_sDiv\x18\x86\x01 \x01(\x02\x12\x15\n\x0cmax_atm_sDiv\x18\x87\x01 \x01(\x02\x12\x34\n\x0fhas_expiry_days\x18\x88\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x18\n\x0fmin_expiry_days\x18\x89\x01 \x01(\x05\x12\x18\n\x0fmax_expiry_days\x18\x8a\x01 \x01(\x05\x12\x31\n\x0cinclude_zDte\x18\x8b\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x32\n\rinclude_daily\x18\x8c\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x33\n\x0einclude_weekly\x18\x8d\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x34\n\x0finclude_regular\x18\x8e\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x36\n\x11include_quarterly\x18\x8f\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x31\n\x0cinclude_flex\x18\x90\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x38\n\x13include_comm_paying\x18\x91\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x30\n\tdirection\x18\x92\x01 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x35\n\x0evega_direction\x18\x93\x01 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x14\n\x0bmodified_by\x18\x94\x01 \x01(\t\x12\x39\n\x0bmodified_in\x18\x95\x01 \x01(\x0e\x32#.spiderrock.protobuf.SysEnvironment\x12.\n\ttimestamp\x18\x96\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12N\n\x0f\x61uction_sources\x18p \x03(\x0b\x32\x35.spiderrock.protobuf.UserAuctionFilter.AuctionSources\x12J\n\rauction_types\x18n \x03(\x0b\x32\x33.spiderrock.protobuf.UserAuctionFilter.AuctionTypes\x12L\n\x0e\x65xclude_ticker\x18j \x03(\x0b\x32\x34.spiderrock.protobuf.UserAuctionFilter.ExcludeTicker\x12L\n\x0einclude_ticker\x18h \x03(\x0b\x32\x34.spiderrock.protobuf.UserAuctionFilter.IncludeTicker\x12\x41\n\x08industry\x18\x66 \x03(\x0b\x32/.spiderrock.protobuf.UserAuctionFilter.Industry\x12H\n\x0cspread_class\x18l \x03(\x0b\x32\x32.spiderrock.protobuf.UserAuctionFilter.SpreadClass\x1a.\n\x04PKey\x12\x11\n\tuser_name\x18\n \x01(\t\x12\x13\n\x0b\x66ilter_name\x18\x0b \x01(\t\x1aL\n\x0e\x41uctionSources\x12:\n\x0e\x61uction_source\x18q \x01(\x0e\x32\".spiderrock.protobuf.AuctionSource\x1a\x46\n\x0c\x41uctionTypes\x12\x36\n\x0c\x61uction_type\x18o \x01(\x0e\x32 .spiderrock.protobuf.AuctionType\x1a?\n\rExcludeTicker\x12.\n\x06ticker\x18k \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x1a?\n\rIncludeTicker\x12.\n\x06ticker\x18i \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x1a\x1c\n\x08Industry\x12\x10\n\x08industry\x18g \x01(\t\x1aI\n\x0bSpreadClass\x12:\n\x0cspread_class\x18m \x01(\x0e\x32$.spiderrock.protobuf.ToolSpreadClassb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'SRConnect.UserAuctionFilter_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_USERAUCTIONFILTER']._serialized_start=117
  _globals['_USERAUCTIONFILTER']._serialized_end=2703
  _globals['_USERAUCTIONFILTER_PKEY']._serialized_start=2272
  _globals['_USERAUCTIONFILTER_PKEY']._serialized_end=2318
  _globals['_USERAUCTIONFILTER_AUCTIONSOURCES']._serialized_start=2320
  _globals['_USERAUCTIONFILTER_AUCTIONSOURCES']._serialized_end=2396
  _globals['_USERAUCTIONFILTER_AUCTIONTYPES']._serialized_start=2398
  _globals['_USERAUCTIONFILTER_AUCTIONTYPES']._serialized_end=2468
  _globals['_USERAUCTIONFILTER_EXCLUDETICKER']._serialized_start=2470
  _globals['_USERAUCTIONFILTER_EXCLUDETICKER']._serialized_end=2533
  _globals['_USERAUCTIONFILTER_INCLUDETICKER']._serialized_start=2535
  _globals['_USERAUCTIONFILTER_INCLUDETICKER']._serialized_end=2598
  _globals['_USERAUCTIONFILTER_INDUSTRY']._serialized_start=2600
  _globals['_USERAUCTIONFILTER_INDUSTRY']._serialized_end=2628
  _globals['_USERAUCTIONFILTER_SPREADCLASS']._serialized_start=2630
  _globals['_USERAUCTIONFILTER_SPREADCLASS']._serialized_end=2703
# @@protoc_insertion_point(module_scope)
