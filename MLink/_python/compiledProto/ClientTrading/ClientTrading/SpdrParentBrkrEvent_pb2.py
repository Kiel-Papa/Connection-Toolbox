# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientTrading/SpdrParentBrkrEvent.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\'ClientTrading/SpdrParentBrkrEvent.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xb4\x19\n\x13SpdrParentBrkrEvent\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12;\n\x04pkey\x18\x02 \x01(\x0b\x32-.spiderrock.protobuf.SpdrParentBrkrEvent.PKey\x12/\n\x07sec_key\x18\x64 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x32\n\x08sec_type\x18g \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\r\n\x05\x61\x63\x63nt\x18j \x01(\t\x12\x34\n\x0bspdr_source\x18m \x01(\x0e\x32\x1f.spiderrock.protobuf.SpdrSource\x12\x15\n\rgrouping_code\x18p \x01(\x03\x12\x30\n\norder_side\x18s \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x13\n\x0b\x63lient_firm\x18v \x01(\t\x12\x11\n\talt_accnt\x18y \x01(\t\x12\x15\n\ralt_user_name\x18| \x01(\t\x12\x14\n\x0c\x65vent_number\x18\x7f \x01(\r\x12\x37\n\nstage_type\x18\x82\x01 \x01(\x0e\x32\".spiderrock.protobuf.SpdrStageType\x12\x1b\n\x12\x62\x61se_parent_number\x18\x85\x01 \x01(\x03\x12\x1b\n\x12prev_parent_number\x18\x88\x01 \x01(\x03\x12\x14\n\x0b\x65ngine_name\x18\x8b\x01 \x01(\t\x12/\n\x06ticker\x18\x8e\x01 \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\x42\n\x12spdr_broker_status\x18\x91\x01 \x01(\x0e\x32%.spiderrock.protobuf.SpdrBrokerStatus\x12@\n\x11spdr_order_status\x18\x94\x01 \x01(\x0e\x32$.spiderrock.protobuf.SpdrOrderStatus\x12@\n\x11spdr_close_reason\x18\x97\x01 \x01(\x0e\x32$.spiderrock.protobuf.SpdrCloseReason\x12\x42\n\x12spdr_reject_reason\x18\x9a\x01 \x01(\x0e\x32%.spiderrock.protobuf.SpdrRejectReason\x12\x15\n\x0cspdr_comment\x18\x9d\x01 \x01(\t\x12\x1e\n\x15mar_haircut_utilized1\x18\xa0\x01 \x01(\x02\x12\x1e\n\x15mar_haircut_utilized2\x18\xa3\x01 \x01(\x02\x12\x1e\n\x15mar_haircut_utilized3\x18\xa6\x01 \x01(\x02\x12%\n\x1cmar_total_exposure_utilized1\x18\xa9\x01 \x01(\x02\x12%\n\x1cmar_total_exposure_utilized2\x18\xac\x01 \x01(\x02\x12%\n\x1cmar_total_exposure_utilized3\x18\xaf\x01 \x01(\x02\x12\x10\n\x07\x62id_prc\x18\xb2\x01 \x01(\x01\x12\x10\n\x07\x61sk_prc\x18\xb5\x01 \x01(\x01\x12\x11\n\x08\x62id_iVol\x18\xb8\x01 \x01(\x02\x12\x11\n\x08\x61sk_iVol\x18\xbb\x01 \x01(\x02\x12\x11\n\x08\x62id_size\x18\xbe\x01 \x01(\x05\x12\x11\n\x08\x61sk_size\x18\xc1\x01 \x01(\x05\x12\x0e\n\x05u_bid\x18\xc4\x01 \x01(\x01\x12\x0e\n\x05u_ask\x18\xc7\x01 \x01(\x01\x12\x14\n\x0bsurface_prc\x18\xca\x01 \x01(\x02\x12\x14\n\x0bsurface_vol\x18\xcd\x01 \x01(\x02\x12\x14\n\x0bsurface_yrs\x18\xd0\x01 \x01(\x02\x12\x15\n\x0csurface_sDiv\x18\xd3\x01 \x01(\x02\x12\x15\n\x0csurface_rate\x18\xd6\x01 \x01(\x02\x12\x15\n\x0csurface_uPrc\x18\xd9\x01 \x01(\x02\x12\x13\n\nsurface_de\x18\xdc\x01 \x01(\x02\x12\x13\n\nsurface_ga\x18\xdf\x01 \x01(\x02\x12\x13\n\nsurface_th\x18\xe2\x01 \x01(\x02\x12\x13\n\nsurface_ve\x18\xe5\x01 \x01(\x02\x12\x13\n\nsurface_ro\x18\xe8\x01 \x01(\x02\x12\x13\n\nsurface_ph\x18\xeb\x01 \x01(\x02\x12\x19\n\x10\x61rrive_nbbo_size\x18\xee\x01 \x01(\x05\x12\x37\n\x10\x61rrive_nbbo_exch\x18\xf1\x01 \x01(\x0e\x32\x1c.spiderrock.protobuf.OptExch\x12\x18\n\x0f\x61rrive_cum_size\x18\xf4\x01 \x01(\x05\x12\x18\n\x0f\x61rrive_num_exch\x18\xf7\x01 \x01(\x05\x12\x1a\n\x11\x61rrive_limit_size\x18\xfa\x01 \x01(\x05\x12\x19\n\x10\x61rrive_limit_prc\x18\xfd\x01 \x01(\x01\x12\x15\n\x0c\x61vg_fill_prc\x18\x80\x02 \x01(\x01\x12\x16\n\rcum_fill_quan\x18\x83\x02 \x01(\x05\x12\x19\n\x10num_child_orders\x18\x86\x02 \x01(\r\x12\x1d\n\x14num_day_child_orders\x18\x89\x02 \x01(\r\x12\x18\n\x0fopen_order_size\x18\x8c\x02 \x01(\x05\x12\x1a\n\x11\x61\x63tion_order_size\x18\x8f\x02 \x01(\x05\x12\x18\n\x0frisk_limit_size\x18\x92\x02 \x01(\x05\x12\x37\n\x0frisk_limit_desc\x18\x95\x02 \x01(\x0e\x32\x1d.spiderrock.protobuf.SpdrRisk\x12\x1a\n\x11risk_limit_detail\x18\x98\x02 \x01(\t\x12\x17\n\x0elimit_ref_uPrc\x18\x9b\x02 \x01(\x01\x12\x14\n\x0blimit_price\x18\x9e\x02 \x01(\x01\x12\x12\n\tlimit_vol\x18\xa1\x02 \x01(\x02\x12\x19\n\x10make_limit_price\x18\xa4\x02 \x01(\x01\x12\x38\n\x0emake_limit_err\x18\xa7\x02 \x01(\x0e\x32\x1f.spiderrock.protobuf.LimitError\x12\x1c\n\x13make_limit_err_desc\x18\xaa\x02 \x01(\t\x12\x19\n\x10take_limit_price\x18\xad\x02 \x01(\x01\x12\x38\n\x0etake_limit_err\x18\xb0\x02 \x01(\x0e\x32\x1f.spiderrock.protobuf.LimitError\x12\x1c\n\x13take_limit_err_desc\x18\xb3\x02 \x01(\t\x12\x37\n\x0c\x62roker_state\x18\xb6\x02 \x01(\x0e\x32 .spiderrock.protobuf.BrokerState\x12\x33\n\nmake_state\x18\xb9\x02 \x01(\x0e\x32\x1e.spiderrock.protobuf.AlgoState\x12\x33\n\ntake_state\x18\xbc\x02 \x01(\x0e\x32\x1e.spiderrock.protobuf.AlgoState\x12<\n\x0fmkt_cross_state\x18\xbf\x02 \x01(\x0e\x32\".spiderrock.protobuf.MktCrossState\x12:\n\x10last_child_event\x18\xc2\x02 \x01(\x0e\x32\x1f.spiderrock.protobuf.ChildEvent\x12=\n\x0espdr_mkt_state\x18\xc5\x02 \x01(\x0e\x32$.spiderrock.protobuf.SpdrMarketState\x12\x13\n\nnum_orders\x18\xc8\x02 \x01(\x05\x12\x13\n\nleaves_qty\x18\xcb\x02 \x01(\x05\x12\x1b\n\x12\x63hild_order_leaves\x18\xce\x02 \x01(\x05\x12\x15\n\x0c\x61rrival_sDiv\x18\xd1\x02 \x01(\x02\x12\x15\n\x0c\x61rrival_rate\x18\xd4\x02 \x01(\x02\x12\x15\n\x0c\x61rrival_dDiv\x18\xd7\x02 \x01(\x02\x12\x36\n\rhedge_sec_key\x18\xda\x02 \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKey\x12\x39\n\x0ehedge_sec_type\x18\xdd\x02 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x11\n\x08theo_opx\x18\xe0\x02 \x01(\x02\x12\x11\n\x08theo_vol\x18\xe3\x02 \x01(\x02\x12\x19\n\x10\x63hild_order_mask\x18\xe6\x02 \x01(\r\x12\x37\n\x0cprice_format\x18\xe9\x02 \x01(\x0e\x32 .spiderrock.protobuf.PriceFormat\x12\x39\n\x0eu_price_format\x18\xec\x02 \x01(\x0e\x32 .spiderrock.protobuf.PriceFormat\x12\x12\n\tuser_name\x18\xef\x02 \x01(\t\x12.\n\ttimestamp\x18\xf2\x02 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1aR\n\x04PKey\x12\x15\n\rparent_number\x18\n \x01(\x03\x12\x33\n\x08rec_type\x18\x0b \x01(\x0e\x32!.spiderrock.protobuf.EventRecTypeb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientTrading.SpdrParentBrkrEvent_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_SPDRPARENTBRKREVENT']._serialized_start=123
  _globals['_SPDRPARENTBRKREVENT']._serialized_end=3375
  _globals['_SPDRPARENTBRKREVENT_PKEY']._serialized_start=3293
  _globals['_SPDRPARENTBRKREVENT_PKEY']._serialized_end=3375
# @@protoc_insertion_point(module_scope)
