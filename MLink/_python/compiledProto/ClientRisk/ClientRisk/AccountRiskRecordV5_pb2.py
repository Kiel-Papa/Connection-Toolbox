# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientRisk/AccountRiskRecordV5.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n$ClientRisk/AccountRiskRecordV5.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\x82\x1a\n\x13\x41\x63\x63ountRiskRecordV5\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12;\n\x04pkey\x18\x02 \x01(\x0b\x32-.spiderrock.protobuf.AccountRiskRecordV5.PKey\x12\x13\n\x0b\x63lient_firm\x18\x64 \x01(\t\x12\x18\n\x10risk_server_code\x18g \x01(\t\x12\x11\n\tln_dDelta\x18j \x01(\x01\x12\x11\n\tsh_dDelta\x18m \x01(\x01\x12\x18\n\x10ln_stk_mkt_value\x18p \x01(\x01\x12\x18\n\x10sh_stk_mkt_value\x18s \x01(\x01\x12\x15\n\rfut_mkt_value\x18v \x01(\x01\x12\x19\n\x11stk_opt_mkt_value\x18y \x01(\x01\x12\x19\n\x11\x66ut_opt_mkt_value\x18| \x01(\x01\x12\x11\n\tvega_long\x18\x7f \x01(\x02\x12\x13\n\nvega_short\x18\x82\x01 \x01(\x02\x12\x14\n\x0bw_vega_long\x18\x85\x01 \x01(\x02\x12\x15\n\x0cw_vega_short\x18\x88\x01 \x01(\x02\x12\x15\n\x0cwt_vega_long\x18\x8b\x01 \x01(\x02\x12\x16\n\rwt_vega_short\x18\x8e\x01 \x01(\x02\x12\x13\n\ntheta_long\x18\x91\x01 \x01(\x02\x12\x14\n\x0btheta_short\x18\x94\x01 \x01(\x02\x12\x11\n\x08rho_long\x18\x97\x01 \x01(\x02\x12\x12\n\trho_short\x18\x9a\x01 \x01(\x02\x12\x10\n\x07ivol_ln\x18\x9d\x01 \x01(\x02\x12\x10\n\x07ivol_sh\x18\xa0\x01 \x01(\x02\x12\x11\n\x08wt_ve_dd\x18\xa3\x01 \x01(\x02\x12\x11\n\x08wt_ve_dn\x18\xa6\x01 \x01(\x02\x12\x11\n\x08wt_ve_at\x18\xa9\x01 \x01(\x02\x12\x11\n\x08wt_ve_up\x18\xac\x01 \x01(\x02\x12\x11\n\x08wt_ve_du\x18\xaf\x01 \x01(\x02\x12\x11\n\x08wt_ve_m1\x18\xb2\x01 \x01(\x02\x12\x11\n\x08wt_ve_m2\x18\xb5\x01 \x01(\x02\x12\x11\n\x08wt_ve_m3\x18\xb8\x01 \x01(\x02\x12\x11\n\x08wt_ve_m4\x18\xbb\x01 \x01(\x02\x12\x11\n\x08wt_ve_m5\x18\xbe\x01 \x01(\x02\x12\x0f\n\x06\x64\x64\x65lta\x18\xc1\x01 \x01(\x02\x12\x14\n\x0bnum_symbols\x18\xc4\x01 \x01(\x05\x12\x13\n\nabs_cur_sh\x18\xc7\x01 \x01(\x05\x12\x13\n\nabs_cur_fc\x18\xca\x01 \x01(\x05\x12\x13\n\nabs_cur_cn\x18\xcd\x01 \x01(\x05\x12\x14\n\x0bprem_ov_par\x18\xd0\x01 \x01(\x02\x12\x16\n\ropt_ex_as_pnl\x18\xd3\x01 \x01(\x01\x12\x15\n\x0c\x64ividend_pnl\x18\xd6\x01 \x01(\x01\x12\x1b\n\x12\x63orp_act_cash_pn_l\x18\xd9\x01 \x01(\x01\x12\x18\n\x0fstk_opn_pnl_mid\x18\xdc\x01 \x01(\x01\x12\x18\n\x0fstk_opn_pnl_clr\x18\xdf\x01 \x01(\x01\x12\x18\n\x0f\x66ut_opn_pnl_mid\x18\xe2\x01 \x01(\x01\x12\x18\n\x0f\x66ut_opn_pnl_clr\x18\xe5\x01 \x01(\x01\x12\x1c\n\x13stk_opt_opn_pnl_vol\x18\xe8\x01 \x01(\x01\x12\x1c\n\x13stk_opt_opn_pnl_mid\x18\xeb\x01 \x01(\x01\x12\x1c\n\x13stk_opt_opn_pnl_clr\x18\xee\x01 \x01(\x01\x12\x1c\n\x13\x66ut_opt_opn_pnl_vol\x18\xf1\x01 \x01(\x01\x12\x1c\n\x13\x66ut_opt_opn_pnl_mid\x18\xf4\x01 \x01(\x01\x12\x1c\n\x13\x66ut_opt_opn_pnl_clr\x18\xf7\x01 \x01(\x01\x12\x14\n\x0bstk_day_pnl\x18\xfa\x01 \x01(\x01\x12\x14\n\x0b\x66ut_day_pnl\x18\xfd\x01 \x01(\x01\x12\x18\n\x0fstk_opt_day_pnl\x18\x80\x02 \x01(\x01\x12\x18\n\x0f\x66ut_opt_day_pnl\x18\x83\x02 \x01(\x01\x12\x14\n\x0bstkt_day_sh\x18\x86\x02 \x01(\x05\x12\x14\n\x0bstk_day_mny\x18\x89\x02 \x01(\x01\x12\x13\n\nfut_day_cn\x18\x8c\x02 \x01(\x05\x12\x14\n\x0b\x66ut_day_mny\x18\x8f\x02 \x01(\x01\x12\x17\n\x0estk_opt_day_cn\x18\x92\x02 \x01(\x05\x12\x18\n\x0fstk_opt_day_mny\x18\x95\x02 \x01(\x01\x12\x17\n\x0e\x66ut_opt_day_cn\x18\x98\x02 \x01(\x05\x12\x18\n\x0f\x66ut_opt_day_mny\x18\x9b\x02 \x01(\x01\x12\x13\n\nday_dDelta\x18\x9e\x02 \x01(\x02\x12\x14\n\x0bop_day_vega\x18\xa1\x02 \x01(\x02\x12\x15\n\x0cop_day_wVega\x18\xa4\x02 \x01(\x02\x12\x15\n\x0cop_day_tVega\x18\xa7\x02 \x01(\x02\x12\x17\n\x0eop_day_wt_vega\x18\xaa\x02 \x01(\x02\x12\x15\n\x0cop_day_theta\x18\xad\x02 \x01(\x02\x12\x17\n\x0eop_edge_opened\x18\xb0\x02 \x01(\x02\x12\x17\n\x0eop_edge_closed\x18\xb3\x02 \x01(\x02\x12\x0f\n\x06pnl_dn\x18\xb6\x02 \x01(\x02\x12\x0f\n\x06pnl_de\x18\xb9\x02 \x01(\x02\x12\x0f\n\x06pnl_sl\x18\xbc\x02 \x01(\x02\x12\x0f\n\x06pnl_ga\x18\xbf\x02 \x01(\x02\x12\x0f\n\x06pnl_th\x18\xc2\x02 \x01(\x02\x12\x0f\n\x06pnl_ve\x18\xc5\x02 \x01(\x02\x12\x0f\n\x06pnl_vo\x18\xc8\x02 \x01(\x02\x12\x0f\n\x06pnl_va\x18\xcb\x02 \x01(\x02\x12\x11\n\x08pnl_dDiv\x18\xce\x02 \x01(\x02\x12\x11\n\x08pnl_sDiv\x18\xd1\x02 \x01(\x02\x12\x11\n\x08pnl_rate\x18\xd4\x02 \x01(\x02\x12\x10\n\x07pnl_err\x18\xd7\x02 \x01(\x02\x12\x0f\n\x06pnl_te\x18\xda\x02 \x01(\x02\x12\x0f\n\x06pnl_ln\x18\xdd\x02 \x01(\x02\x12\x0f\n\x06pnl_sh\x18\xe0\x02 \x01(\x02\x12\x0f\n\x06t_edge\x18\xe3\x02 \x01(\x02\x12\x14\n\x0bt_edge_mult\x18\xe6\x02 \x01(\x02\x12\x16\n\rpos_tEdge_pnl\x18\xe9\x02 \x01(\x02\x12\x16\n\rneg_tEdge_pnl\x18\xec\x02 \x01(\x02\x12\x16\n\rbad_tEdge_pnl\x18\xef\x02 \x01(\x02\x12\x11\n\x08va_rsu90\x18\xf2\x02 \x01(\x02\x12\x11\n\x08va_rsd90\x18\xf5\x02 \x01(\x02\x12\x11\n\x08va_rsu50\x18\xf8\x02 \x01(\x02\x12\x11\n\x08va_rsd50\x18\xfb\x02 \x01(\x02\x12\x11\n\x08va_rsu15\x18\xfe\x02 \x01(\x02\x12\x11\n\x08va_rsd15\x18\x81\x03 \x01(\x02\x12\x11\n\x08va_rsu10\x18\x84\x03 \x01(\x02\x12\x11\n\x08va_rsd10\x18\x87\x03 \x01(\x02\x12\x11\n\x08va_rsu05\x18\x8a\x03 \x01(\x02\x12\x11\n\x08va_rsd05\x18\x8d\x03 \x01(\x02\x12\x11\n\x08va_rsu1e\x18\x90\x03 \x01(\x02\x12\x11\n\x08va_rsd1e\x18\x93\x03 \x01(\x02\x12\x11\n\x08va_rsu2e\x18\x96\x03 \x01(\x02\x12\x11\n\x08va_rsd2e\x18\x99\x03 \x01(\x02\x12\x11\n\x08va_rearn\x18\x9c\x03 \x01(\x02\x12\x11\n\x08va_rcash\x18\x9f\x03 \x01(\x02\x12\x0f\n\x06hc_cnt\x18\xa2\x03 \x01(\x02\x12\x12\n\thaircut25\x18\xa5\x03 \x01(\x02\x12\x12\n\thaircut37\x18\xa8\x03 \x01(\x02\x12\x17\n\x0eopt_cn_minimum\x18\xab\x03 \x01(\x02\x12\x0f\n\x06span01\x18\xae\x03 \x01(\x02\x12\x0f\n\x06span02\x18\xb1\x03 \x01(\x02\x12\x0f\n\x06span03\x18\xb4\x03 \x01(\x02\x12\x0f\n\x06span04\x18\xb7\x03 \x01(\x02\x12\x0f\n\x06span05\x18\xba\x03 \x01(\x02\x12\x0f\n\x06span06\x18\xbd\x03 \x01(\x02\x12\x0f\n\x06span07\x18\xc0\x03 \x01(\x02\x12\x0f\n\x06span08\x18\xc3\x03 \x01(\x02\x12\x0f\n\x06span09\x18\xc6\x03 \x01(\x02\x12\x0f\n\x06span10\x18\xc9\x03 \x01(\x02\x12\x0f\n\x06span11\x18\xcc\x03 \x01(\x02\x12\x0f\n\x06span12\x18\xcf\x03 \x01(\x02\x12\x0f\n\x06span13\x18\xd2\x03 \x01(\x02\x12\x0f\n\x06span14\x18\xd5\x03 \x01(\x02\x12\x0f\n\x06span15\x18\xd8\x03 \x01(\x02\x12\x0f\n\x06span16\x18\xdb\x03 \x01(\x02\x12\x14\n\x0bworst3_risk\x18\xde\x03 \x01(\x02\x12\x33\n\nworst_sym1\x18\xe1\x03 \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\x33\n\nworst_sym2\x18\xe4\x03 \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\x33\n\nworst_sym3\x18\xe7\x03 \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\x15\n\x0cstk_liq_risk\x18\xea\x03 \x01(\x02\x12\x15\n\x0c\x66ut_liq_risk\x18\xed\x03 \x01(\x02\x12\x15\n\x0copt_liq_risk\x18\xf0\x03 \x01(\x02\x12\x17\n\x0esr_risk_margin\x18\xf3\x03 \x01(\x02\x12\x32\n\rlast_activity\x18\xf6\x03 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12.\n\ttimestamp\x18\xf9\x03 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\xb0\x01\n\x04PKey\x12\r\n\x05\x61\x63\x63nt\x18\n \x01(\t\x12/\n\x08\x63urrency\x18\x0b \x01(\x0e\x32\x1d.spiderrock.protobuf.Currency\x12\x30\n\ntrade_date\x18\x0c \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12\x36\n\x0crisk_session\x18\r \x01(\x0e\x32 .spiderrock.protobuf.RiskSessionb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientRisk.AccountRiskRecordV5_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_ACCOUNTRISKRECORDV5']._serialized_start=120
  _globals['_ACCOUNTRISKRECORDV5']._serialized_end=3450
  _globals['_ACCOUNTRISKRECORDV5_PKEY']._serialized_start=3274
  _globals['_ACCOUNTRISKRECORDV5_PKEY']._serialized_end=3450
# @@protoc_insertion_point(module_scope)
