# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientTrading/SpdrParentBrkrState.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\'ClientTrading/SpdrParentBrkrState.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xb8*\n\x13SpdrParentBrkrState\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12;\n\x04pkey\x18\x02 \x01(\x0b\x32-.spiderrock.protobuf.SpdrParentBrkrState.PKey\x12\x11\n\tuser_name\x18\x64 \x01(\t\x12\x15\n\rparent_number\x18j \x01(\x03\x12\x1a\n\x12\x62\x61se_parent_number\x18m \x01(\x03\x12\x16\n\rmodify_number\x18\xd4\x04 \x01(\x03\x12\x18\n\x0f\x63ross_notice_id\x18\xd5\x04 \x01(\x03\x12\x1d\n\x14\x62lock_auction_number\x18\xd6\x04 \x01(\x03\x12\x15\n\rrisk_group_id\x18p \x01(\x03\x12\x18\n\x10trigger_group_id\x18s \x01(\x03\x12\x10\n\x08strategy\x18v \x01(\t\x12\x14\n\x0c\x61lt_order_id\x18y \x01(\t\x12\x12\n\npackage_id\x18| \x01(\x03\x12\x11\n\talt_accnt\x18\x7f \x01(\t\x12\x16\n\ralt_user_name\x18\x82\x01 \x01(\t\x12\x37\n\nstage_type\x18\x85\x01 \x01(\x0e\x32\".spiderrock.protobuf.SpdrStageType\x12/\n\nis_flagged\x18\x88\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12/\n\x06ticker\x18\x8b\x01 \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\x0e\n\x05u_prc\x18\x8e\x01 \x01(\x01\x12\x14\n\x0bu_prc_order\x18\x91\x01 \x01(\x01\x12\x11\n\x08nbbo_bid\x18\x94\x01 \x01(\x01\x12\x11\n\x08nbbo_ask\x18\x97\x01 \x01(\x01\x12\x14\n\x0bnbbo_bid_sz\x18\x9a\x01 \x01(\x05\x12\x14\n\x0bnbbo_ask_sz\x18\x9d\x01 \x01(\x05\x12\x14\n\x0bsurface_prc\x18\xa0\x01 \x01(\x02\x12\x14\n\x0bsurface_vol\x18\xa3\x01 \x01(\x02\x12\x17\n\x0eorder_ref_sDiv\x18\xa6\x01 \x01(\x02\x12>\n\x13order_ref_sDiv_type\x18\xa9\x01 \x01(\x0e\x32 .spiderrock.protobuf.RefSDivType\x12\x42\n\x12spdr_broker_status\x18\xac\x01 \x01(\x0e\x32%.spiderrock.protobuf.SpdrBrokerStatus\x12@\n\x11spdr_order_status\x18\xaf\x01 \x01(\x0e\x32$.spiderrock.protobuf.SpdrOrderStatus\x12@\n\x11spdr_close_reason\x18\xb2\x01 \x01(\x0e\x32$.spiderrock.protobuf.SpdrCloseReason\x12\x42\n\x12spdr_reject_reason\x18\xb5\x01 \x01(\x0e\x32%.spiderrock.protobuf.SpdrRejectReason\x12>\n\x11spdr_reject_level\x18\xd7\x04 \x01(\x0e\x32\".spiderrock.protobuf.SpdrRiskLevel\x12:\n\x15is_permanently_closed\x18\xb8\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x1d\n\x14num_extern_risk_hold\x18\xbb\x01 \x01(\x05\x12\x1e\n\x15last_extern_risk_text\x18\xbe\x01 \x01(\t\x12<\n\x17last_extern_risk_reject\x18\xc1\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x15\n\x0cspdr_comment\x18\xc4\x01 \x01(\t\x12\x13\n\norder_size\x18\xc7\x01 \x01(\x05\x12\x1a\n\x11order_active_size\x18\xca\x01 \x01(\x05\x12\x18\n\x0f\x61\x63tive_duration\x18\xd8\x04 \x01(\x05\x12\x30\n\x0bupdate_dttm\x18\xcd\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x33\n\x0egood_till_dttm\x18\xd0\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x18\n\x0fleaves_quantity\x18\xd3\x01 \x01(\x05\x12\x17\n\x0e\x61vg_fill_price\x18\xd6\x01 \x01(\x01\x12\x18\n\x0f\x61vg_fill_uPrice\x18\xd9\x01 \x01(\x01\x12\x1a\n\x11\x63um_fill_quantity\x18\xdc\x01 \x01(\x05\x12\x15\n\x0c\x61vg_fill_vol\x18\xdf\x01 \x01(\x02\x12\x16\n\rcum_fill_vega\x18\xe2\x01 \x01(\x02\x12\x17\n\x0e\x63um_fill_theta\x18\xe5\x01 \x01(\x02\x12\x18\n\x0f\x63um_fill_dDelta\x18\xe8\x01 \x01(\x02\x12\x15\n\x0c\x63um_exch_fee\x18\xeb\x01 \x01(\x02\x12\x14\n\x0b\x63um_m10_pnl\x18\xee\x01 \x01(\x02\x12\x18\n\x0f\x63um_arrival_pnl\x18\xf1\x01 \x01(\x02\x12\x33\n\x0elast_fill_dttm\x18\xf4\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x18\n\x0frisk_limit_size\x18\xf7\x01 \x01(\x05\x12\x37\n\x0frisk_limit_desc\x18\xfa\x01 \x01(\x0e\x32\x1d.spiderrock.protobuf.SpdrRisk\x12=\n\x10risk_limit_level\x18\xd9\x04 \x01(\x0e\x32\".spiderrock.protobuf.SpdrRiskLevel\x12\x1a\n\x11risk_limit_detail\x18\xda\x04 \x01(\t\x12\x14\n\x0blimit_price\x18\xfd\x01 \x01(\x01\x12\x33\n\tlimit_err\x18\x80\x02 \x01(\x0e\x32\x1f.spiderrock.protobuf.LimitError\x12\x17\n\x0elimit_err_desc\x18\x83\x02 \x01(\t\x12\x1a\n\x11\x62\x65st_limit_offset\x18\x86\x02 \x01(\x02\x12\x18\n\x0fmake_prob_limit\x18\x89\x02 \x01(\x02\x12\x19\n\x10make_surf_offset\x18\x8c\x02 \x01(\x02\x12\x19\n\x10make_limit_price\x18\x8f\x02 \x01(\x01\x12\x38\n\x0emake_limit_err\x18\x92\x02 \x01(\x0e\x32\x1f.spiderrock.protobuf.LimitError\x12\x18\n\x0ftake_prob_limit\x18\x95\x02 \x01(\x02\x12\x19\n\x10take_surf_offset\x18\x98\x02 \x01(\x02\x12\x19\n\x10take_limit_price\x18\x9b\x02 \x01(\x01\x12\x38\n\x0etake_limit_err\x18\x9e\x02 \x01(\x0e\x32\x1f.spiderrock.protobuf.LimitError\x12\x33\n\nauto_hedge\x18\xa1\x02 \x01(\x0e\x32\x1e.spiderrock.protobuf.AutoHedge\x12\x39\n\x10hedge_instrument\x18\xa4\x02 \x01(\x0e\x32\x1e.spiderrock.protobuf.HedgeInst\x12\x36\n\rhedge_sec_key\x18\xa7\x02 \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKey\x12\x39\n\x0ehedge_sec_type\x18\xaa\x02 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x19\n\x10hedge_beta_ratio\x18\xad\x02 \x01(\x02\x12\x35\n\x0bhedge_scope\x18\xb0\x02 \x01(\x0e\x32\x1f.spiderrock.protobuf.HedgeScope\x12:\n\rhedge_session\x18\xdb\x04 \x01(\x0e\x32\".spiderrock.protobuf.MarketSession\x12\x1d\n\x14\x65xtern_hedge_ex_dest\x18\xb6\x02 \x01(\t\x12\x1c\n\x13\x65xtern_hedge_params\x18\xb9\x02 \x01(\t\x12\x13\n\nuser_data1\x18\xbc\x02 \x01(\t\x12\x13\n\nuser_data2\x18\xbf\x02 \x01(\t\x12\x37\n\x0cmax_progress\x18\xc2\x02 \x01(\x0e\x32 .spiderrock.protobuf.MaxProgress\x12\x1c\n\x13max_progress_detail\x18\xc5\x02 \x01(\t\x12\x36\n\x11max_progress_time\x18\xc8\x02 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x37\n\x0c\x62roker_state\x18\xcb\x02 \x01(\x0e\x32 .spiderrock.protobuf.BrokerState\x12\x17\n\x0e\x62roker_counter\x18\xce\x02 \x01(\x05\x12\x33\n\nmake_state\x18\xd1\x02 \x01(\x0e\x32\x1e.spiderrock.protobuf.AlgoState\x12\x15\n\x0cmake_counter\x18\xd4\x02 \x01(\x05\x12\x33\n\ntake_state\x18\xd7\x02 \x01(\x0e\x32\x1e.spiderrock.protobuf.AlgoState\x12\x15\n\x0ctake_counter\x18\xda\x02 \x01(\x05\x12:\n\x0emkt_resp_state\x18\xdd\x02 \x01(\x0e\x32!.spiderrock.protobuf.MktRespState\x12\x19\n\x10mkt_resp_counter\x18\xe0\x02 \x01(\x05\x12<\n\x0fmkt_cross_state\x18\xe3\x02 \x01(\x0e\x32\".spiderrock.protobuf.MktCrossState\x12\x1a\n\x11mkt_cross_counter\x18\xe6\x02 \x01(\x05\x12\x1d\n\x14progress_rule_detail\x18\xe9\x02 \x01(\t\x12:\n\x10last_child_event\x18\xec\x02 \x01(\x0e\x32\x1f.spiderrock.protobuf.ChildEvent\x12;\n\x16last_child_reject_dttm\x18\xef\x02 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x1f\n\x16last_child_reject_text\x18\xf2\x02 \x01(\t\x12=\n\x0espdr_mkt_state\x18\xf5\x02 \x01(\x0e\x32$.spiderrock.protobuf.SpdrMarketState\x12\r\n\x04\x63px1\x18\xf8\x02 \x01(\x02\x12\r\n\x04\x63sz1\x18\xfb\x02 \x01(\x05\x12\r\n\x04\x63\x65x1\x18\xfe\x02 \x01(\r\x12\r\n\x04\x63nt1\x18\x81\x03 \x01(\x05\x12\r\n\x04\x63px2\x18\x84\x03 \x01(\x02\x12\r\n\x04\x63sz2\x18\x87\x03 \x01(\x05\x12\r\n\x04\x63\x65x2\x18\x8a\x03 \x01(\r\x12\r\n\x04\x63nt2\x18\x8d\x03 \x01(\x05\x12\x0f\n\x06\x63_more\x18\x90\x03 \x01(\x05\x12\x13\n\nexpiry_key\x18\x93\x03 \x01(\t\x12\x0f\n\x06\x63n_vol\x18\x96\x03 \x01(\x02\x12\x0f\n\x06\x63n_yrs\x18\x99\x03 \x01(\x02\x12\x10\n\x07\x63n_uPrc\x18\x9c\x03 \x01(\x02\x12\x0e\n\x05\x63n_de\x18\x9f\x03 \x01(\x02\x12\x0e\n\x05\x63n_dd\x18\xa2\x03 \x01(\x02\x12\x0e\n\x05\x63n_ve\x18\xa5\x03 \x01(\x02\x12\x0e\n\x05\x63n_ga\x18\xa8\x03 \x01(\x02\x12\x0e\n\x05\x63n_th\x18\xab\x03 \x01(\x02\x12\x0e\n\x05\x63n_pr\x18\xae\x03 \x01(\x02\x12\x10\n\x07\x64\x64_mult\x18\xb1\x03 \x01(\x02\x12\x37\n\x0cprice_format\x18\xb4\x03 \x01(\x0e\x32 .spiderrock.protobuf.PriceFormat\x12\x39\n\x0eu_price_format\x18\xb7\x03 \x01(\x0e\x32 .spiderrock.protobuf.PriceFormat\x12\x1a\n\x11underliers_per_cn\x18\xba\x03 \x01(\x05\x12;\n\x0eunderlier_type\x18\xbd\x03 \x01(\x0e\x32\".spiderrock.protobuf.UnderlierType\x12\x13\n\ntick_value\x18\xc0\x03 \x01(\x02\x12\x14\n\x0bpoint_value\x18\xc3\x03 \x01(\x02\x12\x36\n\x0epoint_currency\x18\xc6\x03 \x01(\x0e\x32\x1d.spiderrock.protobuf.Currency\x12\x11\n\x08theo_vol\x18\xff\x03 \x01(\x02\x12\x11\n\x08theo_prc\x18\x82\x04 \x01(\x02\x12\x17\n\x0enum_new_orders\x18\x85\x04 \x01(\x05\x12\x1a\n\x11num_parent_limits\x18\x88\x04 \x01(\r\x12\x19\n\x10\x62roker_vwap_mark\x18\x8b\x04 \x01(\x02\x12\x1a\n\x11\x62roker_vwap_uMark\x18\x8e\x04 \x01(\x02\x12\x19\n\x10\x62roker_qwap_mark\x18\x91\x04 \x01(\x02\x12\x1a\n\x11\x62roker_qwap_uMark\x18\x94\x04 \x01(\x02\x12\x12\n\tvwap_pn_l\x18\x97\x04 \x01(\x02\x12\x15\n\x0cvwap_dn_pn_l\x18\x9a\x04 \x01(\x02\x12\x1a\n\x11u_drift_vwap_pn_l\x18\x9d\x04 \x01(\x02\x12\x12\n\tqwap_pn_l\x18\xa0\x04 \x01(\x02\x12\x15\n\x0cqwap_dn_pn_l\x18\xa3\x04 \x01(\x02\x12\x1a\n\x11u_drift_qwap_pn_l\x18\xa6\x04 \x01(\x02\x12\x17\n\x0enum_imprv_chld\x18\xa9\x04 \x01(\x05\x12\x17\n\x0e\x61\x63tive_seconds\x18\xac\x04 \x01(\x02\x12\x15\n\x0cwith_seconds\x18\xaf\x04 \x01(\x02\x12\x16\n\ralone_seconds\x18\xb2\x04 \x01(\x02\x12\x18\n\x0fworking_seconds\x18\xb5\x04 \x01(\x02\x12\x19\n\x10num_risk_cancels\x18\xb8\x04 \x01(\x05\x12\x1a\n\x11risk_hold_seconds\x18\xbb\x04 \x01(\x02\x12\x1b\n\x12risk_thrtl_seconds\x18\xbe\x04 \x01(\x02\x12 \n\x17num_make_throttle_skips\x18\xc1\x04 \x01(\x05\x12 \n\x17sum_make_throttle_delay\x18\xc4\x04 \x01(\x02\x12\x14\n\x0bu_prc_drift\x18\xc7\x04 \x01(\x02\x12\x14\n\x0bs_vol_drift\x18\xca\x04 \x01(\x02\x12\x36\n\nupdate_src\x18\xcd\x04 \x01(\x0e\x32!.spiderrock.protobuf.UpdateSource\x12\x14\n\x0bnum_updates\x18\xd0\x04 \x01(\x05\x12.\n\ttimestamp\x18\xd3\x04 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\x8e\x02\n\x04PKey\x12\r\n\x05\x61\x63\x63nt\x18\n \x01(\t\x12/\n\x07sec_key\x18\x0b \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x32\n\x08sec_type\x18\x0c \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x34\n\x0bspdr_source\x18\r \x01(\x0e\x32\x1f.spiderrock.protobuf.SpdrSource\x12\x15\n\rgrouping_code\x18\x0e \x01(\x03\x12\x30\n\norder_side\x18\x0f \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x13\n\x0b\x63lient_firm\x18\x10 \x01(\tb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientTrading.SpdrParentBrkrState_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_SPDRPARENTBRKRSTATE']._serialized_start=123
  _globals['_SPDRPARENTBRKRSTATE']._serialized_end=5555
  _globals['_SPDRPARENTBRKRSTATE_PKEY']._serialized_start=5285
  _globals['_SPDRPARENTBRKRSTATE_PKEY']._serialized_end=5555
# @@protoc_insertion_point(module_scope)
