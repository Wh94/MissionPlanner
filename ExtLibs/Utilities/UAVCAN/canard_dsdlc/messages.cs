using System;using OpenTK; public partial class uavcan { public static readonly (Type,UInt16, ulong)[] MSG_INFO = {(typeof(uavcan_Measurement), 20200, 6835555413122590146),
(typeof(uavcan_equipment_actuator_ArrayCommand), 1010, 15611526220002114291),
(typeof(uavcan_equipment_actuator_Status), 1011, 6817247266386078212),
(typeof(uavcan_equipment_ahrs_Solution), 1000, 8261354597696797339),
(typeof(uavcan_equipment_ahrs_MagneticFieldStrength), 1001, 16332256397172130546),
(typeof(uavcan_equipment_ahrs_MagneticFieldStrength2), 1002, 13162909297701562750),
(typeof(uavcan_equipment_ahrs_RawIMU), 1003, 9403625063668085941),
(typeof(uavcan_equipment_air_data_TrueAirspeed), 1020, 3490124649806802858),
(typeof(uavcan_equipment_air_data_IndicatedAirspeed), 1021, 727492792652698719),
(typeof(uavcan_equipment_air_data_AngleOfAttack), 1025, 15371133246536075086),
(typeof(uavcan_equipment_air_data_Sideslip), 1026, 8883602464661842519),
(typeof(uavcan_equipment_air_data_RawAirData), 1027, 14374913366665917914),
(typeof(uavcan_equipment_air_data_StaticPressure), 1028, 14828036026072418458),
(typeof(uavcan_equipment_air_data_StaticTemperature), 1029, 5271228499856286321),
(typeof(uavcan_equipment_camera_gimbal_AngularCommand), 1040, 5401757120245523100),
(typeof(uavcan_equipment_camera_gimbal_GEOPOICommand), 1041, 10624346158881841110),
(typeof(uavcan_equipment_camera_gimbal_Status), 1044, 13398533824424498718),
(typeof(uavcan_equipment_device_Temperature), 1110, 8081177542326830278),
(typeof(uavcan_equipment_esc_RawCommand), 1030, 2413749663806821661),
(typeof(uavcan_equipment_esc_RPMCommand), 1031, 14848261740205434635),
(typeof(uavcan_equipment_esc_Status), 1034, 12227036243858010708),
(typeof(uavcan_equipment_gnss_Fix), 1060, 6107258414537634455),
(typeof(uavcan_equipment_gnss_Auxiliary), 1061, 11234437923272900562),
(typeof(uavcan_equipment_gnss_RTCMStream), 1062, 2257995625244595457),
(typeof(uavcan_equipment_gnss_Fix2), 1063, 14574183856588931935),
(typeof(uavcan_equipment_hardpoint_Command), 1070, 11646368175549592661),
(typeof(uavcan_equipment_hardpoint_Status), 1071, 7082563099858124162),
(typeof(uavcan_equipment_ice_FuelTankStatus), 1129, 2912503190478408644),
(typeof(uavcan_equipment_ice_reciprocating_Status), 1120, 15243176133354815174),
(typeof(uavcan_equipment_indication_BeepCommand), 1080, 13735602825179782482),
(typeof(uavcan_equipment_indication_LightsCommand), 1081, 2319874137140305604),
(typeof(uavcan_equipment_power_PrimaryPowerSupplyStatus), 1090, 13519894543422813312),
(typeof(uavcan_equipment_power_CircuitStatus), 1091, 9445125102705156373),
(typeof(uavcan_equipment_power_BatteryInfo), 1092, 2638025626274044262),
(typeof(uavcan_equipment_range_sensor_Measurement), 1050, 7566045660231178578),
(typeof(uavcan_equipment_safety_ArmingStatus), 1100, 9728042880390037507),
(typeof(uavcan_navigation_GlobalNavigationSolution), 2000, 5060657078061046845),
(typeof(uavcan_protocol_GetNodeInfo_req), 1, 17169562916618529438),
(typeof(uavcan_protocol_GetNodeInfo_res), 1, 17169562916618529438),
(typeof(uavcan_protocol_GetDataTypeInfo_req), 2, 1956870356517966552),
(typeof(uavcan_protocol_GetDataTypeInfo_res), 2, 1956870356517966552),
(typeof(uavcan_protocol_NodeStatus), 341, 1083230956194088689),
(typeof(uavcan_protocol_GetTransportStats_req), 4, 13722317053215451908),
(typeof(uavcan_protocol_GetTransportStats_res), 4, 13722317053215451908),
(typeof(uavcan_protocol_GlobalTimeSync), 4, 2316839322303840987),
(typeof(uavcan_protocol_Panic), 5, 10050262024670265815),
(typeof(uavcan_protocol_RestartNode_req), 5, 6241431877198026736),
(typeof(uavcan_protocol_RestartNode_res), 5, 6241431877198026736),
(typeof(uavcan_protocol_AccessCommandShell_req), 6, 6424221424030393454),
(typeof(uavcan_protocol_AccessCommandShell_res), 6, 6424221424030393454),
(typeof(uavcan_protocol_debug_KeyValue), 16370, 16154171993225792224),
(typeof(uavcan_protocol_debug_LogMessage), 16383, 15444149952154213749),
(typeof(uavcan_protocol_dynamic_node_id_Allocation), 1, 804597484195224896),
(typeof(uavcan_protocol_dynamic_node_id_server_AppendEntries_req), 30, 9237664629227299788),
(typeof(uavcan_protocol_dynamic_node_id_server_AppendEntries_res), 30, 9237664629227299788),
(typeof(uavcan_protocol_dynamic_node_id_server_RequestVote_req), 31, 14834302724654588758),
(typeof(uavcan_protocol_dynamic_node_id_server_RequestVote_res), 31, 14834302724654588758),
(typeof(uavcan_protocol_dynamic_node_id_server_Discovery), 390, 9375055116856893217),
(typeof(uavcan_protocol_enumeration_Begin_req), 15, 1831522919229142488),
(typeof(uavcan_protocol_enumeration_Begin_res), 15, 1831522919229142488),
(typeof(uavcan_protocol_enumeration_Indication), 380, 9821425206016102197),
(typeof(uavcan_protocol_file_BeginFirmwareUpdate_req), 40, 13247098470561628454),
(typeof(uavcan_protocol_file_BeginFirmwareUpdate_res), 40, 13247098470561628454),
(typeof(uavcan_protocol_file_GetInfo_req), 45, 5765884188786062641),
(typeof(uavcan_protocol_file_GetInfo_res), 45, 5765884188786062641),
(typeof(uavcan_protocol_file_GetDirectoryEntryInfo_req), 46, 10108022236268714617),
(typeof(uavcan_protocol_file_GetDirectoryEntryInfo_res), 46, 10108022236268714617),
(typeof(uavcan_protocol_file_Delete_req), 47, 8675213371366918058),
(typeof(uavcan_protocol_file_Delete_res), 47, 8675213371366918058),
(typeof(uavcan_protocol_file_Read_req), 48, 10218045864953509496),
(typeof(uavcan_protocol_file_Read_res), 48, 10218045864953509496),
(typeof(uavcan_protocol_file_Write_req), 49, 5862175833252529193),
(typeof(uavcan_protocol_file_Write_res), 49, 5862175833252529193),
(typeof(uavcan_protocol_param_ExecuteOpcode_req), 10, 4256775510155711181),
(typeof(uavcan_protocol_param_ExecuteOpcode_res), 10, 4256775510155711181),
(typeof(uavcan_protocol_param_GetSet_req), 11, 12084885103907546325),
(typeof(uavcan_protocol_param_GetSet_res), 11, 12084885103907546325),
};}