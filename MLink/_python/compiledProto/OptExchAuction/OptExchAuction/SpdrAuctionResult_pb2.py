# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: OptExchAuction/SpdrAuctionResult.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n&OptExchAuction/SpdrAuctionResult.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xa5\x18\n\x11SpdrAuctionResult\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x39\n\x04pkey\x18\x02 \x01(\x0b\x32+.spiderrock.protobuf.SpdrAuctionResult.PKey\x12\x15\n\rsr_auction_iD\x18\x64 \x01(\x03\x12\x17\n\x0f\x65xch_auction_id\x18g \x01(\t\x12\x19\n\x11\x65xch_auction_type\x18j \x01(\t\x12\x37\n\rauction_shape\x18m \x01(\x0e\x32 .spiderrock.protobuf.NoticeShape\x12\x36\n\x0c\x61uction_type\x18p \x01(\x0e\x32 .spiderrock.protobuf.AuctionType\x12\x32\n\x0c\x61uction_side\x18s \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x14\n\x0cmatched_size\x18v \x01(\x05\x12\x14\n\x0c\x61uction_size\x18y \x01(\x05\x12\x15\n\rauction_price\x18| \x01(\x01\x12:\n\x16is_auction_price_valid\x18\x7f \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x19\n\x10\x61uction_duration\x18\x82\x01 \x01(\x05\x12 \n\x17\x61uction_start_timestamp\x18\x85\x01 \x01(\x03\x12\x1a\n\x11min_response_size\x18\x88\x01 \x01(\x05\x12\x41\n\x11\x63lient_limit_type\x18\x8b\x01 \x01(\x0e\x32%.spiderrock.protobuf.AuctionLimitType\x12\x31\n\tfirm_type\x18\x8e\x01 \x01(\x0e\x32\x1d.spiderrock.protobuf.FirmType\x12\x14\n\x0bmember_mPID\x18\x91\x01 \x01(\t\x12\x15\n\x0c\x63lient_accnt\x18\x94\x01 \x01(\t\x12\x15\n\x0cother_detail\x18\x97\x01 \x01(\t\x12\x39\n\rmarket_status\x18\x9a\x01 \x01(\x0e\x32!.spiderrock.protobuf.MarketStatus\x12\x14\n\x0bnum_updates\x18\x9d\x01 \x01(\x05\x12 \n\x17\x61uction_final_timestamp\x18\xa0\x01 \x01(\x03\x12\x1b\n\x12\x61uction_start_size\x18\xa3\x01 \x01(\x05\x12\x1c\n\x13\x61uction_start_price\x18\xa6\x01 \x01(\x01\x12#\n\x1a\x61uction_start_matched_size\x18\xa9\x01 \x01(\x05\x12\x16\n\rnum_responses\x18\xac\x01 \x01(\x05\x12\x1b\n\x12\x62\x65st_response_size\x18\xaf\x01 \x01(\x05\x12\x1c\n\x13\x62\x65st_response_price\x18\xb2\x01 \x01(\x01\x12\x1a\n\x11\x63um_fill_quantity\x18\xb5\x01 \x01(\x05\x12\x17\n\x0e\x61vg_fill_price\x18\xb8\x01 \x01(\x01\x12\x1c\n\x13\x61uction_final_price\x18\xbb\x01 \x01(\x01\x12\x16\n\rsrc_timestamp\x18\xbe\x01 \x01(\x03\x12\x16\n\rnet_timestamp\x18\xc1\x01 \x01(\x03\x12\x16\n\rdgw_timestamp\x18\xc4\x01 \x01(\x03\x12\x16\n\rmmr_timestamp\x18\xc7\x01 \x01(\x03\x12\x16\n\reng_timestamp\x18\xca\x01 \x01(\x03\x12.\n\ttimestamp\x18\xcd\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x16\n\rauction_start\x18\xdf\x01 \x01(\x01\x12\x43\n\x13\x61uction_nbbo_stance\x18\xe2\x01 \x01(\x0e\x32%.spiderrock.protobuf.AuctionMktStance\x12\x43\n\x13\x61uction_exch_stance\x18\xe5\x01 \x01(\x0e\x32%.spiderrock.protobuf.AuctionMktStance\x12\x12\n\tbid_price\x18\xe8\x01 \x01(\x02\x12\x12\n\task_price\x18\xeb\x01 \x01(\x02\x12\x15\n\x0c\x63um_bid_size\x18\xee\x01 \x01(\x05\x12\x15\n\x0c\x63um_ask_size\x18\xf1\x01 \x01(\x05\x12\x15\n\x0c\x65xch_bid_prc\x18\xf4\x01 \x01(\x02\x12\x15\n\x0c\x65xch_ask_prc\x18\xf7\x01 \x01(\x02\x12\x16\n\rexch_bid_size\x18\xfa\x01 \x01(\x05\x12\x16\n\rexch_ask_size\x18\xfd\x01 \x01(\x05\x12\x18\n\x0frsp_probability\x18\x80\x02 \x01(\x02\x12\r\n\x04svol\x18\x83\x02 \x01(\x02\x12\r\n\x04sprc\x18\x86\x02 \x01(\x02\x12\r\n\x04vega\x18\x89\x02 \x01(\x02\x12\x0e\n\x05\x64\x65lta\x18\x8c\x02 \x01(\x02\x12\x15\n\x0cs_edge_start\x18\x8f\x02 \x01(\x02\x12\x15\n\x0cs_edge_print\x18\x92\x02 \x01(\x02\x12\x0e\n\x05u_bid\x18\x95\x02 \x01(\x02\x12\x0e\n\x05u_ask\x18\x98\x02 \x01(\x02\x12\x10\n\x07u_bid_t\x18\x9b\x02 \x01(\x02\x12\x10\n\x07u_ask_t\x18\x9e\x02 \x01(\x02\x12\x46\n\x14\x61uction_print_result\x18\xa1\x02 \x01(\x0e\x32\'.spiderrock.protobuf.AuctionPrintResult\x12\x19\n\x10\x66irst_print_size\x18\xa4\x02 \x01(\x02\x12\x1a\n\x11\x66irst_print_price\x18\xa7\x02 \x01(\x01\x12\x37\n\x10\x66irst_print_side\x18\xaa\x02 \x01(\x0e\x32\x1c.spiderrock.protobuf.PrtSide\x12\x37\n\x10\x66irst_print_type\x18\xad\x02 \x01(\x0e\x32\x1c.spiderrock.protobuf.PrtType\x12\x1c\n\x13\x66irst_src_timestamp\x18\xb0\x02 \x01(\x03\x12\x1c\n\x13\x66irst_net_timestamp\x18\xb3\x02 \x01(\x03\x12\x1a\n\x11\x66irst_src_latency\x18\xb6\x02 \x01(\x02\x12\x1a\n\x11\x66irst_net_latency\x18\xb9\x02 \x01(\x02\x12\x1c\n\x13\x66irst_away_prt_size\x18\xbc\x02 \x01(\x05\x12\x1d\n\x14\x66irst_away_prt_price\x18\xbf\x02 \x01(\x01\x12\x1f\n\x16\x66irst_away_net_latency\x18\xc2\x02 \x01(\x02\x12\x13\n\nnum_prints\x18\xc5\x02 \x01(\x05\x12\x17\n\x0e\x63um_print_size\x18\xc8\x02 \x01(\x05\x12\x18\n\x0f\x61vg_print_price\x18\xcb\x02 \x01(\x01\x12\x17\n\x0enum_print_legs\x18\xce\x02 \x01(\x05\x12\x10\n\x07mark_m1\x18\xd1\x02 \x01(\x02\x12\x12\n\tu_mark_m1\x18\xd4\x02 \x01(\x02\x12\x0f\n\x06pnl_m1\x18\xd7\x02 \x01(\x02\x12/\n\npnl_m1_err\x18\xda\x02 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x11\n\x08mark_m10\x18\xdd\x02 \x01(\x02\x12\x13\n\nu_mark_m10\x18\xe0\x02 \x01(\x02\x12\x10\n\x07pnl_m10\x18\xe3\x02 \x01(\x02\x12\x30\n\x0bpnl_m10_err\x18\xe6\x02 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12:\n\x04legs\x18\xd0\x01 \x03(\x0b\x32+.spiderrock.protobuf.SpdrAuctionResult.Legs\x1a\xec\x01\n\x04PKey\x12/\n\x07sec_key\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x32\n\x08sec_type\x18\x0b \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x32\n\x0c\x61uction_exch\x18\x0c \x01(\x0e\x32\x1c.spiderrock.protobuf.OptExch\x12\x17\n\x0f\x61uction_ex_dest\x18\r \x01(\t\x12\x32\n\nrun_status\x18\x0e \x01(\x0e\x32\x1e.spiderrock.protobuf.RunStatus\x1a\xba\x01\n\x04Legs\x12\x34\n\x0bleg_sec_key\x18\xd3\x01 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x37\n\x0cleg_sec_type\x18\xd6\x01 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12/\n\x08leg_side\x18\xd9\x01 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x12\n\tleg_ratio\x18\xdc\x01 \x01(\rb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'OptExchAuction.SpdrAuctionResult_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_SPDRAUCTIONRESULT']._serialized_start=122
  _globals['_SPDRAUCTIONRESULT']._serialized_end=3231
  _globals['_SPDRAUCTIONRESULT_PKEY']._serialized_start=2806
  _globals['_SPDRAUCTIONRESULT_PKEY']._serialized_end=3042
  _globals['_SPDRAUCTIONRESULT_LEGS']._serialized_start=3045
  _globals['_SPDRAUCTIONRESULT_LEGS']._serialized_end=3231
# @@protoc_insertion_point(module_scope)
