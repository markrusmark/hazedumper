' 2022-08-09 12:04:22.747605200 UTC

Namespace hazedumper
    Public Const timestamp as Integer = &H62F24D46
    Public Shared Class netvars
        Public Const cs_gamerules_data as Integer = &H0
        Public Const m_ArmorValue as Integer = &H117CC
        Public Const m_Collision as Integer = &H320
        Public Const m_CollisionGroup as Integer = &H474
        Public Const m_Local as Integer = &H2FCC
        Public Const m_MoveType as Integer = &H25C
        Public Const m_OriginalOwnerXuidHigh as Integer = &H31D4
        Public Const m_OriginalOwnerXuidLow as Integer = &H31D0
        Public Const m_SurvivalGameRuleDecisionTypes as Integer = &H1328
        Public Const m_SurvivalRules as Integer = &HD00
        Public Const m_aimPunchAngle as Integer = &H303C
        Public Const m_aimPunchAngleVel as Integer = &H3048
        Public Const m_angEyeAnglesX as Integer = &H117D0
        Public Const m_angEyeAnglesY as Integer = &H117D4
        Public Const m_bBombDefused as Integer = &H29C0
        Public Const m_bBombPlanted as Integer = &H9A5
        Public Const m_bBombTicking as Integer = &H2990
        Public Const m_bFreezePeriod as Integer = &H20
        Public Const m_bGunGameImmunity as Integer = &H9990
        Public Const m_bHasDefuser as Integer = &H117DC
        Public Const m_bHasHelmet as Integer = &H117C0
        Public Const m_bInReload as Integer = &H32B5
        Public Const m_bIsDefusing as Integer = &H997C
        Public Const m_bIsQueuedMatchmaking as Integer = &H74
        Public Const m_bIsScoped as Integer = &H9974
        Public Const m_bIsValveDS as Integer = &H7C
        Public Const m_bSpotted as Integer = &H93D
        Public Const m_bSpottedByMask as Integer = &H980
        Public Const m_bStartedArming as Integer = &H3400
        Public Const m_bUseCustomAutoExposureMax as Integer = &H9D9
        Public Const m_bUseCustomAutoExposureMin as Integer = &H9D8
        Public Const m_bUseCustomBloomScale as Integer = &H9DA
        Public Const m_clrRender as Integer = &H70
        Public Const m_dwBoneMatrix as Integer = &H26A8
        Public Const m_fAccuracyPenalty as Integer = &H3340
        Public Const m_fFlags as Integer = &H104
        Public Const m_flC4Blow as Integer = &H29A0
        Public Const m_flCustomAutoExposureMax as Integer = &H9E0
        Public Const m_flCustomAutoExposureMin as Integer = &H9DC
        Public Const m_flCustomBloomScale as Integer = &H9E4
        Public Const m_flDefuseCountDown as Integer = &H29BC
        Public Const m_flDefuseLength as Integer = &H29B8
        Public Const m_flFallbackWear as Integer = &H31E0
        Public Const m_flFlashDuration as Integer = &H10470
        Public Const m_flFlashMaxAlpha as Integer = &H1046C
        Public Const m_flLastBoneSetupTime as Integer = &H2928
        Public Const m_flLowerBodyYawTarget as Integer = &H9ADC
        Public Const m_flNextAttack as Integer = &H2D80
        Public Const m_flNextPrimaryAttack as Integer = &H3248
        Public Const m_flSimulationTime as Integer = &H268
        Public Const m_flTimerLength as Integer = &H29A4
        Public Const m_hActiveWeapon as Integer = &H2F08
        Public Const m_hBombDefuser as Integer = &H29C4
        Public Const m_hMyWeapons as Integer = &H2E08
        Public Const m_hObserverTarget as Integer = &H339C
        Public Const m_hOwner as Integer = &H29DC
        Public Const m_hOwnerEntity as Integer = &H14C
        Public Const m_hViewModel as Integer = &H3308
        Public Const m_iAccountID as Integer = &H2FD8
        Public Const m_iClip1 as Integer = &H3274
        Public Const m_iCompetitiveRanking as Integer = &H1A84
        Public Const m_iCompetitiveWins as Integer = &H1B88
        Public Const m_iCrosshairId as Integer = &H11838
        Public Const m_iDefaultFOV as Integer = &H333C
        Public Const m_iEntityQuality as Integer = &H2FBC
        Public Const m_iFOV as Integer = &H31F4
        Public Const m_iFOVStart as Integer = &H31F8
        Public Const m_iGlowIndex as Integer = &H10488
        Public Const m_iHealth as Integer = &H100
        Public Const m_iItemDefinitionIndex as Integer = &H2FBA
        Public Const m_iItemIDHigh as Integer = &H2FD0
        Public Const m_iMostRecentModelBoneCounter as Integer = &H2690
        Public Const m_iObserverMode as Integer = &H3388
        Public Const m_iShotsFired as Integer = &H103E0
        Public Const m_iState as Integer = &H3268
        Public Const m_iTeamNum as Integer = &HF4
        Public Const m_lifeState as Integer = &H25F
        Public Const m_nBombSite as Integer = &H2994
        Public Const m_nFallbackPaintKit as Integer = &H31D8
        Public Const m_nFallbackSeed as Integer = &H31DC
        Public Const m_nFallbackStatTrak as Integer = &H31E4
        Public Const m_nForceBone as Integer = &H268C
        Public Const m_nModelIndex as Integer = &H258
        Public Const m_nTickBase as Integer = &H3440
        Public Const m_nViewModelIndex as Integer = &H29D0
        Public Const m_rgflCoordinateFrame as Integer = &H444
        Public Const m_szCustomName as Integer = &H304C
        Public Const m_szLastPlaceName as Integer = &H35C4
        Public Const m_thirdPersonViewAngles as Integer = &H31E8
        Public Const m_vecOrigin as Integer = &H138
        Public Const m_vecVelocity as Integer = &H114
        Public Const m_vecViewOffset as Integer = &H108
        Public Const m_viewPunchAngle as Integer = &H3030
        Public Const m_zoomLevel as Integer = &H33E0
    End Class
    Public Shared Class signatures
        Public Const anim_overlays as Integer = &H2990
        Public Const clientstate_choked_commands as Integer = &H4D30
        Public Const clientstate_delta_ticks as Integer = &H174
        Public Const clientstate_last_outgoing_command as Integer = &H4D2C
        Public Const clientstate_net_channel as Integer = &H9C
        Public Const convar_name_hash_table as Integer = &H2F190
        Public Const dwClientState as Integer = &H58CFDC
        Public Const dwClientState_GetLocalPlayer as Integer = &H180
        Public Const dwClientState_IsHLTV as Integer = &H4D48
        Public Const dwClientState_Map as Integer = &H28C
        Public Const dwClientState_MapDirectory as Integer = &H188
        Public Const dwClientState_MaxPlayer as Integer = &H388
        Public Const dwClientState_PlayerInfo as Integer = &H52C0
        Public Const dwClientState_State as Integer = &H108
        Public Const dwClientState_ViewAngles as Integer = &H4D90
        Public Const dwEntityList as Integer = &H4DDB91C
        Public Const dwForceAttack as Integer = &H320BDE8
        Public Const dwForceAttack2 as Integer = &H320BDF4
        Public Const dwForceBackward as Integer = &H320BE30
        Public Const dwForceForward as Integer = &H320BE24
        Public Const dwForceJump as Integer = &H52858FC
        Public Const dwForceLeft as Integer = &H320BE3C
        Public Const dwForceRight as Integer = &H320BE48
        Public Const dwGameDir as Integer = &H62B900
        Public Const dwGameRulesProxy as Integer = &H52F912C
        Public Const dwGetAllClasses as Integer = &HDE9C9C
        Public Const dwGlobalVars as Integer = &H58CCE0
        Public Const dwGlowObjectManager as Integer = &H5324618
        Public Const dwInput as Integer = &H522CEF0
        Public Const dwInterfaceLinkList as Integer = &H96EF44
        Public Const dwLocalPlayer as Integer = &HDBF4BC
        Public Const dwMouseEnable as Integer = &HDC51C8
        Public Const dwMouseEnablePtr as Integer = &HDC5198
        Public Const dwPlayerResource as Integer = &H320A180
        Public Const dwRadarBase as Integer = &H5210694
        Public Const dwSensitivity as Integer = &HDC5064
        Public Const dwSensitivityPtr as Integer = &HDC5038
        Public Const dwSetClanTag as Integer = &H8A410
        Public Const dwViewMatrix as Integer = &H4DCD234
        Public Const dwWeaponTable as Integer = &H522D9B4
        Public Const dwWeaponTableIndex as Integer = &H326C
        Public Const dwYawPtr as Integer = &HDC4E28
        Public Const dwZoomSensitivityRatioPtr as Integer = &HDCB610
        Public Const dwbSendPackets as Integer = &HD8452
        Public Const dwppDirect3DDevice9 as Integer = &HA6050
        Public Const find_hud_element as Integer = &H2DE55A80
        Public Const force_update_spectator_glow as Integer = &H3BE35A
        Public Const interface_engine_cvar as Integer = &H3EA3C
        Public Const is_c4_owner as Integer = &H3CB3D0
        Public Const m_bDormant as Integer = &HED
        Public Const m_bIsLocalPlayer as Integer = &H3628
        Public Const m_flSpawnTime as Integer = &H103C0
        Public Const m_pStudioHdr as Integer = &H2950
        Public Const m_pitchClassPtr as Integer = &H5210930
        Public Const m_yawClassPtr as Integer = &HDC4E28
        Public Const model_ambient_min as Integer = &H590054
        Public Const set_abs_angles as Integer = &H1E59F0
        Public Const set_abs_origin as Integer = &H1E5830
    End Class
End Namespace
